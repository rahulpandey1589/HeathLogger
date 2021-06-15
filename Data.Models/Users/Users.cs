using Data.Models.Common;

namespace Data.Models.Users
{
    public class Users : AuditEntity<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string EmailAddress { get; set; }

    }
}
