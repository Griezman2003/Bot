using System;
using System.Linq;
using Telegram.BotAPI;
using Telegram.BotAPI.GettingUpdates;
using Telegram.BotAPI.AvailableMethods;
namespace Bot
{
    class program
    {
    static void Main(string[] args)
    
    {
        var bot = new BotClient("5743894715:AAH8UWLxPsMF5v3A1GEqjTemts8nLZUev0I");
        var updates = bot.GetUpdates();
        while(true){
            if(updates.Length >0){
                Console.WriteLine("hay updates");
                foreach(var update in updates){
                    if (update.Message is not null){
                        var Message = update.Message;
                        bot.SendMessage(Message.Chat.Id, "hola");
                        Console.WriteLine(update.Message.Text);

                    }
                }
                updates= bot.GetUpdates(updates.Max(u => u.UpdateId) + 1);
            }else{
                updates = bot.GetUpdates();
                
            }
        }
      
    }
        
 }
}




