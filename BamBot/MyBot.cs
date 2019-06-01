// Ryan Morrissey
// 7/21/2017
// Shitty fucking discord bot


using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BamBot
{
    class MyBot
    {
        //DiscordClient discord;
        CommandService commands;
        string[] mei34; // ( ͡° ͜ʖ ͡°)
        string[] reminder;
        string[] lewd;
        Random rand;

        public MyBot()
        {
            rand = new Random();

            mei34 = new string[] // All the mei porn
            {
                "http://i.imgur.com/ehNr32F.png",
                "http://i.imgur.com/iEtGQVc.jpg",
                "http://i.imgur.com/CqLlcKa.jpg",
                "http://i.imgur.com/nwJRYmj.jpg",
                "http://i.imgur.com/stdSX07.jpg",
                "http://i.imgur.com/VHXGIQl.png",
                "http://i.imgur.com/fG1MhQk.png",
                "http://i.imgur.com/MoOQzPv.jpg",
                "http://i.imgur.com/S9IQy9c.jpg",
                "http://i.imgur.com/6hW0ljt.png",
                "http://i.imgur.com/xSfM6mh.jpg",
                "http://i.imgur.com/C4X68Km.png",
                "http://i.imgur.com/GCBBLKZ.jpg",
                "http://i.imgur.com/ag8gL4I.jpg",
                "http://i.imgur.com/y8Tql7h.png",
                "http://i.imgur.com/ayMVRSo.jpg",
                "http://i.imgur.com/ltS7igq.jpg",
                "http://i.imgur.com/M6dylmI.png",
                "http://i.imgur.com/jMIYFtN.jpg",
                "http://i.imgur.com/Z50QDGq.jpg",
                "http://i.imgur.com/NaW7QIT.jpg",
                "http://i.imgur.com/BbVN19E.jpg",
                "http://i.imgur.com/AoTtT9I.gifv",
                "http://i.imgur.com/nnJ29jb.png",
                "http://i.imgur.com/XQ7HKLH.gif",
                "http://i.imgur.com/z4amWED.gifv",
                "http://i.imgur.com/f0L2vQe.gifv",
                "http://i.imgur.com/EyjpAqh.gifv",
                "http://i.imgur.com/85vPYG6.gifv",
                "http://i.imgur.com/Iy5X7gS.jpg",
                "http://i.imgur.com/yy8Nfr4.gifv",
                "http://i.imgur.com/lK49qyA.png",
                "http://i.imgur.com/9i0HM74.png",
                "http://i.imgur.com/i8tdmXP.jpg",
                "http://i.imgur.com/sNNZzY9.png",
                "http://i.imgur.com/fLdgdnb.jpg",
                "http://i.imgur.com/E7CoMUp.jpg",
                "http://i.imgur.com/vrim9hJ.png",
                "http://i.imgur.com/HipTJeI.png",
                "http://i.imgur.com/DhEMroj.jpg",
                "http://i.imgur.com/DJi7ZI9.png",
                "http://i.imgur.com/lTbETSG.jpg",
                "http://i.imgur.com/FYLuKog.png",
                "http://i.imgur.com/MaEwJjN.png",
                "http://i.imgur.com/SBnlIn7.jpg",
                "http://i.imgur.com/624vN4t.png",
                "http://i.imgur.com/RZPk2U8.jpg",
                "http://i.imgur.com/DWtTIlT.png",
                "http://i.imgur.com/YOtH8Gj.png",
                "http://i.imgur.com/xSUWL8y.jpg",
                "http://i.imgur.com/QoKyMzI.png",
                "http://i.imgur.com/IzbldMN.jpg",
                "http://i.imgur.com/vW9p0I8.png",
                "http://i.imgur.com/h1rbNEV.jpg",
                "http://i.imgur.com/HrxFEZ0.png",
                "http://i.imgur.com/EoftaGC.jpg",
                "http://i.imgur.com/smxzmDg.jpg",
                "http://i.imgur.com/h2HDxv6.png",
                "http://i.imgur.com/CQWGfOt.jpg",
                "http://i.imgur.com/HBdOBLN.png",
                "http://i.imgur.com/JwVZHEz.jpg",
                "http://i.imgur.com/nlj3fl1.jpg",
                "http://i.imgur.com/fH8nngf.jpg",
                "http://i.imgur.com/daaFZe6.jpg",
                "http://i.imgur.com/YgWTKNe.jpg",
                "http://i.imgur.com/d4lsZME.png",
                "http://i.imgur.com/KR7rfU3.jpg",
                "http://i.imgur.com/Aon6JIm.jpg",
                "http://i.imgur.com/CfHdoMl.jpg",
                "http://i.imgur.com/QU7Xe6Z.jpg",
                "http://i.imgur.com/bV2PtP4.jpg",
                "http://i.imgur.com/5j7qYD2.png",
                "http://i.imgur.com/NlpHipp.jpg",
                "http://i.imgur.com/XacrqH8.jpg",
                "http://i.imgur.com/8rPew15.png",
                "https://i.giphy.com/media/3ohzgSHpvk6b8M7f9e/source.gif", // Actual Hotdog
                "http://i.imgur.com/ANd8B8X.png", // Trans Overwatch
                "https://i.gyazo.com/6a1bb0490a03ba083433c647fe157e77.png", // Sonic Toilet
                "https://i.imgur.com/NpgbCLy.jpg" // Pathetic

            };

            lewd = new string[]
            {
                "https://gfycat.com/WindingAccurateBlackwidowspider", // Girls kissing girls
                "http://i.imgur.com/pP03F4I.gifv", // Suprise Hotdog
                "https://www.youtube.com/watch?v=xNzJnv_EFZw", // Ass Slap
                "https://fat.gfycat.com/OffensiveWindyBlackpanther.webm" // Thighs
            };

            reminder = new string[]
            {
                "https://www.youtube.com/watch?v=SbddcXk5aSA\n👖👖👖👖👖",  // 👖👖👖👖👖
                "https://www.youtube.com/watch?v=eao0Y4SJQjo", // Ai Ass Slap
                "https://www.youtube.com/watch?v=64ixCkz4kJ0", // Cockroaches
                "https://www.youtube.com/watch?v=DaXYaiyqGd0", // Two shots of Vodka
                "https://www.youtube.com/watch?v=ngxyKRNJZXc", // Checkmate Christians
                "https://www.youtube.com/watch?v=cltFarQSPLA", // Situati♂n
                "https://www.youtube.com/watch?v=rvrZJ5C_Nwg&feature=youtu.be&t=2m22s", // Cowboys in the sky
                "https://www.youtube.com/watch?v=-KhxoL3TvHo :regional_indicator_d::regional_indicator_e::regional_indicator_a::regional_indicator_d::regional_indicator_a::regional_indicator_s::regional_indicator_s:" // Deadass Pizza
            };

            //discord = new DiscordClient(x =>
            //{
            //    x.LogLevel = LogSeverity.Info;
            //    x.LogHandler = Log;
            //});

            //// Set the prefix
            //discord.UsingCommands(x =>
            //{
            //    x.PrefixChar = '!';
            //    x.AllowMentionPrefix = true;
            //});

            //commands = discord.GetService<CommandService>();

            //RegisterCommands(); // start looking for commands


            //discord.ExecuteAndWait(async () =>
            //{
            //    await discord.Connect("MzM2OTQyMTIwOTUyNzkxMDUw.DE_qDQ.KO_7SZxJtiFTWNnDRLFt0Bund6U", TokenType.Bot);
            //});
        }

        private void RegisterCommands()
        {
            //commands.CreateCommand("command")
            //    .Do(async (e) =>
            //    {
            //        await e.Channel.SendMessage("I dont know how to private message people so the commands are" +
            //            "\nmei34 - bleach - reminder - lewd - aw shit - vomit - chloe");
            //    });

            //commands.CreateCommand("mei34")
            //    .Do(async (e) =>
            //    {
            //        int randomMeiIndex = rand.Next(mei34.Length);
            //        string meiToPost = mei34[randomMeiIndex];
            //        await e.Channel.SendMessage(meiToPost);
            //    });

            //commands.CreateCommand("bleach")
            //    .Do(async (e) =>
            //    {
            //        await e.Channel.SendMessage("http://i.imgur.com/pDmpQWN.gifv");
            //    });

            //commands.CreateCommand("reminder")
            //    .Do(async (e) =>
            //    {
            //        int randomIndex = rand.Next(reminder.Length);
            //        string reminderPost = reminder[randomIndex];
            //        await e.Channel.SendMessage(reminderPost);
            //    });

            //commands.CreateCommand("lewd")
            //    .Do(async (e) =>
            //    {
            //        int randomIndex = rand.Next(lewd.Length);
            //        string lewdPost = lewd[randomIndex];
            //        await e.Channel.SendMessage(lewdPost);
            //    });

            //commands.CreateCommand("aw shit")
            //    .Do(async (e) =>
            //    {
            //        await e.Channel.SendMessage("http://i.imgur.com/t03c1Vl.gif");
            //    });

            //commands.CreateCommand("kula")
            //    .Do(async (e) =>
            //    {
            //        await e.Channel.SendMessage("https://pbs.twimg.com/media/C_qJBbqUIAAq8eX.png");
            //    });


            //commands.CreateCommand("vomit")
            //    .Do(async (e) =>
            //    {
            //        await e.Channel.SendMessage("http://i2.kym-cdn.com/photos/images/original/000/212/340/1323028063892.jpg");
            //    });

            //commands.CreateCommand("chloe")
            //    .Do(async (e) =>
            //    {
            //        await e.Channel.SendMessage(":one::two: https://i.gyazo.com/e49a67c9080d9ca54b28c12c8f567868.png");
            //    });
          

        }


        //private void Log(object sender, LogMessageEventArgs e)
        //{
        //    Console.WriteLine(e.Message);
        //}

    }
}
