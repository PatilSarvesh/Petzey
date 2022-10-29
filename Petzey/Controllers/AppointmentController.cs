using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Petzey.Model.Data.AppointmentService.DoctorAppointmentRepo;
using Petzey.Model.Entities;

namespace Petzey.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        IDoctorAppointmentRepository repo = new DoctorAppointmentRepository();

        [HttpPost]
        [Route("DoctorAppointment")]
        public ActionResult DoctorAppointment(DoctorAppointment Appointment)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid Input");
            repo.AddAppointment(Appointment);

            return Created("api/Appointment{Appointment.DoctorAppointmentId}", Appointment);
        }
        [HttpGet]
        [Route("DoctorAppointment/All")]
        public ActionResult<List<DoctorAppointment>> GetDoctorAppointments()
        {
            var res = repo.GetAllAppointments();
            if (res.Count == 0)
                return NotFound();
            return Ok(res);
        }
        [HttpGet]
        [Route("DoctorAppointment/UserId/{id}")]
        public ActionResult<List<DoctorAppointment>> GetDoctorAppointmentsByUserId(int id)
        {
            var res = repo.GetAppointmentsByUserId(id);
            if (res.Count == 0)
                return NotFound();
            return Ok(res);
        }
        [HttpGet]
        [Route("DoctorAppointment/{id}")]
        public ActionResult<DoctorAppointment> GetDoctorAppointment(int id)
        {
            var res = repo.GetAppointment(id);
            if (res == null)
                return NotFound();
            return Ok(res);
        }
    }
}
