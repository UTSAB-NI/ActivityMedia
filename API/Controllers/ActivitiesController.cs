using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System.Reflection.Metadata.Ecma335;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        private readonly DataContext _context;
        public ActivitiesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet] //api/activities
        public async Task<ActionResult<IEnumerable<Activity>>> GetActivities()
        {
            
            return await _context.Activities.ToListAsync();
        }

        [HttpGet("{id}")] //api/activities
        public async Task<ActionResult<Activity>> GetActivities(Guid id)
        {

            return await _context.Activities.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
