using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using GymManegmentApplication.Contracts.Presistance;

namespace GymManegmentApplication.DTOs.MemberDTOs.Validation
{
    public class IMemberDtoValidation : AbstractValidator<IMemberDto>
    {
        private readonly IMemberRepository _memberRepository;

        public IMemberDtoValidation(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;

            RuleFor(m => m.BirthDate)
                .LessThan(DateTime.Now).WithMessage("BirthDate Should Be lesser than This Year !!!")
                .NotEmpty().WithMessage("Can not be Empty")
                .NotNull().WithMessage("Can not be Null");

            RuleFor(m => m.FirstName)
                .NotEmpty().WithMessage("Can not be Empty")
                .NotNull().WithMessage("Can not be Null")
                .MaximumLength(150).WithMessage("Can not be more than 150 Character");

            RuleFor(m => m.LastName)
                .NotEmpty().WithMessage("Can not be Empty")
                .NotNull().WithMessage("Can not be Null")
                .MaximumLength(150).WithMessage("Can not be more than 150 Character");

            RuleFor(m => m.MobileNumber)
                .NotEmpty().WithMessage("Can not be Empty")
                .NotNull().WithMessage("Can not be Null")
                .Matches("(\\+98|0)?9\\d{9}$")
                .MustAsync(async (num, id) =>
                {
                    var exist = _memberRepository.IsUserExistedByMobileNum(num);
                    return !exist;
                })
                .WithMessage("MobileNumber is not valid");
            ;


            //RuleFor(m => m.Membership_Id)
            //    .GreaterThan(0)
            //    .MustAsync(async (id, token) =>
            //        {
            //            var existed = await _memberRepository.IsExisted(id);
            //            return !existed;
            //        }
            //    ).WithMessage("Is not Existed");
            //RuleFor(m=>m.MobileNumber)

        }
    }
}
