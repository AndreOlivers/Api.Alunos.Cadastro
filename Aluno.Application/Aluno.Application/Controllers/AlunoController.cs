using Aluno.Domain.Interface.Service;
using Aluno.Domain.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;

namespace Aluno.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoService _service;

        public AlunoController(IAlunoService service)
        {
            _service = service;
        }

        #region GET
        [HttpGet]
        public async Task<ActionResult> GetAllStudents()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await _service.GetAll());
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetIdStudents(int id)
        {
            if (id < 0)
            {
                return BadRequest();
            }
            try
            {
                return Ok(await _service.GetById(id));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet("{nome}")]
        public async Task<ActionResult> GetStudentsName(string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                return BadRequest();
            }
            try
            {
                return Ok(await _service.GetByName(nome));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
        #endregion

        #region POST
        [HttpPost]
        public async Task<ActionResult> PostStudents(AlunoEntity aluno)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await _service.PostStudents(aluno));
            }
            catch (ArithmeticException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
        #endregion

        #region PUT
        [HttpPut]
        public async Task<ActionResult> PutStudents(AlunoEntity aluno)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await _service.PutStudents(aluno));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
        #endregion

        #region PUT
        [HttpDelete  ("{id}")]
        public async Task<ActionResult> DeleteStudents(int id)
        {
            if (id < 0)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await _service.DeleteStudents(id));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
        #endregion
    }
}
