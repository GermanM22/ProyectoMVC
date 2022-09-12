using WebApplication2.Models;
using WebApplication2.Data;

namespace WebApplication2.Services
{
    public class HospitalServices
    {
        private readonly IRepository repository;

        public HospitalServices(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task Crear(Hospital hospital)
        {
            if (hospital is null)
                throw new Exception("Hospital nulo");

            await this.repository.Save(hospital);
            await this.repository.Commit();
        }

        public async Task<List<Hospital>> GetAllHospital()
        {
            return await this.repository.GetAll<Hospital>();
        }
    }
}