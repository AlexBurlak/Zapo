using Zapo.Domain.Common.DTO.User;

namespace Zapo.Domain.Common.DTO.Like
{
    public sealed class ReactionDTO
    {
        public bool IsLike { get; set; }
        public UserDTO User { get; set; }
    }
}