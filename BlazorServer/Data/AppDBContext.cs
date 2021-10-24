using BlazorServer.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BlazorServer.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            List<Post> postsToSeed = new List<Post>();

            for (int i = 1; i < 11; i++)
            {
                postsToSeed.Add(new Post { PostId = i, Title = $"Post {i}", Content = loremIpsumOneParagraph });
            }

            modelBuilder.Entity<Post>().HasData(postsToSeed);
        }

        const string loremIpsumOneParagraph = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pretium libero eget risus gravida eleifend. Morbi sit amet lacus ligula. Donec pharetra, nisi vitae consequat consequat, est massa tincidunt odio, non dapibus risus massa sit amet enim. Sed scelerisque eget nisl in mattis. Morbi posuere, massa vel pretium ornare, est elit posuere massa, a consectetur leo lacus ut erat. Duis eu imperdiet ipsum. Nulla facilisi. Maecenas nunc dolor, egestas nec nunc eu, tempus placerat purus. Phasellus eget purus augue. Praesent vel erat accumsan, pretium orci at, pharetra augue. Vivamus sagittis consequat lectus eu maximus. Vestibulum vitae arcu enim. Vestibulum finibus at quam in faucibus. Morbi maximus cursus scelerisque.";
    }
}
