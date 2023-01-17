using Blue.Data;
using Blue.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blue.Controllers
{
    // Classe AgendaController tem a função de ser um controlador de API
    [ApiController]
    public class AgendaController : ControllerBase
    {
        // Método HTTP GET para recuperar todos os registros da agenda - endpoint padrão é "v1/agendas"
        [HttpGet("v1/agendas")] 
        public async Task<IActionResult> GetAsync( 
            [FromServices] BlueDbContext context)
        {
            try
            {
                // Usa o context do banco de dados para recuperar todos os registros
                var agendas = await context.Agendas.ToListAsync();
                return Ok(agendas);
            } catch (Exception ex)
            {
                return StatusCode(500, "05x04 - Falha interna no servidor");
            }                
        }
        // Método HTTP GET para recuperar um registro específico pelo ID - endpoint é "v1/agendas/{id:int}"
        [HttpGet("v1/agendas/{id:int}")] 
        public async Task<IActionResult> GetByIdAsync(
            [FromRoute] int id,
            [FromServices] BlueDbContext context)
        {
            var agenda = await context.Agendas.FirstOrDefaultAsync(x => x.Id == id);

            if (agenda == null)
                return NotFound();

            return Ok(agenda);
        }
        // Método HTTP POST para criar uma novo registro - endpoint é "v1/agendas/"
        [HttpPost("v1/agendas/")]
        public async Task<IActionResult> PostAsync(
            [FromBody] Agenda model,
            [FromServices] BlueDbContext context)
        {
            try
            {
                await context.Agendas.AddAsync(model); 
                await context.SaveChangesAsync();

                return Created($"v1/agendas/{model.Id}", model); 
            } catch (Exception ex)
            {
                return StatusCode(500, "05x04 - Falha interna no servidor");
            }
        }
        // Método HTTP PUT para atualizar um registro específico pelo ID - endpoint é "v1/agendas/{id:int}"
        [HttpPut("v1/agendas/{id:int}")]
        public async Task<IActionResult> PutAsync(
            [FromRoute] int id,
            [FromBody] Agenda model,
            [FromServices] BlueDbContext context)
        {
            try
            {
                var agenda = await context.Agendas.FirstOrDefaultAsync(x => x.Id == id);

                if (agenda == null)
                    return NotFound();

                agenda.Nome = model.Nome;
                agenda.Email = model.Email;
                agenda.Telefone = model.Telefone;

                context.Agendas.Update(agenda); 
                await context.SaveChangesAsync();

                return Ok(model);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "05x04 - Falha interna no servidor");
            }
        }
        // Método HTTP DELETE para deletar um registro específico pelo ID - endpoint é "v1/agendas/{id:int}"
        [HttpDelete("v1/agendas/{id:int}")]
        public async Task<IActionResult> DeleteAsync(
           [FromRoute] int id,
           [FromServices] BlueDbContext context)
        {
            try
            {
                var agenda = await context.Agendas.FirstOrDefaultAsync(x => x.Id == id);

                if (agenda == null)
                    return NotFound();

                context.Agendas.Remove(agenda); 
                await context.SaveChangesAsync();

                return Ok(agenda);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "05x04 - Falha interna no servidor");
            }
        }
    }
}
