using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Petzey.Model.DataAccess.AppointmentService.DoctorAppointmentRepo;
using Petzey.Model.DataAccess.AppointmentService.PatientAppointmentRepo;
using Petzey.Model.DataAccess.AppointmentService.ReceptionistAppointmentRepo;
using Petzey.Model.Entities;

namespace Petzey.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        IDoctorAppointmentRepository DRepo = new DoctorAppointmentRepository();
        IPatientAppointmentRepository  PRepo = new PatientAppointmentRepository();
        IReceptionistAppointmentRepository RRepo = new ReceptionistAppointmentRepository(); 

        [HttpPost]
        [Route("DoctorAppointment")]
        public ActionResult DoctorAppointment(DoctorAppointment Appointment)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid Input");
            DRepo.AddAppointment(Appointment);

            return Created("api/Appointment{Appointment.DoctorAppointmentId}", Appointment);
        }

        [HttpPost]
        [Route("PatientAppointment")]
        public ActionResult PatientAppointment(PatientAppointment Appointment)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid Input");
            PRepo.AddAppointment(Appointment);

            return Created("api/Appointment{Appointment.PatientAppointmentId}", Appointment);
        }

        [HttpPost]
        [Route("ReceptionistAppointment")]
        public ActionResult ReceptionistAppointment(ReceptionistAppointment Appointment)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid Input");
            RRepo.AddAppointment(Appointment);

            return Created("api/Appointment{Appointment.ReceptionistAppointmentId}", Appointment);
        }

        [HttpGet]
        [Route("DoctorAppointment/All")]
        public ActionResult<List<DoctorAppointment>> GetDoctorAppointments()
        {
            var res = DRepo.GetAllAppointments();
            if (res.Count == 0)
                return NotFound();
            return Ok(res);
        }

        [HttpGet]
        [Route("PatientAppointment/All")]
        public ActionResult<List<PatientAppointment>> GetPatientAppointments()
        {
            var res = PRepo.GetAllAppointments();
            if (res.Count == 0)
                return NotFound();
            return Ok(res);
        }

        [HttpGet]
        [Route("ReceptionistAppointment/All")]
        public ActionResult<List<ReceptionistAppointment>> GetReceptionistAppointments()
        {
            var res = RRepo.GetAllAppointments();
            if (res.Count == 0)
                return NotFound();
            return Ok(res);
        }

        [HttpGet]
        [Route("DoctorAppointment/UserId/{id}")]
        public ActionResult<List<DoctorAppointment>> GetDoctorAppointmentsByUserId(int id)
        {
            var res = DRepo.GetAppointmentsByUserId(id);
            if (res.Count == 0)
                return NotFound();
            return Ok(res);
        }

        [HttpGet]
        [Route("PatientAppointment/UserId/{id}")]
        public ActionResult<List<PatientAppointment>> GetPatientAppointmentsByUserId(int id)
        {
            var res = PRepo.GetAppointmentsByUserId(id);
            if (res.Count == 0)
                return NotFound();
            return Ok(res);
        }

        [HttpGet]
        [Route("ReceptionistAppointment/UserId/{id}")]
        public ActionResult<List<ReceptionistAppointment>> GetReceptionistAppointmentsByUserId(int id)
        {
            var res = RRepo.GetAppointmentsByUserId(id);
            if (res.Count == 0)
                return NotFound();
            return Ok(res);
        }

        [HttpGet]
        [Route("DoctorAppointment/AppointmentId/{id}")]
        public ActionResult<DoctorAppointment> GetDoctorAppointment(int id)
        {
            var res = DRepo.GetAppointment(id);
            if (res == null)
                return NotFound();
            return Ok(res);
        }

        [HttpGet]
        [Route("PatientAppointment/AppointmentId/{id}")]
        public ActionResult<PatientAppointment> GetPatientAppointment(int id)
        {
            var res = PRepo.GetAppointment(id);
            if (res == null)
                return NotFound();
            return Ok(res);
        }

        [HttpGet]
        [Route("ReceptionistAppointment/AppointmentId/{id}")]
        public ActionResult<ReceptionistAppointment> GetReceptionistAppointment(int id)
        {
            var res = RRepo.GetAppointment(id);
            if (res == null)
                return NotFound();
            return Ok(res);
        }

        [HttpDelete]
        [Route("DoctorAppointment/AppointmentId/{id}")]
        public ActionResult<DoctorAppointment> DeleteDoctorAppointment(int id)
        {
            var res = DRepo.GetAppointment(id);
            if (res == null)
                return NotFound();
            DRepo.DeleteAppointment(res);
            return Ok();
        }

        [HttpDelete]
        [Route("PatientAppointment/AppointmentId/{id}")]
        public ActionResult<PatientAppointment> DeletePatientAppointment(int id)
        {
            var res = PRepo.GetAppointment(id);
            if (res == null)
                return NotFound();
            PRepo.DeleteAppointment(res);
            return Ok();
        }

        [HttpDelete]
        [Route("ReceptionistAppointment/AppointmentId/{id}")]
        public ActionResult<ReceptionistAppointment> DeleteReceptionistAppointment(int id)
        {
            var res = RRepo.GetAppointment(id);
            if (res == null)
                return NotFound();
            RRepo.DeleteAppointment(res);
            return Ok();
        }

        [HttpPut]
        [Route("DoctorAppointment")]
        public ActionResult UpdateDoctorAppointment(DoctorAppointment Appointment)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid Input");
            DRepo.UpdateAppointment(Appointment);
            return Ok();
        }

        [HttpPut]
        [Route("PatientAppointment")]
        public ActionResult UpdatePatientAppointment(PatientAppointment Appointment)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid Input");
            PRepo.UpdateAppointment(Appointment);
            return Ok();
        }

        [HttpPut]
        [Route("ReceptionistAppointment")]
        public ActionResult UpdateReceptionistAppointment(ReceptionistAppointment Appointment)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid Input");
            RRepo.UpdateAppointment(Appointment);
            return Ok();
        }
    }
}
