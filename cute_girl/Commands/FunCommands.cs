using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Exceptions;
using DSharpPlus.Entities;
using DSharpPlus.EventArgs;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using DSharpPlus.CommandsNext.Attributes;
using System.Linq;


namespace cute_girl.Commands
{
    public class FunCommands : BaseCommandModule
    {
        [Command("ping")]
        public async Task Ping(CommandContext ctx)
        {
            await ctx.TriggerTypingAsync();

            var emoji = DiscordEmoji.FromName(ctx.Client, ":ping_pong:");

            await ctx.RespondAsync($"{emoji} Pong! Ping: {ctx.Client.Ping}ms").ConfigureAwait(false);
        }

        [Command("add")]
        public async Task Add(CommandContext ctx, int number1, int number2)
        {
            await ctx.Channel.
                SendMessageAsync((number1 + number2).ToString())
                .ConfigureAwait(false);
        }
        [Command("floppa")]
        public async Task floppa(CommandContext ctx)
        {
            string[] floppa =
            {
                "https://cdn.discordapp.com/attachments/820574714383826955/874526506494341120/image0.jpg",
                "https://cdn.discordapp.com/attachments/835018574057701406/873977288532840528/image0-2.gif",
                "https://cdn.discordapp.com/attachments/820574714383826955/873629188723187752/image0.png",
                "https://cdn.discordapp.com/attachments/820574714383826955/873628952483213322/image0.png",
                "https://cdn.discordapp.com/attachments/820574714383826955/873275085279080478/image0.png",
                "https://cdn.discordapp.com/attachments/820574714383826955/872962418765070336/image0.jpg",
                "https://cdn.discordapp.com/attachments/820574714383826955/872883964199706674/image0.png",
                "https://cdn.discordapp.com/attachments/820574714383826955/872560275432288276/Screenshot_20210803-210903_Instagram.png",
                "https://cdn.discordapp.com/attachments/820574714383826955/872142642350264420/image0.jpg",
                "https://cdn.discordapp.com/attachments/820574714383826955/871767810160877568/image0.jpg",
                "https://cdn.discordapp.com/attachments/820574714383826955/871767669743976448/image0.jpg",
                "https://cdn.discordapp.com/attachments/820574714383826955/871627126103740416/image0.jpg",
                "https://cdn.discordapp.com/attachments/820574714383826955/871403041184698368/image0.jpg",
                "https://cdn.discordapp.com/attachments/820574714383826955/871108982629077062/image0.jpg",
                "https://cdn.discordapp.com/attachments/820574714383826955/870936791207784468/image0.jpg",
                "https://cdn.discordapp.com/attachments/820574714383826955/870771102127890472/222706342_4514677051952593_8616376968364757885_n.mp4",
                "https://cdn.discordapp.com/attachments/820574714383826955/870657751515275274/video0.mp4",
                "https://cdn.discordapp.com/attachments/820574714383826955/870620537464963112/image0.png",
                "https://cdn.discordapp.com/attachments/820574714383826955/870419750264647680/video0.mp4",
                "https://cdn.discordapp.com/attachments/820574714383826955/870419673907363890/image0.jpg",
                "https://cdn.discordapp.com/attachments/820574714383826955/870219404825198612/image0.jpg",
                "https://cdn.discordapp.com/attachments/820574714383826955/870017009310646312/Screenshot_20210728-202530_Instagram.png",
                "https://cdn.discordapp.com/attachments/820574714383826955/869958251406569473/image0.png",
                "https://cdn.discordapp.com/attachments/820574714383826955/869958178006237184/video0.mp4",
                "https://cdn.discordapp.com/attachments/820574714383826955/869735082930343976/image0.jpg",
                "https://cdn.discordapp.com/attachments/820574714383826955/869626353262166026/image0.jpg",
                "https://cdn.discordapp.com/attachments/820574714383826955/869223031053090856/video0.mp4",
                "https://cdn.discordapp.com/attachments/820574714383826955/869039516357390356/image0.jpg",
                "https://cdn.discordapp.com/attachments/820574714383826955/869039294159945758/image0.jpg",
                "https://cdn.discordapp.com/attachments/820574714383826955/868635198806437898/image0.jpg",
                "https://cdn.discordapp.com/attachments/820574714383826955/868635034582675536/image0.jpg",
                "https://cdn.discordapp.com/attachments/820574714383826955/868560774900097074/image0.jpg",
                "https://cdn.discordapp.com/attachments/820574714383826955/867944998589583370/image0.png",
                "https://cdn.discordapp.com/attachments/820574714383826955/867944912086261781/video0.mp4",
                "https://cdn.discordapp.com/attachments/820574714383826955/867871375229059102/image0.jpg",
                "https://cdn.discordapp.com/attachments/820574714383826955/867871165020241920/image0.jpg",
                "https://cdn.discordapp.com/attachments/820574714383826955/867528766900928572/image0.png",
                "https://cdn.discordapp.com/attachments/820574714383826955/867528702543659008/image1.png",
                "https://cdn.discordapp.com/attachments/820574714383826955/867370654188830750/image0.png",
                "https://cdn.discordapp.com/attachments/820574714383826955/867111134473879613/video0.mov",
                "https://cdn.discordapp.com/attachments/820574714383826955/867110980647649300/image0.jpg",
                "https://cdn.discordapp.com/attachments/607945642739892234/866183439812263945/video0.mp4",
                "https://cdn.discordapp.com/attachments/820574714383826955/866100922383073300/video0.mp4",
                "https://cdn.discordapp.com/attachments/820574714383826955/865817129551003648/video0.mp4",
                "https://cdn.discordapp.com/attachments/820574714383826955/865817048298422292/video0.mp4",
                "https://cdn.discordapp.com/attachments/820574714383826955/865605214522179594/image0.jpg",
                "https://cdn.discordapp.com/attachments/820574714383826955/865605208716214292/image0.png",
                "https://cdn.discordapp.com/attachments/820574714383826955/865122721201782864/image0.jpg",
                "https://cdn.discordapp.com/attachments/820574714383826955/865017162049388564/image0.png",
                "https://cdn.discordapp.com/attachments/820574714383826955/864953398485843988/image0.jpg",
                "https://cdn.discordapp.com/attachments/820574714383826955/864945105466032128/video0.mp4",
                "https://cdn.discordapp.com/attachments/862677752079581204/863775902327635988/lt_ploob_1625947745574.mp4"
            };

            var rng = new Random();
            await ctx.RespondAsync(floppa[rng.Next(floppa.Length)]);
        }


        [Command("floppafriday"), Aliases("friday")]
        public async Task FloppaFriday(CommandContext ctx)
        {
            await ctx.TriggerTypingAsync();

            var emoji = DiscordEmoji.FromName(ctx.Client, ":partying_face:");

            await ctx.Channel.SendMessageAsync($"{emoji} FLOPPA FRIDAY!!!!!!!!").ConfigureAwait(false);

            await ctx.Channel.SendMessageAsync("https://cdn.discordapp.com/attachments/258514486057500672/873306551807516712/FLOPPA_FRIDAY__--360P.mp4").ConfigureAwait(false);


        }
    }
}
