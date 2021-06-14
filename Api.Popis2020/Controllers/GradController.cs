using Application.Repository; 
using Microsoft.AspNetCore.Mvc;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Popis2020.Controllers
{
   
    [Route("Grad")]
    [ApiController]
    public class GradController : ControllerBase
    {
        private readonly IGenericRepository<Grad> _repository = null;

        public GradController(IGenericRepository<Grad> repository)
        {
            _repository = repository;
        }

        [HttpGet("all")]
        public ActionResult Index()
        {
            var model = _repository.GetAll();
            return Ok(model);
        }

        [HttpPost("add")]
        public ActionResult DodadiGrad(Grad grad)
        {
            if (ModelState.IsValid)
            {
                _repository.Insert(grad);
                _repository.Save();

                return RedirectToAction("Index", "Grad");
            }
            return Ok("Zapisano");
        }

        [HttpPut("EditGradbyId/{GradId}")]
        public ActionResult EditGradbyId(int GradId)
        {
            Grad grad = _repository.GetById(GradId);
            return Ok(grad);
        }

        [HttpPut("edit")]
        public ActionResult EditGrad(Grad grad)
        {
            if (ModelState.IsValid)
            {
                _repository.Update(grad);
                _repository.Save();

                return RedirectToAction("Index", "Grad");
            }

            else
                return Ok(grad);
        }
    }
}
