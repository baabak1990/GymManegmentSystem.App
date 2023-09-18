using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GymManegmentApplication.Contracts.Infrastructures;
using GymManegmentApplication.Contracts.Presistance;
using GymManegmentApplication.DTOs.MemberDTOs.Validation;
using GymManegmentApplication.Exceptions;
using GymManegmentApplication.Features.Member.Request.Command;
using GymManegmentApplication.Model;
using GymManegmentApplication.Response;
using Humanizer;
using MediatR;

namespace GymManegmentApplication.Features.Member.Handler.Command
{
    public class CreateMemberCommandHandler : IRequestHandler<CreatememberCommand, int>
    {
        #region Constructor

        private readonly IMemberRepository _memberRepository;
        private readonly IMapper _mapper;
        private readonly IEmailSender _emailSender;

        public CreateMemberCommandHandler(IMemberRepository memberRepository, IMapper mapper, IEmailSender emailSender)
        {
            _memberRepository = memberRepository;
            _mapper = mapper;
            _emailSender = emailSender;
        }

        #endregion

        public async Task<int> Handle(CreatememberCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommonResponse();

            var validation = new CreateMemberValidation(_memberRepository);
            var validator = await validation.ValidateAsync(request.CreateMemberDto);

            if (validator.IsValid == false)
            {
                response.IsSuccess = false;
                response.Message = "Creation Filed";
                response.Errors = validator.Errors.Select(q => q.ErrorMessage).ToList();
            }



            var member = _mapper.Map<GymManegmentSystemDomin.Entity.Member.Member>(request.CreateMemberDto);
            member = await _memberRepository.Add(member);

            //Sending email or SMS For client 
            var email = new Email()
            {
                To = "Sample@gmail.com",
                Body = $"Dear {request.CreateMemberDto.FirstName} {request.CreateMemberDto.LastName} " +
                        $"Your are registered successfully . Your membership started from {DateTime.Now} ",
                Subject = "You Are Registered successfully !!!"
            };

            return member.Id;
        }
    }
}
