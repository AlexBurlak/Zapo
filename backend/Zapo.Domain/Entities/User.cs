using Zapo.Domain.Entities.Abstract;

namespace Zapo.Domain.Entities
{
    public class User : BaseEntity
    {
        public int? AvatarId { get; set; }
        public Image Avatar { get; set; }
        
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
    }
}