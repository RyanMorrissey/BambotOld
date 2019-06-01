using System.IO;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using BamBot.Services;

namespace Bambot.Services
{
    public class PublicModule : ModuleBase<SocketCommandContext>
    {
        public PictureService PictureService { get; set; }

        [Command("ping")]
        [Alias("pong", "hello")]
        public Task PingAsync()
            => ReplyAsync("pong!");

        [Command("cat")]
        [Alias("meow")]
        public async Task CatAsync()
        {
            // Get a stream containing an image of a cat
            var stream = await PictureService.GetCatPictureAsync();
            var embed = new EmbedBuilder
            {
                // Embed property can be set within object initializer
                ImageUrl = stream,
                Color = Color.Green,
                Title = "<:Hypers:527269530079330315>"
            };
            await ReplyAsync(embed: embed.Build());
        }

        [Command("mei34")]
        public async Task Mei34()
        { 
            var embed = new EmbedBuilder
            {
                // Embed property can be set within object initializer
                ImageUrl = "https://i.imgur.com/YBcH09N.jpg",
                Color = Color.Green,
                Title = "You are better than this."
            };
            await ReplyAsync(embed: embed.Build());
            await ReplyAsync("https://www.youtube.com/watch?v=ZtQeTs8NfIE");
        }

        [Command("test")]
        public async Task Test()
        {
            var test = new EmbedBuilder();
            test.WithAuthor("Testy Testerson");
            test.WithColor(53380);
            test.WithImageUrl("https://upload.wikimedia.org/wikipedia/en/thumb/5/5c/Kirby.png/220px-Kirby.png");
            var embed = new EmbedBuilder
            {
                // Embed property can be set within object initializer
                Title = "<:Hypers:527269530079330315>",
            Description = "I am a description set by initializer."
            };
            await ReplyAsync(embed: embed.Build());
        }

        [Command("dog")]
        [Alias("woof", "bark")]
        public async Task DogAsync()
        {
            // Get a stream containing an image of a cat
            var stream = await PictureService.GetDogPictureAsync();
            var embed = new EmbedBuilder
            {
                // Embed property can be set within object initializer
                ImageUrl = stream,
                Color = Color.Green,
                Title = "<:Hypers:527269530079330315>"

            };
            await ReplyAsync(embed: embed.Build());
        }

        [Command("reminder")]
        public async Task ReminderAsync()
        {
            var reminderImage = PictureService.GetReminder();
            await ReplyAsync(reminderImage);
        }

        [Command("lewd")]
        public async Task LewdAsync()
        {
            var reminderImage = PictureService.GetLewd();
            await ReplyAsync(reminderImage);
        }

        // Get info on a user, or the user who invoked the command if one is not specified
        //[Command("userinfo")]
        //public async Task UserInfoAsync(IUser user = null)
        //{
        //    user = user ?? Context.User;

        //    await ReplyAsync(user.ToString());
        //}

        // [Remainder] takes the rest of the command's arguments as one argument, rather than splitting every space
        [Command("echo")]
        public Task EchoAsync([Remainder] string text)
            // Insert a ZWSP before the text to prevent triggering other bots!
            => ReplyAsync('\u200B' + text);
    }
}