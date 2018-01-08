using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Args;



namespace AptekaUaBot
{
    class Program
    {
        static TelegramBotClient bot = new TelegramBotClient("456590467:AAGfDKswTY9qjGhU4cKpjA3jLYO-N73uSlc");



        static void Main(string[] args)
        {
            bot.StartReceiving();
            bot.OnMessage += Bot_OnMessage;
                        Console.ReadLine();
            
        }

        private static async void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            

            if (e.Message.Type == MessageType.TextMessage)
            {
                var txt = e.Message.Text;
                var cid = e.Message.Chat.Id;
                var name = e.Message.From.FirstName + " " + e.Message.From.LastName;
                var uid = e.Message.From.Id;
                var pol = bot.IsReceiving;

                Console.WriteLine("{0} - {1} : {2}", uid, name, txt);

                if (txt == "/start")
                {
                    await bot.SendTextMessageAsync(cid, "Упыри так что делать будем?");
                   
                }
                else
                {
                    await bot.SendTextMessageAsync(cid, txt);
                }
            }
        }


    }
}
