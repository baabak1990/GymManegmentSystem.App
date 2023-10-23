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
    public class GetMemberWithDetailsRequestHandler:IRequestHandler<GetMemberWithDetailsRequest,MemberDto>
    {
        private readonly IMemberRepository _memberRepository;
        private readonly IMapper _mapper;

        public GetMemberWithDetailsRequestHandler(IMemberRepository memberRepository, IMapper mapper)
        {
            _memberRepository = memberRepository;
            _mapper = mapper;
        }
        public async Task<MemberDto> Handle(GetMemberWithDetailsRequest request, CancellationToken cancellationToken)
        {
            var member = await _memberRepository.GetWithDetails(request.Id);
            if (member == null)
            {
                throw new Exception("Something went wrong Please Try again !!!");
            }

            return _mapper.Map<MemberDto>(member);
        }


    }
}
