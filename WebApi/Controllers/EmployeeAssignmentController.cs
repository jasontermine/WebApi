using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeAssignmentController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EmployeeAssignmentController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeAssignment>>> GetEmployeeAssignments()
        {
            var employeeAssignments = await _context.EmployeeAssignments.ToListAsync();

            if (employeeAssignments == null)
            {
                return NotFound();
            }

            return Ok(employeeAssignments.Select(p => new
            {
                uuid = p.uuid,
                EmployeeUuid = p.EmployeeUuid,
                AssignmentUuid = p.AssignmentUuid,
                HoursWorked = p.HoursWorked
            }));
        }

        [HttpGet("{id}", Name = "GetEmployeeAssignmentById")]
        public async Task<ActionResult<EmployeeAssignment>> GetEmployeeAssignment(Guid id)
        {
            var employeeAssignment = await _context.EmployeeAssignments.FindAsync(id);

            if (employeeAssignment == null)
            {
                return NotFound();
            }

            return employeeAssignment;
        }

        [HttpPost]
        public async Task<ActionResult<EmployeeAssignment>> PostEmployeeAssignment(EmployeeAssignmentRequestDto employeeAssignmentDto)
        {
            var employeeAssignment = new EmployeeAssignment
            {
                uuid = Guid.NewGuid(),
                EmployeeUuid = employeeAssignmentDto.EmployeeUuid,
                AssignmentUuid = employeeAssignmentDto.AssignmentUuid,
                HoursWorked = employeeAssignmentDto.HoursWorked
            };

            _context.EmployeeAssignments.Add(employeeAssignment);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEmployeeAssignment), new { id = employeeAssignment.uuid }, employeeAssignment);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployeeAssignment(Guid id, EmployeeAssignment employeeAssignment)
        {
            if (id != employeeAssignment.uuid)
            {
                return BadRequest();
            }

            _context.Entry(employeeAssignment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeAssignmentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployeeAssignment(Guid id)
        {
            var employeeAssignment = await _context.EmployeeAssignments.FindAsync(id);
            if (employeeAssignment == null)
            {
                return NotFound();
            }

            _context.EmployeeAssignments.Remove(employeeAssignment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmployeeAssignmentExists(Guid id)
        {
            return _context.EmployeeAssignments.Any(e => e.uuid == id);
        }
    }
}
