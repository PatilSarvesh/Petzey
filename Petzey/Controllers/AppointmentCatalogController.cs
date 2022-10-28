using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Petzey.Model.Data;
using Petzey.Model.Entities;

namespace Petzey.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentCatalogController : ControllerBase
    {
        IAppointmentCatalogRepository repo = new AppointmentCatalogEFRepository();

        [HttpGet]
       public void  appointment(Appointment appointment)
        {
            repo.BookAppointment(appointment);

        }
    }
}
