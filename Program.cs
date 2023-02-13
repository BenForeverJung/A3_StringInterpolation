namespace A3_StringInterpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Section one - Using today's date.");
            Console.WriteLine();

            var now = DateTime.Now;
            Console.WriteLine("1.");
            Console.WriteLine($"{now,40:MMMM dd, yyyy}");
            Console.WriteLine();

            Console.WriteLine("2.");
            Console.WriteLine($"{now:yyyy.MM.dd}");
            Console.WriteLine();

            Console.WriteLine("3.");
            Console.WriteLine($"{now:'Day' dd 'of' MMMMM, yyyy}");
            Console.WriteLine();

            Console.WriteLine("4.");
            Console.WriteLine($"{now:'Year:' yyyy, 'Month:' MM, 'Day:' dd}");
            Console.WriteLine();

            Console.WriteLine("5.");
            Console.WriteLine($"{now,10:dddd}");
            Console.WriteLine();

            Console.WriteLine("6.");
            Console.Write($"{now,10:hh:mm tt}{now,10:dddd}");
            Console.WriteLine();

            Console.WriteLine("7.");
            Console.WriteLine($"{now:'h:'hh, 'm:'mm, 's:'ss}");
            Console.WriteLine();

            Console.WriteLine("8.");
            Console.WriteLine($"{now:yyyy.MM.dd.hh.mm.ss}");
            Console.WriteLine();


            Console.WriteLine("---------------------------------");


            Console.WriteLine("Section two - Using PI. ");
            Console.WriteLine();

            var pi = Math.PI;
            Console.WriteLine("1.");
            Console.WriteLine($"{pi:C2}");
            Console.WriteLine();

            Console.WriteLine("2.");
            Console.WriteLine($"{pi,15:N3}");
            Console.WriteLine();











        }
    }
}