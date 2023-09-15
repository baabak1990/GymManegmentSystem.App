using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GymManegmentApplication.Contracts.Presistance;
using GymManegmentApplication.DTOs.MemberShipDTOs.Validation;
using GymManegmentApplication.Features.Membership.Request.Command;
using GymManegmentSystemDomin.Entity.Membership;
using MediatR;

namespace GymManegmentApplication.Features.Membership.Handler.Command
{
    public class CreateMembershipRequestHandler : IRequestHandler<CreateMembershipRequest, int>
    {
        private readonly IMemberShipRepository _membershipRepository;
        private readonly IMapper _mapper;

        public CreateMembershipRequestHandler(IMemberShipRepository membershipRepository, IMapper mapper)
        {
            _membershipRepository = membershipRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateMembershipRequest request, CancellationToken cancellationToken)
        {
            var validation = new CreateMemberShipValidation();
            var validator = await validation.ValidateAsync(request.DTO);
            if (validator.IsValid == false) throw new Exception("Some of the field are not filled Appropriate !!!");
         

            var membrship = _mapper.Map<MemberShip>(request.DTO);
            membrship = await _membershipRepository.Add(membrship);
            if (membrship == null)
            {
                throw new Exception("Something went wrong ! Please Try Again !!!");
            }
            return membrship.Id;
        }
    }
}
