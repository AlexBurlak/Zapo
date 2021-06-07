using Microsoft.EntityFrameworkCore;
using Zapo.Domain.Entities;

namespace Zapo.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CommentReaction> CommentReactions { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostReaction> PostReactions { get; set; }
        public DbSet<User> Users { get; set; }
    }
}