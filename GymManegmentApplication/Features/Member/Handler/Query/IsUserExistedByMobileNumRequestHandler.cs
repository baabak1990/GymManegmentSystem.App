using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManegmentApplication.Contracts.Presistance;
using GymManegmentApplication.Features.Member.Request.Query;
using MediatR;

namespace GymManegmentApplication.Features.Member.Handler.Query
{
    public class IsUserExistedByMobileNumRequestHandler : IRequestHandler<IsUserExistedByMobileNumRequest, bool>
    {
        private readonly IMemberRepository _memberRepository;

        public IsUserExistedByMobileNumRequestHandler(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }


        public async Task<bool> Handle(IsUserExistedByMobileNumRequest request, CancellationToken cancellationToken)
        {
            return _memberRepository.IsUserExistedByMobileNum(request.MobileNum);
        }
    }
}
