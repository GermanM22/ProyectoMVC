using WebApplication2.Models;
using WebApplication2.Data;

namespace WebApplication2.Services
{
    public class PatientServices
    {
        private readonly IRepository repository;

        public PatientServices(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task Crear(Patient patient)
        {
            await this.repository.Save(patient);
            await this.repository.Commit();
        }

    }
}