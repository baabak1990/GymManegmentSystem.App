using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GymManegmentApplication.Contracts.Presistance;
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
            var memebrship = _mapper.Map<MemberShip>(request.DTO);
            memebrship = await _membershipRepository.Add(memebrship);
            if (memebrship == null)
            {
                throw new Exception("Something went wrong ! Please Try Again !!!");
            }
            return memebrship.Id;
        }
    }
}
