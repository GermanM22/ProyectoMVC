namespace WebApplication2.Models
{
    public class Hospital : Entity
    {
        public string HospitalName { get; private set; }

        public string Address { get; private set; }

        public string Type { get; private set; }

        public List<Patient> Patients { get; private set; }


        private Hospital() : base()
        {

        }

        private Hospital(Guid id, string name, string address, string type) : base(id)
        {
            HospitalName = name;
            Address = address;
            Type = type;
        }

        public static Hospital Build(Guid id, string name, string address, string type)
        {
            return new Hospital(id, name, address, type);
        }
    }
}