using System.Collections.Generic;
using Zapo.Domain.Entities.Abstract;

namespace Zapo.Domain.Entities
{
    public class Post : BaseEntity
    {
        public Post()
        {
            Comments = new List<Comment>();
            Reactions = new List<PostReaction>();
        }

        public int AuthorId { get; set; }
        public User Author { get; set; }
        
        public int? PreviewId { get; set; }
        public Image Preview { get; set; }
        
        public  string Body { get; set; }
        
        public ICollection<Comment> Comments { get; private  set; }
        public ICollection<PostReaction> Reactions { get; private set; }
    }
}