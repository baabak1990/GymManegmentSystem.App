﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManegmentApplication.DTOs.MemberShipDTOs;
using MediatR;

namespace GymManegmentApplication.Features.Membership.Request.Query
{
    public class GetMemberShipRequest : IRequest<MembershipDto>
    {
        public int Id { get; set; }
    }
}
