using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GymManegmentApplication.Contracts.Presistance;
using GymManegmentApplication.DTOs.MemberDTOs.Validation;
using GymManegmentApplication.Exceptions;
using GymManegmentApplication.Features.Member.Request.Command;
using GymManegmentApplication.Response;
using MediatR;

namespace GymManegmentApplication.Features.Member.Handler.Command
{
    public class EditMemberCommandHandler : IRequestHandler<EditMemberCommand, BaseCommonResponse>
    {
        private readonly IMemberRepository _memberRepository;
        private readonly IMapper _mapper;

        public EditMemberCommandHandler(IMemberRepository memberRepository, IMapper mapper)
        {
            _memberRepository = memberRepository;
            _mapper = mapper;
        }

        public async Task<BaseCommonResponse> Handle(EditMemberCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommonResponse();
            var validation = new EditMemberValidation(_memberRepository);
            var validator = await validation.ValidateAsync(request.EditMemberDto);
            if (validator.IsValid == false)
            {
                response.IsSuccess = false;
                response.Message = "validation failed";
                response.Errors=validator.Errors.Select(q=>q.ErrorMessage).ToList();
            }


            var member = await _memberRepository.Get(request.EditMemberDto.Id);
            if (member == null) throw new NotFoundException(nameof(member),request.EditMemberDto.Id);


            _mapper.Map(request.EditMemberDto, member);
            await _memberRepository.Update(member);
            response.IsSuccess = true;
            response.Message = "Edited Successfully";
            response.Id=request.EditMemberDto.Id;
            return response;
        }
    }
}
