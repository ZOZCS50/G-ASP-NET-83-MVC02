using System.ComponentModel.DataAnnotations.Schema;

namespace GymManagementSystemG02.Entities
{
    public class Membership : BaseEntity<int>
    {
        public int PlanId { get; set; }
        public Plan Plan { get; set; }

        public int MemberId { get; set; }
        public Member Member { get; set; }


        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        [NotMapped]
        public string Status => StartDate > DateTime.Now ? "Upcoming"
                              : EndDate > DateTime.Now ? "Active"
                              : "Expired";
    }
}
