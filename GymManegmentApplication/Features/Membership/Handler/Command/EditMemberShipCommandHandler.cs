using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GymManegmentApplication.Contracts.Presistance;
using GymManegmentApplication.DTOs.MemberShipDTOs.Validation;
using GymManegmentApplication.Features.Membership.Request.Command;
using MediatR;

namespace GymManegmentApplication.Features.Membership.Handler.Command
{
    public class EditMemberShipCommandHandler : IRequestHandler<EditMemberShipCommand, Unit>
    {
        private readonly IMemberShipRepository _membershipRepository;
        private readonly IMapper _mapper;

        public EditMemberShipCommandHandler(IMemberShipRepository membershipRepository, IMapper mapper)
        {
            _membershipRepository = membershipRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(EditMemberShipCommand request, CancellationToken cancellationToken)
        {
            var validation = new EditMembershipValidation();
            var validator = await validation.ValidateAsync(request.EditMemberShipDTo);
            if (validator.IsValid == false) throw new Exception("Something Wrong !!");


            var membership = await _membershipRepository.Get(request.EditMemberShipDTo.Id);
            if (membership == null) throw new Exception("something went wrong !!! please Try again !!");
            _mapper.Map(request.EditMemberShipDTo, membership);
            await _membershipRepository.Update(membership);
            return Unit.Value;
        }
    }
}
