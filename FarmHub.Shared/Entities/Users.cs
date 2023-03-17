
namespace FarmHub.Shared.Entities
{
    public class Users : EntityBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsSeller { get; set; }
    }
}
