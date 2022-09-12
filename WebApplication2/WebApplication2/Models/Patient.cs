namespace WebApplication2.Models
{
    public class Patient : Entity
    {
        public string Name { get; private set; }

        public string IdentityDocument { get; private set; }

        public DateTime BirthDate { get; private set; }

        public Guid HospitalId { get; private set; }

        public Hospital Hospital { get; private set; }

        private Patient() : base()
        {

        }

        private Patient(Guid id, string name, string identityDocument, DateTime birthDate,
            Guid hospitalId) : base(id)
        {
            Name = name;
            IdentityDocument = identityDocument;
            BirthDate = birthDate;
            HospitalId = hospitalId;
        }

        public Patient Build(Guid id, string name, string identityDocument,
            DateTime birthDate, Guid hospitalId)
        {
            return new Patient(id, name, identityDocument, birthDate, hospitalId);
        }
    }
}
