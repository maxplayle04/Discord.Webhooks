# Discord.Webhooks
A simple library for sending messages using a Discord Webhook in C#.NET.

### Usage
This library is simple, in that it consists of only a single object, the `Webhook` object. Everytime you want to send a message, you can simply initialise a new object, specify the information, then call `Webhook.SendInstance()`.

If you're in a memory-conscious environment, and want to save system resources - you can just modify the values of an existing `Webhook` object and send it once again. That'll work in just the same way.

### Example

Here's how I can see most people using the library:
```c#
    var webhook = new Webhook()
    {
        Message = "Hello world!",
        Username = "Max's Wonderful Assistant",
        WebhookUrl = "[redacted]"
    };
    
    webhook.SendInstance();
```

However, if you're one for compact code; sure - use this:
```c#
    new Webhook()
    {
        Message = "Hello world!",
        Username = "Max's Wonderful Assistant",
        WebhookUrl = "[redacted]",
    }.SendInstance();    
```

Finally, like most .NET objects, you can modify the values of an existing object after creating it.

```c#
     var webhook = new Webhook()
     {
        Message = "Hello world!",
        Username = "Max's Wonderful Assistant",
        WebhookUrl = "[redacted]"
     };
     
     webhook.SendInstance();
     
     webhook.Message = "How are you today?";
     
     webhook.SendInstance();
```

Please note that this library will not control any rate limiting, so it's quite possible that you may get an Exception if you call the API in a loop. Just saying! 😂

### Pull Requests
If you want to add some more features - feel free. Just send me a message in [my Discord Server](https://discord.gg/3bq88pY) if you send a pull request, because otherwise I'm unlikely to notice! Any additional features you'd like to add are more than appreciated, and I look forward to seeing what people might add! 👀

### Contact 
If you want to contact me regarding this project, the best way to do so is, like above - in [my Discord Server](https://discord.gg/3bq88pY).