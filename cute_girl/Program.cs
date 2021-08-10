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

namespace cute_girl
{
    class Program
    {
        static void Main(string[] args)
        {
            var bot = new bot();
            bot.RunAsync().GetAwaiter().GetResult();
        }
    }
}
