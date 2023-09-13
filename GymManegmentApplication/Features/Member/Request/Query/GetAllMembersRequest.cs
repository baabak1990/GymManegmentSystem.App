using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManegmentApplication.DTOs.MemberDTOs;
using MediatR;

namespace GymManegmentApplication.Features.Member.Request.Query
{
    public class GetAllMembersRequest : IRequest<IReadOnlyCollection<MemberDto>>
    {
    }
}
