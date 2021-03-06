# Attention! Bot for Discord

[![CodeFactor](https://www.codefactor.io/repository/github/the-mighty-mo/attentionbot/badge)](https://www.codefactor.io/repository/github/the-mighty-mo/attentionbot)
[![Build Status](https://hallb1016.visualstudio.com/FBIBot/_apis/build/status/the-mighty-mo.AttentionBot?branchName=master)](https://hallb1016.visualstudio.com/FBIBot/_build/latest?definitionId=3&branchName=master)

## This bot has been retired.
This bot was written very early into my path down becoming a programmer. The structure of the databases combined with the poor quality of the code makes this project next to impossible to maintain. As such, I have officially retired this project.

### Written using Discord.Net 2.2.0 and Microsoft .NET Core 3.1
"Attention to the designated grid square! (E3)" for Discord (from War Thunder®, quite annoying when spammed but fun to spam). Do not compile and run (it's on a server, and you don't have the token).

[***Release Notes***](#release-notes)

##### Note: This bot is constantly evolving. With 2 commands and just under 100 lines of code when first created, it now has 26 commands (20 for the public) and nearly 2,000 lines of code.

Add this bot to your server! https://discordapp.com/api/oauth2/authorize?client_id=346064990152818690&permissions=3230720&scope=bot

Want to report bugs or give suggestions on what should be added next? Join the support server! https://discord.gg/FZJBMBQ

#### Prefix: \

#### Commands:

*\help Parameters*

***NOTE:** If you choose to supply the 3949 parameter, it must be first. If you do not supply it, only one parameter may be given.*

- 3949
  - DMs you all available help commands for the bot or the bot commands for any other given parameters.

- useful
  - Lists all available useful commands for the bot.

- spam
  - Lists all available spam commands for the bot.

- admin
  - Lists all available admin commands for the bot.

- interserver
  - Lists all available InterServer Chat commands for the bot.

*Useful:*

- \help [parameter(s) (optional)]
  - Lists available commands for the bot.

- \ping
  - Returns the latency of the bot.

- \changelog [3949 (optional)]
  - Sends a link to the version history (changelog) of the bot.
  
- \membercount
  - Lists number of users on the server by status.

*Fun Spams:*

***NOTE:** User only works if \mentions is set to 1. Set User to the ID or mention of the user you want to mention.*

**References from:** War Thunder

- \attention [position (optional)] [user ID (optional)]
  - Message is randomized.
  - Position can contain one letter A-J and/or one number 1-10. Order and capitalization do not matter.
  - Position is randomized if none is given.
  - Order of parameters does not matter.

**References from:** Sword Art Online Abridged

- \gary [user (optional)]
  - "We must save my family!"

- \bandits [user (optional)]
  - "The bandits are coming!"

- \sword [user (optional)]
  - "There's a person attached to this sword, you know! I WILL NOT BE OBJECTIFIED!"

- \karf [user (optional)]
  - Quote is randomized

*Admins:*

***NOTE:** Users with the "Administrator" power are considered Server Owners for these commands. "Admins" are the role(s) the Server Owners have designated as "Admin" roles.*

***NOTE 2:** The Role and Channel parameters can either be their respective ID or a mention of the channel/role.*

- \settings [3949 (optional)]
  - **ADMINS/SERVER OWNERS:** Displays the current configuration of the bot.

- \admin [role]
  - **SERVER OWNERS:** Sets the specified role as an administrative role for the bot's admin commands.

- \announce [channel]
  - **ADMINS/SERVER OWNERS:** Sets the specified channel as the channel for bot announcements.
  - To disable announcements, type in "-" as the channel.

- \mentions [0/1]
  - **ADMINS/SERVER OWNERS:** Enables (1) or disables (0) user mentions for the bot.

*InterServer Chat:*

***NOTE:** All of these commands require the user to be a Server Owner or a user with the "Administrator" permission.*

***NOTE 2:** The channel parameter can either be its ID or a mention of the channel.*

- \interserver-settings [3949 (optional)]
  - Displays the current InterServer Chat configuration for the bot

- \interserver-chat [channel]
  - Sets the specified channel as the channel for an InterServer Chat.
  - To disable InterServer Chat, type in "-" as the channel.

- \display-user-guild [0/1]
  - Enables (1) or disables (0) whether or not the bot shows what server the message was sent from.

- \broadcast-guild-name [0/1]
  - Enables (1) or disables (0) whether or not other servers can see your server's name if they have \display-user-server set to 1.

- \enable-whitelist [0/1]
  - Enables (1) or disables (0) whether or not whitelist-only mode is on. Whitelist-only mode only allows your messages to reach whitelisted servers and messages from whitelisted servers to reach you.

- \whitelist [Server ID]
  - Adds the given server to the whitelist. Overrides the blacklist.

- \blacklist [Server ID]
  - Adds the given server to the blacklist.


# Release Notes
## v3.0.0.0 (Alpha)
- Add voice commands
- This is an alpha build. Features in this build are unofficial and may not be released in the final version.
## v2.2.2.1 (Stable)
- Fixed a bug where some lists were being modified within a foreach loop of themselves
- Updated code to match new requirements for Discord.Net 2.0+
## v2.2.2.0
- Added a server blacklist and whitelist for the InterServer Chat
- Added "Whitelist" to \interserver-settings
- Added the Server ID next to the name in the InterServer Chat
- Added File read/write functions to manage variably-sized 2-D key-value databases (aka Dictionary<ulong, List\<ulong>>)
- Changed \settings and \interserver-settings so the 3949 parameter sends a DM (like \help)
- Fixed a potential bug where the bot would send an Error: File not found if a file was deleted or not yet created
## v2.2.1.2 LTS
- Fixed the help parameters message for the bot ID not mentioning that other parameters work with the bot ID parameter
- Fixed the interserver-chat help message saying SERVER OWNERS despite the note already mentioning that requirement
- Fixed a problem where \\help 3949 would not send all available commands for the bot but would just send the help parameters
- **v2.2.1.2a LTS (LTS only)**
  - Fixed a potential bug where the bot would send an Error: File not found if a file was deleted or not yet created
## v2.2.1.1
- Changed PermissionChecker.HasSend to be synchronous since it only uses synchronous functions
- Changed Announcements and InterServer Chat to send messages asynchronously to the chats to reduce delay
- Fixed a problem where the file/image wouldn't be deleted from the bot's server after sending them to all InterServer Chats
## v2.2.1.0
- Added ability to send files and images through the InterServer Chat
## v2.2.0.0
- New Admin Command: \interserver-settings
  - Displays the current configuration of the InterServer Chat
- New Admin Command: \display-user-guild [0/1]
  - Enables or disables whether or not the bot shows what server the message was sent from
- New Admin Command: \broadcast-guild-name [0/1]
  - Enables or disables whether or not other servers can see your server's name if they have \display-user-guild set to 1
- Moved all InterServer Chat commands to their own module
- Moved all InterServer \help information to its own category
- New \help category: interserver
  - Lists all available InterServer Chat commands for the bot
## v2.1.0.0
- New Command: \ping
  - Returns the bot's latency
- New Admin Command: \interserver-chat [channel]
  - Use the designated channel for InterServer Chat, technology that allows communication between different servers running the bot
- Updated libraries
## v2.0.1.6 LTS
- Added console prints when the bot disconnects/connects to the Discord WebSocket
## v2.0.1.5 LTS
- Fixed an issue where the bot would attempt to send announcements to the designated announcements channel, even if it didn't have the "Send Messages" permission
- Fixed the algorithm the bot uses when trying to find a channel to send a join message to when it first joins a server
- Created PermissionChecker.cs to check if the bot has needed permissions
- Added the Bot Client ID to SecurityInfo.cs
## v2.0.1.4 LTS
- Fixed an issue where the bot would reply to other bots
- Fixed an issue where the server restart message always said the bot's server would shut down and not restart
- Fixed exit message not showing the last phrase of the message in certain scenarios
## v2.0.1.3
- Removed unused parameters and messages in the restart/exit Owner commands
- Fixed the server restart messages
## v2.0.1.2
- Changed error message if the user tries to use an admin command without being an admin
- Made Admin commands validate that the given ID was valid
- Fixed a bug where the code attempted to add SocketChannel to a List<> of SocketTextChannel
- Fixed a performance issue related to writing to a file in a loop instead of after the loop
## v2.0.1.1
- Moved the bot version to SecurityInfo.cs
- Changed changelog message to show the current bot version
## v2.0.1.0
- This update is almost purely under-the-hood improvements
  - Bot now sends a message (to spam, otherwise any channel with "test" in the name, otherwise general/whatever it can find) when it joins a new server (tells users the help command)
  - Bot now removes instances of a server from its database upon being kicked instead of waiting for the owner to give a command
  - Optimized CleanupFiles() in Owner.cs
  - Removed obsolete owner command: \online
## v2.0.0.0
- Changed command: \help
  - Message shows available parameters to see specific categories. On servers, only one category may show at a time
  - Parameter "3949" DMs you the full help message unless additional parameters are also used. "3949" must be the first parameter if it is used
- Changed all spam commands to allow users to mention a user for the parameter instead of using the user ID
- Changed command: \attention
  - Order of parameters does not matter
- Changed all Admin commands to allow users to mention a role/channel for the parameters instead of using the IDs
- Created Files.cs to control reading and writing to/from the files
- Optimized Admin.cs hasRole boolean stuff (moved to its own function)
## v1.5.8.2
- Changed a KARF message to mention a user in a specific part of the message
- Changed the Owner \close message
## v1.5.8.1
- Changed formatting of \help
## v1.5.8.0
- New command: \karf
  - Various different quotes from the Kirito Is Always Right Foundation
- Fixed a bug where initializing a new Random() inside of a function too frequently could result in the same number(s) being used in multiple instances of the command
## v1.5.7.0
- New command: \sword
  - "There's a person attached to this sword, you know! I WILL NOT BE OBJECTIFIED!"
## v1.5.6.6
- Changed formatting so all functions start with capital letters
## v1.5.6.5
- Moved the "Useful" commands to their own module to make future development easier
## v1.5.6.4
- Changed the \membercount Embed Title to "Member Count"
## v1.5.6.3
- Added the ability to type "3949" as a parameter for the \settings command to prevent a spam of every bot with a \settings command displaying their settings
- Made the embed color slightly darker
## v1.5.6.2
- Fixed every bug related to a role/channel/server/etc. being missing from a List, Dictionary, or the bot's lists of server connections and information
- Fixed a bug where adding an already existing key to a Dictionary would cause an exception
- Extended the Dictionary class to include a Put(TKey, TValue) function, which Adds(TKey, TValue) if TKey does not exist or modifies this[TKey] = TValue if TKey does exist
- Changed the output of the admin commands and added new outputs if nothing changed because the role/channel/etc. already exists
## v1.5.6.1
- Fixed formatting for the \settings command
## v1.5.6.0
- New command: \settings
  - Displays the current bot configuration
- Fixed using "String" instead of "string"
- Made the bot color be more easily changed
## v1.5.5.5
- Fixed a bug where \announce would not work if your server was not already in the announcement channels database
## v1.5.5.4
- Changed: \help and \changelog no longer require the "3949" parameter; however, it is recommended so other bots don't show their help/changelog messages as well
## v1.5.5.3 SF1
- Security Fix 1: Fixed a problem with a leaked bot security token, now saved in a separate file
## v1.5.5.3
- Fixed a bug that caused saved Admin roles to be deleted from the bot's database upon performing a \cleanup
- Updated the bot to use Microsoft .NET 4.7.1
## v1.5.5.2
- Improve formatting for \help to be an embed
## v1.5.5.1
- Changed Owner commands to not output that a cleanup finished every single time
- Renamed \usercount to \membercount
## v1.5.5.0
- Optimize code to use Dictionaries for server and channel IDs since they are linked anyways
  - This is a more permanent, more effective, and more efficient fix to the same bug v1.5.4.3 fixed
- Optimized code so things loop less, and common lines of code are outside of the if statements while the individually different statements remain within
- New command: \gary [user ID (optional)]
  - "We must save my family!"
  - Sword Art Online Abridged reference
- New command: \bandits [user ID (optional)]
  - "The bandits are coming!"
  - Sword Art Online Abridged reference
- New commands (Owner): \cleanup (cleans up the files that stores bot data), \close (closes the bot silently), \reload (reloads the bot)
- Improved formatting for \help
## v1.5.4.3
- Fixed a major bug where if a server or channel went missing (was deleted/bot was kicked), the bot would stop working altogether
## v1.5.4.2
- Updated \help to show the version of .NET Framework and Discord.Net the bot uses
## v1.5.4.1
- Fixed a bug where \usercount crashed the computer's network capabilities
## v1.5.4.0
- Changed \usercount layout to use inline fields with an EmbedBuilder, looks much cleaner and more organized now
## v1.5.3.0
- Changed \usercount to display more information:
  - Total: displays the total number of users and bots on the server
  - Users: displays the total number of users on the server
    - Online, Away, Do Not Disturb, Invisible, Offline: displays the number of users with that status on the server
  - Bots: displays the total number of bots on the server
    - Online, Offline: displays the number of bots with that status on the server
## v1.5.2.1
- Fixed an issue with the \usercount command crashing the bot's internal network connectivity on large servers
## v1.5.2.0
- New command: \changelog 3949 (sends a link to the version history / changelog of the bot)
## v1.5.1.0
- Removed the arrays in Program.cs since they were identical to the Lists (replace all instances of the arrays with the Lists)
- Added code to detect if an instance of the program is already running and, if it is, display a message saying it's already running and close the new instance; this prevents the bot from logging in a second time, resetting the bot token
## v1.5.0.1
- Fixed a bug where having mentions enabled on the server but not putting in a user ID would crash the bot
## v1.5.0.0
- New command: \usercount (lists the number of users on the server by status)
- Made various variables private, static, or constant (programming practices / security)
## v1.4.0.1
- Fixed Owner.cs commands to check if the bot has access to a channel and, if not, remove the channel and server frmo the database.
## v1.4.0.0 (uploaded to GitHub as v1.3.5.0)
- Data saved in txt files now saved as strings for easier management of bot errors
- Cleaned up the role function
- New command: "noadmin"
## v1.3.4.7
- Updated the Microsoft .NET XML dependency to v1.3.1 (old: v1.3.0)
## v1.3.4.6
- Fixed error where if bot was kicked from a server, it couldn't send announcements
## v1.3.4.5
- Fixed Owner \exit command saying "Shutting down" instead of "Restarting"
## v1.3.4.4
- Fixed a code-breaking bug with saving the \announce info to the text file
## v1.3.4.3
- Updated .NET Framework Components
- Updated code formatting
- Optimized some of the code
## v1.3.4.2
- Fixed output text of Owner \restart with the [length] parameter
## v1.3.4.1
- Changed syntax of Owner \restart
- Added parameters to Owner \restart
- Optimized and compressed code for Owner \exit
## v1.3.4.0
- Added parameters to \offline
- Changed BinaryFile variable names for readability
## v1.3.3.1
- Fixed an issue where multiple channels on the server could recieve bot announcements
- Fixed an issue where \mention 0 wouldn't save
## v1.3.3.0
- Added ability for bot to mention user
- Added \mentions command for Admins to control if user mentions are enabled for the bot
## v1.3.2.0
- Updated to Discord.Net 1.0.2
- Changed null to "all" for bot exit
- Added length of time bot will be offline if for server shutdown
## v1.3.1.1
- Fixed issue where position number couldn't be 10
- Fixed \help to show position number 10 as an option
## v1.3.1.0
- Added ability for bot to send announcement when back online
- Added ability for bot owner to send announcements
- Fixed bug where admin commands wouldn't execute
- Transfered Owner commands to separate C# file
## v1.3.0.4 (Beta)
- Same release notes as v1.3.1.0
- v1.3.1.0 Fixed the bug
- v1.3.1.0 added the announcements feature
## v1.3.0.3
- Put Admin Commands in separate file
- Removed unused usings
- Made more public static variables local
## v1.3.0.2
- Made some public static variables local
- Fixed \help
## v1.3.0.1
- New command (Server Owners): \admin (adds administrative roles)
- Changed \announce command to let admin roles from above use it
- Changed \announce command to only let one channel per server use it
- Removed unused comment
- Made external files for Channel, Server, and Role info save immediately in case of crash
- Updated \help
## v1.3.0.0 (Beta)
- Same release notes as v1.3.0.1
- v1.3.0.1 fixed a bug where the \announce command wouldn't let admins use it, breaking the entire bot
- v1.3.0.1 fixed a bug where the bot wouldn't finish starting up after reading the txt files
## v1.2.0.2
- Fixed a bug where announcements couldn't find the server ID
## v1.2.0.1
- Fixed \help to show up-to-date commands
- Changed \help formatting
## v1.2.0.0
- Made \restart message send a message to default or available channel on all servers connected
- New command (Server Owners): \announce command to set announcements channel
- Saved \announce channel arrays and lists to text file to load upon bot restart
## v1.1.0.1
- Fixed \restart order of parameters to specify time but not bot
- Fixed \exit command to shut down all bots on my machine
## v1.1.0.0
- New command (Owner): \restart command to give a warning to the user about a bot restart
## v1.0.5.0
- New command (Owner): \exit parameter to specify which bot to shut down
- Added parameter to \help to specify which bot's help information to show
## v1.0.4.0
- Fixed an issue with owner \exit command and optimized code
## v1.0.3.0
- New command: \help
## v1.0.2.0 and older
- Original release, unstable/low on features/slow. Bot runs on newest stable version (no letter after version number).
