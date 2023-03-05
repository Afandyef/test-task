// See https://aka.ms/new-console-template for more information
Console.Write("Enter coordinate X of dot A: ");
            var ax = double.Parse(Console.ReadLine());
            Console.Write("Enter coordinate Y of dot A: ");
            var ay = double.Parse(Console.ReadLine());
            Console.Write("Enter coordinate X of dot B: ");
            var bx = double.Parse(Console.ReadLine());
            Console.Write("Enter coordinate Y of dot B: ");
            var by = double.Parse(Console.ReadLine());
            Console.Write("Enter coordinate X of dot C: ");
            var cx = double.Parse(Console.ReadLine());
            Console.Write("Enter coordinate Y of dot C: ");
            var cy = double.Parse(Console.ReadLine());

            var AB = Math.Abs(Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2)));
            Console.WriteLine($"Lenght of side AB: '{AB}'");

            var AC = Math.Abs(Math.Sqrt(Math.Pow(cx - ax, 2) + Math.Pow(cy - ay, 2)));
            Console.WriteLine($"Lenght of side AC: '{AC}'");

            var BC = Math.Abs(Math.Sqrt(Math.Pow(cx - bx, 2) + Math.Pow(cy - by, 2)));
            Console.WriteLine($"Lenght of side BC: '{BC}'");



            if (AB == AC && AC == BC)
            {
                Console.WriteLine("it is equilateral triangle");
                Console.WriteLine("it right triangle");
            }
            else if ((AB == AC) || (AB == BC) || (BC == AC))
                Console.WriteLine("it is isosceles triangle");
            else
                Console.WriteLine("It is not equilateral and It is not isosceles triangle");


            var perimeter = Math.Round(Math.Abs(AB) + Math.Abs(AC) + Math.Abs(BC));
            Console.WriteLine($"Perimentr: {perimeter}");


            for (int i = 0; i <= perimeter; i++)
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
