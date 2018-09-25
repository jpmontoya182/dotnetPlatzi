using static System.Console;

namespace SchoolCore.Utilities
{
    public static class Printer
    {
        public static void DrawLine(int sizeLine = 10)
        {
            WriteLine("".PadLeft(sizeLine, '='));
        }

        public static void DrawTitle(string title)
        {
            DrawLine(title.Length);
            WriteLine(title);
            DrawLine(title.Length);
        }

        public static void PrinterBeep(int hz = 2000, int time = 1000, int amount = 1)
        {
            while(amount-- >0 )
            {
                System.Console.Beep(hz, time);
            }            
        }
    }
}