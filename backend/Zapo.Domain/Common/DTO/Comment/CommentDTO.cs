using System;
using System.Collections.Generic;
using Zapo.Domain.Common.DTO.User;
using Zapo.Domain.Entities.Abstract;

namespace Zapo.Domain.Common.DTO.Comment
{
    public sealed class CommentDTO
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public UserDTO Author { get; set; }
        public string Body { get; set; }
        
        public ICollection<Reaction> Reactions { get; set; }
    }
}