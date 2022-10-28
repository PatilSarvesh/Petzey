using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Petzey.Model.Data.DoctorAppointmentRepo;
using Petzey.Model.Entities;

namespace Petzey.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        IDoctorAppointmentRepository repo = new DoctorAppointmentRepository();

        [HttpPost]
        public void  DoctorAppointment(DoctorAppointment Appointment)
        {
            repo.AddAppointment(Appointment);
        }
    }
}
