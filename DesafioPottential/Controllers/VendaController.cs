using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioPottential.Models;
using Microsoft.EntityFrameworkCore;
using DesafioPottential.Context;
using Microsoft.AspNetCore.Mvc;

namespace DesafioPottential.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendaController : ControllerBase
    {
        private readonly VendaContext _context;

        public VendaController(VendaContext context)
        {
            _context = context;
        }

                
        [HttpPost]
        public IActionResult RegistrarVenda(Venda venda)
        {
            _context.Add(venda);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ObterPorId), new { id = venda.Id }, venda);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var venda = _context.Vendas.Find(id);

            if (venda == null)
                return NotFound();

            return Ok(venda);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Venda venda)
        {
            var vendaBanco = _context.Vendas.Find(id);

            if (vendaBanco == null)
                return NotFound();

            if (venda.Data == DateTime.MinValue)
                return BadRequest(new { Erro = "A data da venda não pode ser vazia" });

            vendaBanco.NomeVendedor = venda.NomeVendedor;
            vendaBanco.Itens = venda.Itens;
            vendaBanco.Status = venda.Status;

            _context.Vendas.Update(vendaBanco);
            _context.SaveChanges();

            return Ok(vendaBanco);
        }
    }
}
