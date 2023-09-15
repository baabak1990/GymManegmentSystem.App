using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using GymManegmentApplication.Contracts.Presistance;

namespace GymManegmentApplication.DTOs.MemberDTOs.Validation
{
    public class EditMemberValidation:AbstractValidator<EditMemberDto>
    {
        private readonly IMemberRepository _memberRepository;

        public EditMemberValidation(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
            Include(new IMemberDtoValidation(memberRepository));

            RuleFor(m => m.Id)
                .NotEmpty().WithMessage("Can not be Empty")
                .NotNull().WithMessage("Can not be Null")
                .GreaterThan(0).WithMessage("Should be greater than 0");
        }
    }
}
