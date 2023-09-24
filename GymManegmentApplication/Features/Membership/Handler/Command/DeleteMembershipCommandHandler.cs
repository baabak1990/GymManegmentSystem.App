using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GymManegmentApplication.Contracts.Presistance;
using GymManegmentApplication.Exceptions;
using GymManegmentApplication.Features.Membership.Request.Command;
using GymManegmentApplication.Response;
using MediatR;

namespace GymManegmentApplication.Features.Membership.Handler.Command
{
    public class DeleteMembershipCommandHandler : IRequestHandler<DeleteMembershipCommand, BaseCommonResponse>
    {
        private readonly IMemberShipRepository _membershipRepository;
        private readonly IMapper _mapper;

        public DeleteMembershipCommandHandler(IMemberShipRepository membershipRepository, IMapper mapper)
        {
            _membershipRepository = membershipRepository;
            _mapper = mapper;
        }
        public async Task<BaseCommonResponse> Handle(DeleteMembershipCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommonResponse();
            var membership = await _membershipRepository.Get(request.Id);
            if (membership == null)
            {
                response.IsSuccess = false;
                response.Message = "Can not find this Membership";
                throw new NotFoundException($"{response.Message}", request.Id);
            }
            else
            {
                await _membershipRepository.Delete(membership);
                response.IsSuccess = true;
                response.Message = "Object Deleted Successfully";
            }
            return response;
        }
    }
}
