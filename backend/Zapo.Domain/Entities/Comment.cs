using System.Collections.Generic;
using Zapo.Domain.Entities.Abstract;

namespace Zapo.Domain.Entities
{
    public class Comment : BaseEntity
    {
        public Comment()
        {
            Reactions = new List<CommentReaction>();
        }
        
        public int AuthorId { get; set; }
        public User Author { get; set; }
        
        public int PostId { get; set; }
        public Post Post { get; set; }
        
        public string Body { get; set; }
        
        public ICollection<CommentReaction> Reactions { get; private  set; }
    }
}