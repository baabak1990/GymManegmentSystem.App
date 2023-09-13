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
    public class GetMemberRequestHandler : IRequestHandler<GetMemberRequest, MemberDto>
    {
        private readonly IMemberRepository _memberRepository;
        private readonly IMapper _mapper;

        public GetMemberRequestHandler(IMemberRepository memberRepository, IMapper mapper)
        {
            _memberRepository = memberRepository;
            _mapper = mapper;
        }

        public async Task<MemberDto> Handle(GetMemberRequest request, CancellationToken cancellationToken)
        {
            var member = await _memberRepository.Get(request.Id);
            if (member == null)
            {
                throw new Exception("There Is Some thing Wrong !!! Please Try again !!!");
            }

            return _mapper.Map<MemberDto>(member);
        }
    }
}
