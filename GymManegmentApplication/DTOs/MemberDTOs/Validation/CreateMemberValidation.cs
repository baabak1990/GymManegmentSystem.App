using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using GymManegmentApplication.Contracts.Presistance;

namespace GymManegmentApplication.DTOs.MemberDTOs.Validation
{
    public class CreateMemberValidation:AbstractValidator<CreateMemberDto>
    {
        private readonly IMemberRepository _memberRepository;
        public CreateMemberValidation(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
            Include(new IMemberDtoValidation(memberRepository));
            
        }
    }
}
