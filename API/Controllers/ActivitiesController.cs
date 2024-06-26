﻿using Application.Activities;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System.Reflection.Metadata.Ecma335;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {


        [HttpGet] //api/activities
        public async Task<ActionResult<IEnumerable<Activity>>> GetActivities()
        {

            return await Mediator.Send(new List.Query());
        }

        [HttpGet("{id}")] //api/activities
        public async Task<ActionResult<Activity>> GetActivities(Guid id)
        {

            return await Mediator.Send(new Details.Query { Id = id });
        }

        [HttpPost]
        public async Task<IActionResult> CreateActivity(Activity activity)
        {
            return Ok(await Mediator.Send(new Create.Command { Activity = activity }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditActivity(Guid id,Activity activity)
        {
            activity.Id = id;
            return Ok(await Mediator.Send(new Edit.Command { Activity = activity }));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActivity(Guid id)
        {

            
            return Ok(await Mediator.Send(new Delete.Command { Id = id }));
        }

    }
}
