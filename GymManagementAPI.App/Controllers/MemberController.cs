﻿using GymManegmentApplication.DTOs.MemberDTOs;
using GymManegmentApplication.Features.Member.Request.Command;
using GymManegmentApplication.Features.Member.Request.Query;
using GymManegmentApplication.Features.Membership.Request.Command;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GymManagementAPI.App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        #region Constructor

        private readonly IMediator _mediator;
        public MemberController(IMediator mediator)
        {
            _mediator = mediator;
        }

        #endregion
        // GET: api/<MemberController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IReadOnlyCollection<MemberDto>>> Get()
        {
            var members = await _mediator.Send(new GetAllMembersRequest());
            return Ok(members);
        }

        // GET api/<MemberController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<MemberDto>> Get(int id)
        {
            var member = await _mediator.Send(new GetMemberRequest{Id=id});
            return Ok(member);
        }

        // POST api/<MemberController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<int>> Createmember([FromBody] CreateMemberDto createMemberDto)
        {
            var command = new CreatememberCommand{CreateMemberDto = createMemberDto};
            var response=await _mediator.Send(command);
            return Ok(response);

        }

        // PUT api/<MemberController>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult> editMember( [FromBody] EditMemberDto editMemberDto)
        {
            var command = new EditMemberCommand { EditMemberDto = editMemberDto};
            var response= await _mediator.Send(command);
            return NoContent();
        }

        // DELETE api/<MemberController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult> Delete(int id)
        {
            var command=new DeleteMemberCommand() { Id=id};
            var response = await _mediator.Send(command);
            return NoContent();
        }
    }
}
