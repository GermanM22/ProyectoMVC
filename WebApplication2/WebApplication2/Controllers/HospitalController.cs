using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.Services;


namespace WebApplication2.Controllers
{
    public class HospitalController : Controller
    {
        private readonly HospitalServices hospitalServices;

        public HospitalController(HospitalServices hospitalServices)
        {
            this.hospitalServices = hospitalServices;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var hospitals = await hospitalServices.GetAllHospital();
            return View(hospitals);
        }

        [HttpPost]
        public async Task<IActionResult> Create(string name, string address, string type)
        {
            var hospital = Hospital.Build(Guid.NewGuid(), name, address, type);
            await this.hospitalServices.Crear(hospital);

            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}
