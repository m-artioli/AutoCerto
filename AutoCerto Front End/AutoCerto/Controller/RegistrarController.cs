using AutoCerto.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoCerto.Controller;
[ApiController]
[Route("api/[controller]")]
public class RegistrarController : ControllerBase
{
    private readonly ApplicationDbContext _register;
    public RegistrarController(ApplicationDbContext register)
    {
        _register = register;
    }
    [HttpPost]
    public async Task<IActionResult> Register([FromBody] Dtos.RegistrarDto registrarDto)
    {
        if (await _register.Usuarios.AnyAsync(u => u.Usuario == registrarDto.Usuario))
        {
            return BadRequest("Error - Usuario do cadastro já existe.");
        }
        var user = new Model.UsuarioModel
        {
            Usuario = registrarDto.Usuario,
            Nome = registrarDto.Nome,
            SenhaHash = BCrypt.Net.BCrypt.HashPassword(registrarDto.Senha)
        };
        _register.Usuarios.Add(user);
        await _register.SaveChangesAsync();
        return Ok("Ok - Cadastro registrado com sucesso.");
    }
}