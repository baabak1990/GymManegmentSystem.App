using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace GymManegmentApplication.Features.Member.Request.Command
{
    public class DeleteMemberCommand : IRequest
    {
        public int Id { get; set; }
    }
}
