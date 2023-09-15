using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GymManegmentApplication.Contracts.Presistance;
using GymManegmentApplication.Features.Member.Request.Command;
using MediatR;

namespace GymManegmentApplication.Features.Member.Handler.Command
{
    public class DeleteMemberCommandHandler : IRequestHandler<DeleteMemberCommand>
    {

        private readonly IMemberRepository _memberRepository;
        private readonly IMapper _mapper;

        public DeleteMemberCommandHandler(IMemberRepository memberRepository, IMapper mapper)
        {
            _memberRepository = memberRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteMemberCommand request, CancellationToken cancellationToken)
        {
            var member = await _memberRepository.Get(request.Id);
            if (member == null) throw new Exception("Something webt wrong !!! please try again!!");
            await _memberRepository.Delete(member);
            return Unit.Value;
        }
    }
}
