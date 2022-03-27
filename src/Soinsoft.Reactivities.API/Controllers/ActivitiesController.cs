using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Soinsoft.Reactivities.Persistence;
using Soinsoft.Reactivities.Domain;
using Soinsoft.Reactivities.Application.Features.Activities.Querys.List;
using MediatR;


namespace Soinsoft.Reactivities.API.Controllers
{
    public class ActivitiesController : BaseAPIController
    {
        private readonly IMediator _mediator;
        public ActivitiesController(IMediator mediator)
        {
            _mediator = mediator;
   
        }

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities(){

            return await _mediator.Send(new ListQuery());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivity(Guid id){

           // return Ok(await Task.Run());
            await Task.CompletedTask;
            return new Activity(){

            };
        }
    }
}