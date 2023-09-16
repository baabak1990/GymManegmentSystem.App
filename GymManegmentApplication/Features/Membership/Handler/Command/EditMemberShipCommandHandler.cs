using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GymManegmentApplication.Contracts.Presistance;
using GymManegmentApplication.DTOs.MemberShipDTOs.Validation;
using GymManegmentApplication.Exceptions;
using GymManegmentApplication.Features.Membership.Request.Command;
using GymManegmentApplication.Response;
using MediatR;

namespace GymManegmentApplication.Features.Membership.Handler.Command
{
    public class EditMemberShipCommandHandler : IRequestHandler<EditMemberShipCommand, BaseCommonResponse>
    {
        private readonly IMemberShipRepository _membershipRepository;
        private readonly IMapper _mapper;

        public EditMemberShipCommandHandler(IMemberShipRepository membershipRepository, IMapper mapper)
        {
            _membershipRepository = membershipRepository;
            _mapper = mapper;
        }

        public async Task<BaseCommonResponse> Handle(EditMemberShipCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommonResponse();
            var validation = new EditMembershipValidation();
            var validator = await validation.ValidateAsync(request.EditMemberShipDTo);
            if (validator.IsValid == false)
            {
                response.IsSuccess=false;
                response.Message = "Some validation Failed";
                response.Errors=validator.Errors.Select(q=>q.ErrorMessage).ToList();
            }


            var membership = await _membershipRepository.Get(request.EditMemberShipDTo.Id);
            if (membership == null)
            {
                response.IsSuccess = false;
                response.Message = "Some validation Failed";
                throw new NotFoundException(nameof(membership), request.EditMemberShipDTo.Id);
            }


            _mapper.Map(request.EditMemberShipDTo, membership);
            await _membershipRepository.Update(membership);
            response.IsSuccess = true;
            response.Message = "Edit Complete";
            response.Id=request.EditMemberShipDTo.Id;
            return response;
        }
    }
}
