using System;
using System.Text.RegularExpressions;

namespace IPAddressFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Заданий текст
            string inputText = @"
Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
Nunc in est placerat, dignissim 999.999.999.999 turpis at, laoreet turpis. Vestibulum malesuada commodo risus, 
vel efficitur lacus ultricies in. Donec lobortis, mi at sollicitudin efficitur, urna eros ornare nisl, 
quis maximus dui ligula sed ante. 10.0.0.1 Curabitur feugiat vulputate erat, id tristique sem volutpat ac. 
Nulla lacinia enim in mollis venenatis. Etiam auctor tellus a turpis porta ornare. 
Phasellus sodales, velit iaculis consectetur tempor, risus 172.16.254.1 tortor bibendum sapien, ac accumsan purus dolor non nulla. 
Sed congue massa et nunc gravida cursus. 
Sed ultricies, est vitae vehicula 192.168.0.1 efficitur, leo velit dignissim lacus, 
interdum 190.177.0.1 sagittis odio arcu at urna. 
Nam sagittis elit vehicula augue blandit placerat. Suspendisse efficitur quam eu commodo mattis.
                256.256.256.256,
                9404+33.
            ";

            // Регулярний вираз для пошуку IP-адрес
            string ipPattern = @"\b(?:(?:25[0-5]|2[0-4][0-9]|1[0-9]{2}|[1-9]?[0-9])\.){3}(?:25[0-5]|2[0-4][0-9]|1[0-9]{2}|[1-9]?[0-9])\b";

            // Пошук збігів
            MatchCollection matches = Regex.Matches(inputText, ipPattern);

            // Вивід знайдених IP-адрес
            Console.WriteLine("Знайдені IP-адреси:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
            Console.WriteLine("Натисніть Enter для завершення.");
            Console.ReadLine();
        }
    }
}