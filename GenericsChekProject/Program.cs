namespace GenericsChekProject
{
    class Message
    {
        public string Text { set; get; }

        public Message(string text)
        {
            Text = text;
        }
    }

    class EmailMessage : Message
    {
        public EmailMessage(string text) : base(text) { }
    }

    class SmsMessage : Message
    {
        public SmsMessage(string text) : base(text) { }
    }


    class Messenger<T> where T : Message
    {
        public void SendMessage(T message)
        {
            Console.WriteLine($"sending message: {message.Text}");
        }
    }

    class  WebMessanger<T> : Messenger<T> where T : Message
    {

    }


    class Person<T>
    {
        public T? Id { set; get; }
        public string? name { set; get; }
    }

    class Employe<T> : Person<T>
    {

    }



    internal class Program
    {
        
        static void Main(string[] args)
        {
            Message message = new Message("No error!");

            SendMessage(new EmailMessage("Welcome!"));
        }
    }
}