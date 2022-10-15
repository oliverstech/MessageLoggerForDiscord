# requires discord.py-self
from dis import disco
from operator import truediv
import discord
import sys
import os
from datetime import datetime
from os.path import exists
from pathlib import Path

os.system('cls')

print("-------------------------------")
print("OTC Message Logger for Discord")
print("By Oliver's Tech Corner!")
print("-------------------------------")

try:
    if (sys.argv[1] == "noprompt"):
        noprompt = True
    if (sys.argv[2] == "all"):
        logtype = "all"
    elif(sys.argv[2] == "dm"):
        logtype = "dm"
    else:
        print("Invalid arguments specified")
        sys.exit()
except (IndexError):
    print("Not using command line mode")
    noprompt = False

if (noprompt == False):
    while (True):
        i=input("This script technically does self-bot your account to see messages. Are you sure you would like to continue? [Y/N] ")
        i = i.lower()
        if i == "y":
            break
        elif i == "n":
            sys.exit()

script_path = Path( __file__ ).parent.absolute()

os.chdir(script_path)


if exists('token.txt'):
    f = open("token.txt", "r")
    token = f.read()
    print("Token file (token.txt) was found in same directory, using that.")
    if noprompt == False:
        while (True):
            e=input("Show token? [Y/N]: ")
            e = e.lower()
            if e == "y":
                print("Token: " + token)
                break
            elif e == "n":
                break
            else:
                continue
else:
    if noprompt == False:
        print("token.txt wasn't found")
        token=input("Enter your token (you can make a file called 'token.txt' in the same folder as the logger and paste your token there to stop the script asking in future!): ")
    else:
            sys.exit()

if noprompt == False:
    while (True):
        option=input("""
Choose an option:

1) Log ALL messages 
2) Log messages in channel ID given
3) Log DMs only

(messages sent by you will be ignored): """)
        if option == "1":
            logtype = "all"
            break
        elif option == "2":
            logtype = "id"
            channelid = input("Enter ID of channel to log (copy from address bar on discord web; eg https://discord.com/channels/@me/>>123456789<<): ")
            break
        elif option == "3":
            logtype = "dm"
            break
        else:
            os.system('cls')
            continue


class MyClient(discord.Client):
    print("-------------------------------------------------------------------")
    print("Configured; message logger should now start logging messages below.")
    print("-------------------------------------------------------------------")

    async def on_message(self, message):

        if self.user == message.author:
            return

        timenow = datetime.now().strftime('%H:%M:%S')

        if logtype == "all":
            print(str(message.author) + ": " + message.content + " [" + timenow + "]" + " | Server: " +  str(message.guild) + " / Channel: " + str(message.channel))
            if message.attachments:
                for attachment in message.attachments:
                    print(str(message.author) + " [attachment]: " + attachment.url + " [" + timenow + "]" + "| Server: " +  str(message.guild) + " / Channel: " + str(message.channel))
        elif logtype =="id":
            if str(message.channel.id) == channelid:
                print(str(message.author) + ": " + message.content + " [" + timenow + "]")
                if message.attachments:
                    for attachment in message.attachments:
                        print(str(message.author) + " [attachment]: " + attachment.url + " [" + timenow + "]")
        elif logtype == "dm":
            if message.channel.type == discord.ChannelType.private or message.channel.type == discord.ChannelType.group:
                print(str(message.author) + ": " + message.content + " [" + timenow + "]")
                if message.attachments:
                    for attachment in message.attachments:
                        print(str(message.author) + " [attachment]: " + attachment.url + " [" + timenow + "]")





client = MyClient()
client.run(token)