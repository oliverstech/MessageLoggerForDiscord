# Message Logger For Discord
A guide to Discord Message Logger by Oliver's Tech Corner!

**WARNING**: This utilises a self-bot library to view messages recieved, so you are using this at your own risk. However, the chance of being banned is very low!

**WARNING**: Using the 'Log ALL messages' function can cause your console to become very congested if you are in a lot of servers! Please take caution using this feature.

This bot needs your token to run. But being open source, it's not going to steal your token! You can read the code yourself if you don't trust me!

Library required: discord.py-self

Installation of library
---------------------------
1. Open up a command prompt window. Copy paste the following commands. 
pip uninstall discord.py
pip uninstall discord
pip install discord.py-self

**Why does it get rid of the standard discord.py package, you may be asking?**

This is because discord.py-self does everything discord.py does, but with support for selfbots too. So, you're not uninstalling discord.py at all. Your scripts will all still work fine!

Getting your token
-----------------------
1. Open a chromium-based browser (edge, chrome, brave etc).
2. Press F12 and click 'Network'.
3. Type 'library' in the search bar.
4. Refresh the page; an entry with 'library...' should appear. It may have more information at the end, like 'library?country_code=GB' etc.
5. Click on it! Then, scroll until you see 'authorization'. Right click and press 'Copy value'. 

Congrats! You've just copied your discord auth token. 

**DO NOT SEND IT TO ANYONE! ONLY USE IT WHERE IT CAN BE TRUSTED. EG OPEN SOURCE SCRIPTS WHERE YOU CAN VIEW THE CODE; NOT JUST A RANDOM EXE YOU FOUND!!!**

Usage
---------------
1. run the script with "py <path-to-script>" or double click it
2. paste token --or-- make a file called token.txt in the same directory with your token within it
3. Choose which version of logging you'd like to set
4. Logger is configured!

Configuring on startup
----------------------------
1. Make a shortcut and type:

`py "<path-to-script>" "noprompt" "<option>"`

`<path-to-script>` - The path to the python script

`<option>` - an option out of all/dm (all=log all messages / dm=log all DMs)

2. Press WindowsKey+R and type "shell:startup"
3. Drag the shortcut into the folder
Script will now run on boot

[requires token.txt with token in it]

Using channel ID mode (not on startup)
-----------------------------------------------
When you choose to use channel ID mode, you'll be asked to paste a channel ID (makes sense). This is the end of the URL on the web-based version of Discord.

https://discord.com/channels/@me/1234567890

https://discord.com/channels/1234567890/0987654321

The first URL channel ID would be '1234567890'.

In the case of the second URL, you would only copy the second number and not the first one, since the first one is the Guild ID (server ID), not the channel. So, in this case, the ID would be '0987654321'.
