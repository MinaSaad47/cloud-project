using Games.Mvc.Entities;
using Microsoft.EntityFrameworkCore;

namespace Games.Mvc.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var games = new Game[]
        {
new ()
{
    Id = 1,
    Name = "The Witcher 3: Wild Hunt",
    Description = "An epic open-world RPG set in a dark fantasy universe.",
    Url = "https://en.cdprojektred.com/games/the-witcher-3-wild-hunt/",
    PictureUrl = "https://cdn.cdprojektred.com/thewitcher.com/media/wallpapers/witcher3/full/witcher3_en_3840x2160_blood_and_wine_01_en_3840x2160.jpg"
},
new ()
{
    Id = 2,
    Name = "Red Dead Redemption 2",
    Description = "A sprawling Western epic set in a meticulously detailed open world.",
    Url = "https://www.rockstargames.com/reddeadredemption2/",
    PictureUrl = "https://rockstarintel.com/wp-content/uploads/2018/09/rdr2_main_promo.jpg"
},
new ()
{
    Id = 3,
    Name = "The Last of Us Part II",
    Description = "A gripping action-adventure game set in a post-apocalyptic world.",
    Url = "https://www.playstation.com/en-us/games/the-last-of-us-part-ii/",
    PictureUrl = "https://cdn.cloudflare.steamstatic.com/steam/apps/1085660/ss_5d720db0b8715f21e73828c80b1b087019d3ef91.jpg"
},
new ()
{
    Id = 4,
    Name = "God of War",
    Description = "An intense action-adventure game based on Norse mythology.",
    Url = "https://www.playstation.com/en-us/games/god-of-war/",
    PictureUrl = "https://images.g2a.com/newlayout/323x433/1x1x0/821a90e92334/591f16905bafe355be5414aa"
},
new ()
{
    Id = 5,
    Name = "Cyberpunk 2077",
    Description = "A futuristic open-world RPG set in the sprawling Night City.",
    Url = "https://www.cyberpunk.net/",
    PictureUrl = "https://images.ctfassets.net/rporu91m20dc/2y4pAuRvc8gs2I4muVQqG4/6b14f06b8a3ed52f5f3b63ef10e0b1bd/cyberpunk-2077-delays-banner.jpg?w=1920&h=1080&q=90&fm=webp"
},
new ()
{
    Id = 6,
    Name = "Assassin's Creed Valhalla",
    Description = "Embark on a Viking saga in this open-world action-adventure game.",
    Url = "https://www.ubisoft.com/en-us/game/assassins-creed/valhalla",
    PictureUrl = "https://cdn1.epicgames.com/ue/product/Screenshot/ac-valhalla-homepage-1920x1080-d0c60a5e5f62a1664814f3bc918c640b.png"
},
new ()
{
    Id = 7,
    Name = "Ghost of Tsushima",
    Description = "Journey through feudal Japan in this stunning action-adventure game.",
    Url = "https://www.playstation.com/en-us/games/ghost-of-tsushima/",
    PictureUrl = "https://images.pushsquare.com/screenshots/106108/large.jpg"
},
new ()
{

    Id = 8,
    Name = "Marvel's Spider-Man",
    Description = "Swing through the streets of New York as the iconic web-slinger.",
    Url = "https://www.playstation.com/en-us/games/marvels-spider-man/",
    PictureUrl = "https://images-na.ssl-images-amazon.com/images/I/81S5e8Yze8L._SX466_.jpg"
},
new ()
{
    Id = 9,
    Name = "Horizon Zero Dawn",
    Description = "Explore a lush open world inhabited by robotic creatures in this action RPG.",
    Url = "https://www.playstation.com/en-us/games/horizon-zero-dawn/",
    PictureUrl = "https://static.wikia.nocookie.net/horizonzerodawn/images/1/1c/Horizon_Zero_Dawn_Cover_Art.jpg"
},
new ()
{
    Id = 10,
    Name = "Death Stranding",
    Description = "Embark on a journey across a post-apocalyptic America in this unique game.",
    Url = "https://www.playstation.com/en-us/games/death-stranding/",
    PictureUrl = "https://images.pushsquare.com/8968ab3f87fc0/death-stranding-review-lede.original.jpg"
}
        };

        modelBuilder.Entity<Game>().HasData(games);
    }

    public DbSet<Game> Games => Set<Game>();
}