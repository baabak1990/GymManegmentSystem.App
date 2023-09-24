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
using GymManegmentSystemDomin.Entity.Membership;
using MediatR;

namespace GymManegmentApplication.Features.Membership.Handler.Command
{
    public class CreateMembershipRequestHandler : IRequestHandler<CreateMembershipRequest, BaseCommonResponse>
    {
        private readonly IMemberShipRepository _membershipRepository;
        private readonly IMapper _mapper;

        public CreateMembershipRequestHandler(IMemberShipRepository membershipRepository, IMapper mapper)
        {
            _membershipRepository = membershipRepository;
            _mapper = mapper;
        }

        public async Task<BaseCommonResponse> Handle(CreateMembershipRequest request, CancellationToken cancellationToken)
        {
            var response = new BaseCommonResponse();

            var validation = new CreateMemberShipValidation();
            var validator = await validation.ValidateAsync(request.DTO);
            if (validator.IsValid == false)
            {
                response.IsSuccess = false;
                response.Message = "Some Validation Error Please Try Again";
                response.Errors = validator.Errors.Select(q => q.ErrorMessage).ToList();
            }
            else
            {
                var membership = _mapper.Map<MemberShip>(request.DTO);
                membership = await _membershipRepository.Add(membership);
                response.IsSuccess = true;
                response.Message = "Creation Successfully Done !!";
                response.Id = membership.Id;
            }
            return response;

        }
    }
}
