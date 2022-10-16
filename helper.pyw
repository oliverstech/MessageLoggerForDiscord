# requires discord.py-self
import discord
import sys
import os
from time import sleep
from datetime import datetime
from pathlib import Path

script_path = Path( __file__ ).parent.absolute()

os.chdir(script_path)

if sys.argv[1] == "all":
    logtype = "all"
elif sys.argv[1] == "id":
    logtype = "id"
    channelid = sys.argv[3]
elif sys.argv[1] == "dm":
    logtype = "dm"

token = sys.argv[2]

class MyClient(discord.Client):
    f = open("log.txt", "w")
    f.write("\n-------------------------------------------------------------------\n") 
    f.write("\nActive! Message logger should now start logging messages below.\n")
    f.write("\n-------------------------------------------------------------------\n")
    f.close()

    async def on_message(self, message):
        f = open("log.txt", "a")
        if self.user == message.author:
            return

        timenow = datetime.now().strftime('%H:%M:%S')

        if logtype == "all":
            f.write(str(message.author) + ": " + message.content + " [" + timenow + "]" + " | Server: " +  str(message.guild) + " / Channel: " + str(message.channel) + "\n")
            if message.attachments:
                for attachment in message.attachments:
                    f.write(str(message.author) + " [attachment]: " + attachment.url + " [" + timenow + "]" + "| Server: " +  str(message.guild) + " / Channel: " + str(message.channel) + "\n")
        elif logtype =="id":
            if str(message.channel.id) == channelid:
                f.write(str(message.author) + ": " + message.content + " [" + timenow + "]"+ "\n")
                if message.attachments:
                    for attachment in message.attachments:
                        f.write(str(message.author) + " [attachment]: " + attachment.url + " [" + timenow + "]"+ "\n")
        elif logtype == "dm":
            if message.channel.type == discord.ChannelType.private or message.channel.type == discord.ChannelType.group:
                f.write(str(message.author) + ": " + message.content + " [" + timenow + "]"+ "\n")
                if message.attachments:
                    for attachment in message.attachments:
                        f.write(str(message.author) + " [attachment]: " + attachment.url + " [" + timenow + "]"+ "\n")
        f.close()


client = MyClient()
client.run(token)