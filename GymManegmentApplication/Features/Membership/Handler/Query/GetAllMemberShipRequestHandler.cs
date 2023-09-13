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
    public class GetAllMemberShipRequestHandler : IRequestHandler<GetAllMemberShipRequest, IReadOnlyCollection<MembershipDto>>
    {
        private readonly IMemberShipRepository _memberShipRepository;
        private readonly IMapper _mapper;

        public GetAllMemberShipRequestHandler(IMemberShipRepository memberShipRepository, IMapper mapper)
        {
            _memberShipRepository = memberShipRepository;
            _mapper = mapper;
        }

        public async Task<IReadOnlyCollection<MembershipDto>> Handle(GetAllMemberShipRequest request, CancellationToken cancellationToken)
        {
            var membershiprs = await _memberShipRepository.GetAll();
            return _mapper.Map<IReadOnlyCollection<MembershipDto>>(membershiprs);
        }
    }
}
