using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace GymManegmentApplication.DTOs.MemberShipDTOs.Validation
{
    public class EditMembershipValidation:AbstractValidator<EditMemberShipDTo>
    {
        public EditMembershipValidation()
        {
            Include(new IMembershipValidation());
            RuleFor(m => m.Id)
                .NotEmpty().WithMessage("can not be Empty")
                .NotNull().WithMessage("Can not be Null")
                .GreaterThan(0).WithMessage("Can not be lesser Than 0");
        }
    }
}
