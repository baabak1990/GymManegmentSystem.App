using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GymManegmentApplication.Contracts.Presistance;
using GymManegmentApplication.DTOs.MemberShipDTOs;
using GymManegmentApplication.Features.Membership.Request.Query;
using MediatR;

namespace GymManegmentApplication.Features.Membership.Handler.Query
{
    public class GetMemberShipRequestHandler : IRequestHandler<GetMemberShipRequest, MembershipDto>
    {

        private readonly IMemberShipRepository _membershipRepository;
        private readonly IMapper _mapper;

        public GetMemberShipRequestHandler(IMemberShipRepository membershipRepository, IMapper mapper)
        {
            _membershipRepository = membershipRepository;
            _mapper = mapper;
        }
        public async Task<MembershipDto> Handle(GetMemberShipRequest request, CancellationToken cancellationToken)
        {
            var membership = await _membershipRepository.Get(request.Id);
            if (membership == null)
            {
                throw new Exception("There is something Wrong !!!");
            }

            return _mapper.Map<MembershipDto>(membership);
        }
    }
}
