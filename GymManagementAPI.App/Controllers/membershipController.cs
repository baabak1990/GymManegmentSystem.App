using GymManegmentApplication.DTOs.MemberShipDTOs;
using GymManegmentApplication.Features.Membership.Request.Command;
using GymManegmentApplication.Features.Membership.Request.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GymManagementAPI.App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class membershipController : ControllerBase
    {
        #region Constructor

        private readonly IMediator _mediator;
        public membershipController(IMediator mediator)
        {
            _mediator = mediator;
        }

        #endregion
        // GET: api/<membershipController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IReadOnlyCollection<MembershipDto>>> Get()
        {
            var members = await _mediator.Send(new GetAllMemberShipRequest());
            return Ok(members);
        }

        // GET api/<membershipController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<MembershipDto>> Get(int id)
        {
            var member = await _mediator.Send(new GetMemberShipRequest());
            return Ok(member);
        }

        // POST api/<membershipController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<int>> Post([FromBody] CreateMembershipDTO createMembershipDto)
        {
            var command = new CreateMembershipRequest { DTO = createMembershipDto};
            var response=await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<membershipController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult> Put(int id, [FromBody] EditMemberShipDTo memberShipDTo )
        {
            var command = new EditMemberShipCommand { EditMemberShipDTo = memberShipDTo};
            var response= await _mediator.Send(command);
            return NoContent();
        }

        // DELETE api/<membershipController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult> Delete(int id)
        {
            var response = await _mediator.Send(new DeleteMembershipCommand { Id = id});
            return NoContent();
        }
    }
}
