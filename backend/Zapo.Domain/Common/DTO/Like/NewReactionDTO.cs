namespace Zapo.Domain.Common.DTO.Like
{
    public sealed class NewReactionDTO
    {
        public int EntityId { get; set; }
        public int UserId { get; set; }
        public bool IsLike { get; set; }
    }
}