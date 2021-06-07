using Zapo.Domain.Entities.Abstract;

namespace Zapo.Domain.Entities
{
    public class CommentReaction : Reaction
    {
        public int CommentId { get; set; }
        public Comment Comment { get; set; }
    }
}