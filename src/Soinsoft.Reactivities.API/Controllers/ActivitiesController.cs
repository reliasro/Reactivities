using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Soinsoft.Reactivities.Persistence;
using Soinsoft.Reactivities.Domain;

namespace Soinsoft.Reactivities.API.Controllers
{
    public class ActivitiesController : BaseAPIController
    {
        private DataContext _context;
        public ActivitiesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities(){

            return await _context.Activities.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivity(Guid id){

            return await _context.Activities.FindAsync(id);
        }
    }
}