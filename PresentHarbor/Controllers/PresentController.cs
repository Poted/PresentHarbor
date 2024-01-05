using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PresentHarbor.Data;
using PresentHarbor.Models;

[Route("api/[controller]")]
[ApiController]
public class PresentController : ControllerBase
{
    private readonly DataContext _context;

    public PresentController(DataContext context)
    {
        _context = context;
    }


    [HttpGet]
    public async Task<ActionResult<IEnumerable<Present>>> GetPresent()
    {
        Console.WriteLine("Present: " + _context.Present);
        return await _context.Present.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Present>> GetPresent(int id)
    {
        var present = await _context.Present.FindAsync(id);

        if (present == null)
        {
            return NotFound();
        }

        return present;
    }

    [HttpPost]
    public async Task<ActionResult<Present>> PostPresent(Present present)
    {
        _context.Present.Add(present);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetPresent), new { id = present.ID }, present);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutPresent(int id, Present present)
    {
        if (id != present.ID)
        {
            return BadRequest();
        }

        _context.Entry(present).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!PresentExists(id))
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
    public async Task<IActionResult> DeletePresent(int id)
    {
        var present = await _context.Present.FindAsync(id);

        if (present == null)
        {
            return NotFound();
        }

        _context.Present.Remove(present);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool PresentExists(int id)
    {
        return _context.Present.Any(e => e.ID == id);
    }
}
