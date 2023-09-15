using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace GymManegmentApplication.DTOs.MemberShipDTOs.Validation
{
    public class IMembershipValidation:AbstractValidator<IMembershipDto>
    {

        public IMembershipValidation()
        {
            RuleFor(m => m.Duration)
                .LessThan(31).WithMessage("Duration must be lesser than 31 Days")
                .GreaterThanOrEqualTo(1).WithMessage("Duration Must be Greater Than 1 Day")
                .NotEmpty().WithMessage("Can not be Empty")
                .NotNull().WithMessage("Can not be Null");
            RuleFor(m => m.Name)
                .NotEmpty().WithMessage("Can not be Empty")
                .NotNull().WithMessage("Can not be Null");
            RuleFor(m=>m.Price)
                .GreaterThan(0).WithMessage("Duration Must be Greater Than 0")
                .NotEmpty().WithMessage("Can not be Empty")
                .NotNull().WithMessage("Can not be Null");
        }
    }
}
