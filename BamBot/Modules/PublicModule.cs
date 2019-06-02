using System.IO;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using BamBot.Services;
using System;
using System.Reflection;

namespace Bambot.Services
{
    public class PublicModule : ModuleBase<SocketCommandContext>
    {
        public PictureService _pictureService { get; set; }
        public Random _rand = new Random();

        [Command("ping")]
        [Alias("pong", "hello")]
        public Task PingAsync()
            => ReplyAsync("pong!");

        [Command("cat")]
        [Alias("meow")]
        public async Task CatAsync()
        {
            // Get a stream containing an image of a cat
            var stream = await _pictureService.GetCatPictureAsync();
            var embed = new EmbedBuilder
            {
                // Embed property can be set within object initializer
                ImageUrl = stream,
                Color = Color.Green,
                Title = "<:Hypers:527269530079330315>"
            };
            await ReplyAsync(embed: embed.Build());
        }

        [Command("dog")]
        [Alias("woof", "bark")]
        public async Task DogAsync()
        {
            var dogPic = await _pictureService.GetDogPictureAsync();
            var embed = new EmbedBuilder
            {
                ImageUrl = dogPic,
                Color = Color.Green,
                Title = "<:Hypers:527269530079330315>"

            };
            await ReplyAsync(embed: embed.Build());
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

        [Command("mokou")]
        public async Task Mokou()
        {
            Random rand = new Random();
            await Context.Channel.SendFileAsync(String.Format("../../Images/Mokou/mokou{0}.jpg", new Random().Next(1, 196)));
        }

        [Command("reminder")]
        public async Task ReminderAsync()
        {
            var reminderImage = _pictureService.GetReminder();
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