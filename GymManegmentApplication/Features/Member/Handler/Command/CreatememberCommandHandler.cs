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
    public class CreatememberCommandHandler : IRequestHandler<CreatememberCommand, int>
    {
        private readonly IMemberRepository _memberRepository;
        private readonly IMapper _mapper;

        public CreatememberCommandHandler(IMemberRepository memberRepository, IMapper mapper)
        {
            _memberRepository = memberRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreatememberCommand request, CancellationToken cancellationToken)
        {
            var memebr = _mapper.Map<GymManegmentSystemDomin.Entity.Member.Member>(request.CreateMemberDto);
            memebr = await _memberRepository.Add(memebr);
            if (memebr==null)
            {
                throw new Exception("Something went wrong !!! Please Try again !!!");
            }

            return memebr.Id;
        }
    }
}
