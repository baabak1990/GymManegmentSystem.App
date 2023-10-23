using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GymManegmentApplication.Contracts.Presistance;
using GymManegmentApplication.DTOs.MemberDTOs;
using GymManegmentApplication.Features.Member.Request.Query;
using MediatR;

namespace GymManegmentApplication.Features.Member.Handler.Query
{
    public class GetAllMemberWithDetailsRequestHandler:IRequestHandler<GetAllMemberWithDetailsRequest,IReadOnlyCollection<MemberDto>>
    {
        private readonly IMemberRepository _memberRepository;
        private readonly IMapper _mapper;

        public GetAllMemberWithDetailsRequestHandler(IMemberRepository memberRepository, IMapper mapper)
        {
            _memberRepository = memberRepository;
            _mapper = mapper;
        }
        public async Task<IReadOnlyCollection<MemberDto>> Handle(GetAllMemberWithDetailsRequest request, CancellationToken cancellationToken)
        {
            var members = await _memberRepository.GetAllWithDetails();
            return _mapper.Map<IReadOnlyCollection<MemberDto>>(members);
        }
    }
}
