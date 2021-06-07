using Zapo.Domain.Entities.Abstract;

namespace Zapo.Domain.Entities
{
    public class PostReaction : Reaction
    {
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}