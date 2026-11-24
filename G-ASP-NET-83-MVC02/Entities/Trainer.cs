using GymManagementSystemG02.Entities.Enums;

namespace GymManagementSystemG02.Entities
{
    public class Trainer : GymUser
    {
        // CreatedAt --> HireDate
        public Speciality Speciality { get; set; }

        public ICollection<Session> Sessions { get; set; }
    }
}
