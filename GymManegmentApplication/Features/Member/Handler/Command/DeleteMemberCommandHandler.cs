using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GymManegmentApplication.Contracts.Presistance;
using GymManegmentApplication.Exceptions;
using GymManegmentApplication.Features.Member.Request.Command;
using GymManegmentApplication.Response;
using MediatR;

namespace GymManegmentApplication.Features.Member.Handler.Command
{
    public class DeleteMemberCommandHandler : IRequestHandler<DeleteMemberCommand, BaseCommonResponse>
    {
       

        private readonly IMemberRepository _memberRepository;
        private readonly IMapper _mapper;

        public DeleteMemberCommandHandler(IMemberRepository memberRepository, IMapper mapper)
        {
            _memberRepository = memberRepository;
            _mapper = mapper;
        }
        public async Task<BaseCommonResponse> Handle(DeleteMemberCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommonResponse();

            var member = await _memberRepository.Get(request.Id);
            if (member == null)
            {
                response.IsSuccess=false;
                response.Message = "Can not find This Member";
                throw new NotFoundException(nameof(member), request.Id);
            }


            await _memberRepository.Delete(member);
            response.IsSuccess=true; 
            response.Message = "Delete Complete Successfully";
            response.Id=request.Id;

            return response;
        }
    }
}
