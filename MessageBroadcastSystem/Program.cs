using System;
using MessageBroadcastSystem.Enums;
using MessageBroadcastSystem.AppModes;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MessageBroadcastSystem. What do you want to do?");
            Console.WriteLine("1 - Become Presenter");
            Console.WriteLine("2 - Become Listener");
            Console.WriteLine("3 - Access settings");
            bool isParsed = false;
            AppMode parsedInput = default;
            while (!isParsed)
            {
                string? input = Console.ReadLine();
                if (Enum.TryParse(input, ignoreCase: true, out parsedInput))
                {
                    isParsed = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }

            }
            switch (parsedInput)
            {
                case AppMode.Presenter:
                    Presenter.Window();
                    return;
                case AppMode.Listener:
                    Listener.Window();
                    return;
                case AppMode.Settings:
                    Settings.Window();
                    return;
                default:
                    throw new InvalidOperationException("Unreachable");
            }
        }
    }
}