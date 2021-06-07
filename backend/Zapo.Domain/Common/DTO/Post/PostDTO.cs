using System;
using System.Collections.Generic;
using Zapo.Domain.Common.DTO.Comment;
using Zapo.Domain.Common.DTO.Like;
using Zapo.Domain.Common.DTO.User;

namespace Zapo.Domain.Common.DTO.Post
{
    public sealed class PostDTO
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public UserDTO Author { get; set; }
        public string PreviewImage { get; set; }
        public string Body { get; set; }
        
        public ICollection<CommentDTO> Comments { get; set; }
        public ICollection<ReactionDTO> Reactions { get; set; }
    }
}