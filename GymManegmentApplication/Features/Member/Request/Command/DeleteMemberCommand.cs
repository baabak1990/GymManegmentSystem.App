using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManegmentApplication.Response;
using MediatR;

namespace GymManegmentApplication.Features.Member.Request.Command
{
    public class DeleteMemberCommand : IRequest<BaseCommonResponse>
    {
        public int Id { get; set; }
    }
}
