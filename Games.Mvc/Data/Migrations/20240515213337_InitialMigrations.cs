using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Games.Mvc.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Url = table.Column<string>(type: "text", nullable: false),
                    PictureUrl = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "Name", "PictureUrl", "Url" },
                values: new object[,]
                {
                    { 1, "An epic open-world RPG set in a dark fantasy universe.", "The Witcher 3: Wild Hunt", "https://cdn.cdprojektred.com/thewitcher.com/media/wallpapers/witcher3/full/witcher3_en_3840x2160_blood_and_wine_01_en_3840x2160.jpg", "https://en.cdprojektred.com/games/the-witcher-3-wild-hunt/" },
                    { 2, "A sprawling Western epic set in a meticulously detailed open world.", "Red Dead Redemption 2", "https://rockstarintel.com/wp-content/uploads/2018/09/rdr2_main_promo.jpg", "https://www.rockstargames.com/reddeadredemption2/" },
                    { 3, "A gripping action-adventure game set in a post-apocalyptic world.", "The Last of Us Part II", "https://cdn.cloudflare.steamstatic.com/steam/apps/1085660/ss_5d720db0b8715f21e73828c80b1b087019d3ef91.jpg", "https://www.playstation.com/en-us/games/the-last-of-us-part-ii/" },
                    { 4, "An intense action-adventure game based on Norse mythology.", "God of War", "https://images.g2a.com/newlayout/323x433/1x1x0/821a90e92334/591f16905bafe355be5414aa", "https://www.playstation.com/en-us/games/god-of-war/" },
                    { 5, "A futuristic open-world RPG set in the sprawling Night City.", "Cyberpunk 2077", "https://images.ctfassets.net/rporu91m20dc/2y4pAuRvc8gs2I4muVQqG4/6b14f06b8a3ed52f5f3b63ef10e0b1bd/cyberpunk-2077-delays-banner.jpg?w=1920&h=1080&q=90&fm=webp", "https://www.cyberpunk.net/" },
                    { 6, "Embark on a Viking saga in this open-world action-adventure game.", "Assassin's Creed Valhalla", "https://cdn1.epicgames.com/ue/product/Screenshot/ac-valhalla-homepage-1920x1080-d0c60a5e5f62a1664814f3bc918c640b.png", "https://www.ubisoft.com/en-us/game/assassins-creed/valhalla" },
                    { 7, "Journey through feudal Japan in this stunning action-adventure game.", "Ghost of Tsushima", "https://images.pushsquare.com/screenshots/106108/large.jpg", "https://www.playstation.com/en-us/games/ghost-of-tsushima/" },
                    { 8, "Swing through the streets of New York as the iconic web-slinger.", "Marvel's Spider-Man", "https://images-na.ssl-images-amazon.com/images/I/81S5e8Yze8L._SX466_.jpg", "https://www.playstation.com/en-us/games/marvels-spider-man/" },
                    { 9, "Explore a lush open world inhabited by robotic creatures in this action RPG.", "Horizon Zero Dawn", "https://static.wikia.nocookie.net/horizonzerodawn/images/1/1c/Horizon_Zero_Dawn_Cover_Art.jpg", "https://www.playstation.com/en-us/games/horizon-zero-dawn/" },
                    { 10, "Embark on a journey across a post-apocalyptic America in this unique game.", "Death Stranding", "https://images.pushsquare.com/8968ab3f87fc0/death-stranding-review-lede.original.jpg", "https://www.playstation.com/en-us/games/death-stranding/" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
