using Microsoft.EntityFrameworkCore;
using Zapo.Domain.Entities;

namespace Zapo.Application.Common.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Configure(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostReaction>()
                .HasAlternateKey(pr => new {pr.PostId, pr.UserId});
            modelBuilder.Entity<PostReaction>()
                .HasOne(pr => pr.Post)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<CommentReaction>()
                .HasAlternateKey(cr => new {cr.CommentId, cr.UserId});
            modelBuilder.Entity<CommentReaction>()
                .HasOne(cr => cr.Comment)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Post>()
                .HasMany(p => p.Comments)
                .WithOne(c => c.Post)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Post>()
                .HasOne(p => p.Preview)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Post>()
                .HasMany(p => p.Reactions)
                .WithOne()
                .HasForeignKey(r => r.PostId);
            modelBuilder.Entity<Comment>()
                .HasMany(p => p.Reactions)
                .WithOne(r => r.Comment)
                .HasForeignKey(r => r.CommentId);
        }
    }
}