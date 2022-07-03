using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infraestructura.Datos;
using Core.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Core.Interfaces;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LugaresController : ControllerBase
    {
        public readonly ILugarRepositorio _repo;

        public LugaresController(Core.Interfaces.ILugarRepositorio repo)
        {
            _repo = repo;
        }

        [HttpGet] 
        public async Task<ActionResult<List<Lugar>>> GetLugares() {

            var lugares = await _repo.GetLugaresAsync();

            return Ok(lugares);

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Lugar>> GetLugar(int id)
        {

            var lugar = await _repo.GetLugarAsync(id);

            return Ok(lugar);

        }
    }
}