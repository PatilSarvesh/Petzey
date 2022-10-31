using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Petzey.Model.DataAccess.VetService.DoctorRepo;
using Petzey.Model.Entities;

namespace Petzey.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VetController : ControllerBase
    {
        IDoctorRepository DRepo = new DoctorRepository();

        [HttpPost]
        [Route("AddDoctor")]
        public ActionResult AddDoctor(Doctor doctor)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid Input");
            DRepo.AddDoctor(doctor);

            return Created("api/Vet{doctor.DoctorId}", doctor);
        }

        [HttpDelete]
        [Route("RemoveDoctor/{id}")]
        public ActionResult<Doctor> DeleteDoctor(int id)
        {
            var res = DRepo.GetDoctor(id);
            if (res == null)
                return NotFound();
            DRepo.RemoveDoctor(res);
            return Ok();
        }

        [HttpPut]
        [Route("UpdateDoctor")]
        public ActionResult UpdateDoctor(Doctor doctor)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid Input");
            DRepo.UpdateDoctor(doctor);
            return Ok();
        }

        [HttpGet]
        [Route("Doctor/{id}")]
        public ActionResult<Doctor> GetDoctor(int id)
        {
            var res = DRepo.GetDoctor(id);
            if (res == null)
                return NotFound();
            return Ok(res);
        }

        [HttpGet]
        [Route("AllDoctors")]
        public ActionResult<List<Doctor>> GetAllDoctors()
        {
            var res = DRepo.GetAllDoctors();
            if (res == null)
                return NotFound();
            return Ok(res);
        }

    }
}
