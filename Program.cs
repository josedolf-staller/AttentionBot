﻿using System;
using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AttentionBot
{
    public class Program
    {
        static void Main()
            => new Program().StartAsync().GetAwaiter().GetResult();

        private DiscordSocketConfig _config;
        private DiscordSocketClient _client;
        private CommandHandler _handler;

        public static readonly bool isConsole = Console.OpenStandardInput(1) != Stream.Null;

        public static List<ulong> roleID = new List<ulong>();
        public static List<ulong> mentionID = new List<ulong>();
        public static Dictionary<ulong, ulong> servChanID = new Dictionary<ulong, ulong>();
        public static Dictionary<ulong, ulong> interServerChats = new Dictionary<ulong, ulong>();
        public static List<ulong> showUserServer = new List<ulong>();
        public static List<ulong> broadcastServerName = new List<ulong>();
        public static Dictionary<ulong, List<ulong>> ischatWhitelist = new Dictionary<ulong, List<ulong>>();
        public static Dictionary<ulong, List<ulong>> ischatBlacklist = new Dictionary<ulong, List<ulong>>();
        public static List<ulong> wlEnable = new List<ulong>();

        public async Task StartAsync()
        {
            if (isConsole)
            {
                Console.Title = "Attention! Bot for Discord";
            }

            bool isRunning = System.Diagnostics.Process.GetProcessesByName(System.Diagnostics.Process.GetCurrentProcess().ProcessName).Count() > 1;
            if (isRunning)
            {
                await Task.Delay(1000);
                isRunning = System.Diagnostics.Process.GetProcessesByName(System.Diagnostics.Process.GetCurrentProcess().ProcessName).Count() > 1;

                if (isRunning)
                {
                    MessageBox.Show("Program is already running", "Attention! Bot for Discord");
                    return;
                }
            }

            _config = new DiscordSocketConfig
            {
                AlwaysDownloadUsers = false
            };

            _client = new DiscordSocketClient(_config);

            await _client.LoginAsync(TokenType.Bot, SecurityInfo.token);
            await _client.StartAsync();

            await _client.SetGameAsync("Attention! \\help " + SecurityInfo.botID);

            _handler = new CommandHandler(_client);

            servChanID = await Files.FileToDict("servers.txt", "channels.txt");
            roleID = await Files.FileToList("roles.txt");
            mentionID = await Files.FileToList("mentions.txt");
            interServerChats = await Files.FileToDict("interservers.txt", "interchannels.txt");
            showUserServer = await Files.FileToList("show-guild.txt");
            broadcastServerName = await Files.FileToList("broadcast-guild.txt");
            ischatWhitelist = await Files.FileToDictList("wlserver.txt", "wl-");
            ischatBlacklist = await Files.FileToDictList("blserver.txt", "bl-");
            wlEnable = await Files.FileToList("wlenabled.txt");

            if (isConsole)
            {
                Console.WriteLine("Attention! Bot has finished Loading");
            }

            await Task.Delay(-1);
        }
    }
}
