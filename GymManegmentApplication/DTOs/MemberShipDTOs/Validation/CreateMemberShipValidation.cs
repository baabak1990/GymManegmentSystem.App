using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace GymManegmentApplication.DTOs.MemberShipDTOs.Validation
{
    public class CreateMemberShipValidation:AbstractValidator<CreateMembershipDTO>
    {
        public CreateMemberShipValidation()
        {
            Include(new IMembershipValidation());

        }
    }
}
