using GymManagementSystemG02.Entities.Enums;

namespace GymManagementSystemG02.Entities
{
    public class Member : GymUser
    {
        public string? Photo { get; set; }

        public ICollection<Membership> Plans { get; set; }
    }
}
