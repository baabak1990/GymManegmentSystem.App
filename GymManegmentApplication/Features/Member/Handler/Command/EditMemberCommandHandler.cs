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
    public class EditMemberCommandHandler : IRequestHandler<EditMemberCommand, Unit>
    {
        private readonly IMemberRepository _memberRepository;
        private readonly IMapper _mapper;

        public EditMemberCommandHandler(IMemberRepository memberRepository, IMapper mapper)
        {
            _memberRepository = memberRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(EditMemberCommand request, CancellationToken cancellationToken)
        {
            var member = await _memberRepository.Get(request.EditMemberDto.Id);
            if (member == null) throw new Exception("Something wrong !!! please Try again");
            _mapper.Map(request.EditMemberDto, member);
            await _memberRepository.Update(member);
            return Unit.Value;
        }
    }
}
