using PasswordGenerator;
using System;
using TextCopy;

namespace ProjectGeneratePassword
{
    class Program
    {
        static void Main(string[] args)
        {
            // Blast ear drums
            AudioHandler.PlaySound();
            // Password construction
            var pwd = new Password(includeLowercase: true, includeUppercase: true, includeNumeric: true, includeSpecial: true, passwordLength: 16);
            // Get password as variable
            var password = pwd.Next();
            // Uses 'TextCopy' Nuget to set clipboard content with generated password
            TextCopy.ClipboardService.SetText(password);
            // Print password in CMD
            Console.WriteLine(password);
            // Hold password in CMD
            Console.Read(); 
        }
    }
}
