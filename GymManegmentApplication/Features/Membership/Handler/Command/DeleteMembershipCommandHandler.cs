using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GymManegmentApplication.Contracts.Presistance;
using GymManegmentApplication.Features.Membership.Request.Command;
using MediatR;

namespace GymManegmentApplication.Features.Membership.Handler.Command
{
    public class DeleteMembershipCommandHandler : IRequestHandler<DeleteMembershipCommand>
    {
        private readonly IMemberShipRepository _membershipRepository;
        private readonly IMapper _mapper;

        public DeleteMembershipCommandHandler(IMemberShipRepository membershipRepository, IMapper mapper)
        {
            _membershipRepository = membershipRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteMembershipCommand request, CancellationToken cancellationToken)
        {
            var membership = await _membershipRepository.Get(request.Id);
            if (membership == null) throw new Exception("Something went wrong !! Please Try Again !!!");
            await _membershipRepository.Delete(membership);
            return Unit.Value;
        }
    }
}
