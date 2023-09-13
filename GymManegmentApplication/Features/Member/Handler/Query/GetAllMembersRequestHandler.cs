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
    public class GetAllMembersRequestHandler : IRequestHandler<GetAllMembersRequest, IReadOnlyCollection<MemberDto>>
    {
        private readonly IMemberRepository _memberRepository;
        private readonly IMapper _mapper;

        public GetAllMembersRequestHandler(IMemberRepository memberRepository, IMapper mapper)
        {
            _memberRepository = memberRepository;
            _mapper = mapper;
        }

        public async Task<IReadOnlyCollection<MemberDto>> Handle(GetAllMembersRequest request, CancellationToken cancellationToken)
        {
            var members = await _memberRepository.GetAll();
            return _mapper.Map<IReadOnlyCollection<MemberDto>>(members);

        }
    }
}
