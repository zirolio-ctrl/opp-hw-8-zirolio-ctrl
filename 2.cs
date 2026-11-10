using System;

class Email
{
    public string Theme { get; set; }
    public string From { get; set; }
    public string To { get; set; }
}

interface ILogger
{
    void Log(string message);
}

class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}

class EmailSender
{
    private readonly ILogger logger;

    public EmailSender(ILogger logger)
    {
        this.logger = logger;
    }

    public void Send(Email email)
    {
        logger.Log($"Email from '{email.From}' to '{email.To}' was sent");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ILogger logger = new ConsoleLogger();
        EmailSender es = new EmailSender(logger);

        Email e1 = new Email()
        {
            From = "Me",
            To = "Vasya",
            Theme = "Who are you?"
        };

        es.Send(e1);

        Console.ReadKey();
    }
}