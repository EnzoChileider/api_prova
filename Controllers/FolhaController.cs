using System.Collections.Generic;
using System.Linq;
using API_Folhas.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Folhas.Controllers
{
    [ApiController]
    [Route("api/folha")]
    public class FolhaController : ControllerBase
    {
        private readonly DataContext _context;

        //Injeção de dependência - balta.io
        public FolhaController(DataContext context) =>
            _context = context;

        private static List<Folha> folhas = new List<Folha>();

        // GET: /api/funcionario/listar
        [Route("listar")]
        [HttpGet]
        public IActionResult Listar() =>
            Ok(_context.Folhas.ToList());

        // POST: /api/funcionario/cadastrar
        [Route("cadastrar")]
        [HttpPost]
        public IActionResult Cadastrar([FromBody] Folha folha)
        {
            _context.Folhas.Add(folha);
            _context.SaveChanges();
            return Created("", folha);
        }

        // GET: /api/funcionario/buscar/123
        [Route("buscar/{cpf}")]
        [HttpGet]
        public IActionResult Buscar([FromRoute] string cpf)
        {
            //Expressão lambda
            Folha folha =
                _context.Folhas.FirstOrDefault
            (
                f => f.Cpf.Equals(cpf)
            );
            //IF ternário
            return folha != null ? Ok(folha) : NotFound();
        }
    }
}


// if (funcionario != null)
// {
//     return Ok(funcionario);
// }
// return NotFound();
// foreach (Funcionario f in funcionarios)
// {
//     if(f.Cpf.Equals(cpf))
//     {
//         return Ok(f);
//     }
// }
// foreach(Funcionario f in _context.Funcionarios.ToList()){

// }