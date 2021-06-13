using System;
using System.Net.Http;
using System.Security.Cryptography;
using Discord.Webhooks;

namespace Discord.Webhooks.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
                Tick();
        }

        static void Tick()
        {
            Console.WriteLine("Webhook URL: ");
            string url = Console.ReadLine();
            Console.WriteLine("Username:");
            string username = Console.ReadLine();
            Console.WriteLine("Text:");
            string text = Console.ReadLine();
            
            var wh = new Webhook()
            {
                Message = text,
                Username = username,
                WebhookUrl = url,
            };
            
            Console.WriteLine("Sending...");
            wh.SendInstance();
            Console.WriteLine("Sent!");
        }
    }
}