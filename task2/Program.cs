using System;

// Який принцип порушено? Виправте
// Порушено принцип інверсії залежностей - fixed

interface IEmail
{
    public void Send();
}
class Email : IEmail
{
    public String Theme { get; set; }
    public String From { get; set; }
    public String To { get; set; }
    public void Send()
    {
        Console.WriteLine("Email from '" + this.From + "' to '" + this.To + "' was send");
    }
}

class EmailSender
{
    public void Send(IEmail email)
    {
        email.Send();

    }
}

class Program
{
    static void Main(string[] args)
    {
        Email e1 = new Email() { From = "Me", To = "Vasya", Theme = "Who are you?" };
        Email e2 = new Email() { From = "Vasya", To = "Me", Theme = "vacuum cleaners!" };
        Email e3 = new Email() { From = "Kolya", To = "Vasya", Theme = "No! Thanks!" };
        Email e4 = new Email() { From = "Vasya", To = "Me", Theme = "washing machines!" };
        Email e5 = new Email() { From = "Me", To = "Vasya", Theme = "Yes" };
        Email e6 = new Email() { From = "Vasya", To = "Petya", Theme = "+2" };

        EmailSender es = new EmailSender();
        es.Send(e1);
        es.Send(e2);
        es.Send(e3);
        es.Send(e4);
        es.Send(e5);
        es.Send(e6);

        Console.ReadKey();
    }
}