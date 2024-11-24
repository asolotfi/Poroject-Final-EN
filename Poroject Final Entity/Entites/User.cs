using Poroject_Final_Entity.Enums;

namespace Poroject_Final_Entity.Entites
{
    public class User
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        protected string Password { get; set; }
        public bool IsActive { get; set; }
        public RoleEnum Role { get; set; }
    }
}
