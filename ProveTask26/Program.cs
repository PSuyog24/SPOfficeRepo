using System.Net;
using System.Net.Mail;

namespace EmailSend
{
    class ClEmail
    {
        public static void Main(String[] args)
        {
            string? myEmail = string.Empty;
            string? myPassword = string.Empty;
            string? receiverEmail = string.Empty;
            ConsoleKey consoleKey;

            try
            {

                Console.WriteLine("Enter Your Email : ");

                myEmail = Console.ReadLine();

                Console.WriteLine("Enter your password : ");

                do
                {
                    var keyInfo = Console.ReadKey(intercept: true);
                    consoleKey = keyInfo.Key;

                    if (consoleKey == ConsoleKey.Backspace && myPassword.Length > 0)
                    {
                        Console.Write("\b \b");
                        myPassword = myPassword[0..^1];
                    }
                    else if (!char.IsControl(keyInfo.KeyChar))
                    {
                        Console.Write("*");
                        myPassword += keyInfo.KeyChar;
                    }
                } while (consoleKey != ConsoleKey.Enter);

                Console.WriteLine("\nEnter the recepient's email : ");

                receiverEmail = Console.ReadLine();

                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(myEmail, myPassword),
                    EnableSsl = true,
                    UseDefaultCredentials = false
                };
                if(myEmail is not null && receiverEmail is not null)
                {
                    smtpClient.Send(myEmail, receiverEmail, "Test Mail", "Test Body");
                    Console.WriteLine("\n\nMessage : Email Sent Successfully");
                }
                else
                {
                    Console.WriteLine("\n\nError : Please enter valid email");
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}