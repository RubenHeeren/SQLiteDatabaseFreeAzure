using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorServer.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Content", "Title" },
                values: new object[] { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pretium libero eget risus gravida eleifend. Morbi sit amet lacus ligula. Donec pharetra, nisi vitae consequat consequat, est massa tincidunt odio, non dapibus risus massa sit amet enim. Sed scelerisque eget nisl in mattis. Morbi posuere, massa vel pretium ornare, est elit posuere massa, a consectetur leo lacus ut erat. Duis eu imperdiet ipsum. Nulla facilisi. Maecenas nunc dolor, egestas nec nunc eu, tempus placerat purus. Phasellus eget purus augue. Praesent vel erat accumsan, pretium orci at, pharetra augue. Vivamus sagittis consequat lectus eu maximus. Vestibulum vitae arcu enim. Vestibulum finibus at quam in faucibus. Morbi maximus cursus scelerisque.", "Post 1" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Content", "Title" },
                values: new object[] { 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pretium libero eget risus gravida eleifend. Morbi sit amet lacus ligula. Donec pharetra, nisi vitae consequat consequat, est massa tincidunt odio, non dapibus risus massa sit amet enim. Sed scelerisque eget nisl in mattis. Morbi posuere, massa vel pretium ornare, est elit posuere massa, a consectetur leo lacus ut erat. Duis eu imperdiet ipsum. Nulla facilisi. Maecenas nunc dolor, egestas nec nunc eu, tempus placerat purus. Phasellus eget purus augue. Praesent vel erat accumsan, pretium orci at, pharetra augue. Vivamus sagittis consequat lectus eu maximus. Vestibulum vitae arcu enim. Vestibulum finibus at quam in faucibus. Morbi maximus cursus scelerisque.", "Post 2" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Content", "Title" },
                values: new object[] { 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pretium libero eget risus gravida eleifend. Morbi sit amet lacus ligula. Donec pharetra, nisi vitae consequat consequat, est massa tincidunt odio, non dapibus risus massa sit amet enim. Sed scelerisque eget nisl in mattis. Morbi posuere, massa vel pretium ornare, est elit posuere massa, a consectetur leo lacus ut erat. Duis eu imperdiet ipsum. Nulla facilisi. Maecenas nunc dolor, egestas nec nunc eu, tempus placerat purus. Phasellus eget purus augue. Praesent vel erat accumsan, pretium orci at, pharetra augue. Vivamus sagittis consequat lectus eu maximus. Vestibulum vitae arcu enim. Vestibulum finibus at quam in faucibus. Morbi maximus cursus scelerisque.", "Post 3" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Content", "Title" },
                values: new object[] { 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pretium libero eget risus gravida eleifend. Morbi sit amet lacus ligula. Donec pharetra, nisi vitae consequat consequat, est massa tincidunt odio, non dapibus risus massa sit amet enim. Sed scelerisque eget nisl in mattis. Morbi posuere, massa vel pretium ornare, est elit posuere massa, a consectetur leo lacus ut erat. Duis eu imperdiet ipsum. Nulla facilisi. Maecenas nunc dolor, egestas nec nunc eu, tempus placerat purus. Phasellus eget purus augue. Praesent vel erat accumsan, pretium orci at, pharetra augue. Vivamus sagittis consequat lectus eu maximus. Vestibulum vitae arcu enim. Vestibulum finibus at quam in faucibus. Morbi maximus cursus scelerisque.", "Post 4" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Content", "Title" },
                values: new object[] { 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pretium libero eget risus gravida eleifend. Morbi sit amet lacus ligula. Donec pharetra, nisi vitae consequat consequat, est massa tincidunt odio, non dapibus risus massa sit amet enim. Sed scelerisque eget nisl in mattis. Morbi posuere, massa vel pretium ornare, est elit posuere massa, a consectetur leo lacus ut erat. Duis eu imperdiet ipsum. Nulla facilisi. Maecenas nunc dolor, egestas nec nunc eu, tempus placerat purus. Phasellus eget purus augue. Praesent vel erat accumsan, pretium orci at, pharetra augue. Vivamus sagittis consequat lectus eu maximus. Vestibulum vitae arcu enim. Vestibulum finibus at quam in faucibus. Morbi maximus cursus scelerisque.", "Post 5" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Content", "Title" },
                values: new object[] { 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pretium libero eget risus gravida eleifend. Morbi sit amet lacus ligula. Donec pharetra, nisi vitae consequat consequat, est massa tincidunt odio, non dapibus risus massa sit amet enim. Sed scelerisque eget nisl in mattis. Morbi posuere, massa vel pretium ornare, est elit posuere massa, a consectetur leo lacus ut erat. Duis eu imperdiet ipsum. Nulla facilisi. Maecenas nunc dolor, egestas nec nunc eu, tempus placerat purus. Phasellus eget purus augue. Praesent vel erat accumsan, pretium orci at, pharetra augue. Vivamus sagittis consequat lectus eu maximus. Vestibulum vitae arcu enim. Vestibulum finibus at quam in faucibus. Morbi maximus cursus scelerisque.", "Post 6" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Content", "Title" },
                values: new object[] { 7, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pretium libero eget risus gravida eleifend. Morbi sit amet lacus ligula. Donec pharetra, nisi vitae consequat consequat, est massa tincidunt odio, non dapibus risus massa sit amet enim. Sed scelerisque eget nisl in mattis. Morbi posuere, massa vel pretium ornare, est elit posuere massa, a consectetur leo lacus ut erat. Duis eu imperdiet ipsum. Nulla facilisi. Maecenas nunc dolor, egestas nec nunc eu, tempus placerat purus. Phasellus eget purus augue. Praesent vel erat accumsan, pretium orci at, pharetra augue. Vivamus sagittis consequat lectus eu maximus. Vestibulum vitae arcu enim. Vestibulum finibus at quam in faucibus. Morbi maximus cursus scelerisque.", "Post 7" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Content", "Title" },
                values: new object[] { 8, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pretium libero eget risus gravida eleifend. Morbi sit amet lacus ligula. Donec pharetra, nisi vitae consequat consequat, est massa tincidunt odio, non dapibus risus massa sit amet enim. Sed scelerisque eget nisl in mattis. Morbi posuere, massa vel pretium ornare, est elit posuere massa, a consectetur leo lacus ut erat. Duis eu imperdiet ipsum. Nulla facilisi. Maecenas nunc dolor, egestas nec nunc eu, tempus placerat purus. Phasellus eget purus augue. Praesent vel erat accumsan, pretium orci at, pharetra augue. Vivamus sagittis consequat lectus eu maximus. Vestibulum vitae arcu enim. Vestibulum finibus at quam in faucibus. Morbi maximus cursus scelerisque.", "Post 8" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Content", "Title" },
                values: new object[] { 9, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pretium libero eget risus gravida eleifend. Morbi sit amet lacus ligula. Donec pharetra, nisi vitae consequat consequat, est massa tincidunt odio, non dapibus risus massa sit amet enim. Sed scelerisque eget nisl in mattis. Morbi posuere, massa vel pretium ornare, est elit posuere massa, a consectetur leo lacus ut erat. Duis eu imperdiet ipsum. Nulla facilisi. Maecenas nunc dolor, egestas nec nunc eu, tempus placerat purus. Phasellus eget purus augue. Praesent vel erat accumsan, pretium orci at, pharetra augue. Vivamus sagittis consequat lectus eu maximus. Vestibulum vitae arcu enim. Vestibulum finibus at quam in faucibus. Morbi maximus cursus scelerisque.", "Post 9" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Content", "Title" },
                values: new object[] { 10, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pretium libero eget risus gravida eleifend. Morbi sit amet lacus ligula. Donec pharetra, nisi vitae consequat consequat, est massa tincidunt odio, non dapibus risus massa sit amet enim. Sed scelerisque eget nisl in mattis. Morbi posuere, massa vel pretium ornare, est elit posuere massa, a consectetur leo lacus ut erat. Duis eu imperdiet ipsum. Nulla facilisi. Maecenas nunc dolor, egestas nec nunc eu, tempus placerat purus. Phasellus eget purus augue. Praesent vel erat accumsan, pretium orci at, pharetra augue. Vivamus sagittis consequat lectus eu maximus. Vestibulum vitae arcu enim. Vestibulum finibus at quam in faucibus. Morbi maximus cursus scelerisque.", "Post 10" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
