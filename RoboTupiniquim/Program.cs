namespace RoboTupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a posição inicial do robo 01: ");
            String robo1 = Console.ReadLine();
            int Robo1x = Convert.ToInt32(Convert.ToString(robo1[0]));
            int Robo1y = Convert.ToInt32(Convert.ToString(robo1[2]));
            
            String direcRobo1 = Convert.ToString(robo1[4]);

            Console.WriteLine();
            Console.WriteLine("De o comando para o robo: ");
            String comandoRobo1 = Console.ReadLine();

            for (int i = 0; i < comandoRobo1.Length; i++)
            {
                if (comandoRobo1[i].ToString().Equals("D", StringComparison.OrdinalIgnoreCase))
                {
                    switch (direcRobo1)
                    {
                        case "N": direcRobo1 = "L"; break;
                        case "L": direcRobo1 = "S"; break;
                        case "S": direcRobo1 = "O"; break;
                        case "O": direcRobo1 = "N"; break;

                    }
                }
                else if (comandoRobo1[i].ToString().Equals("E", StringComparison.OrdinalIgnoreCase))
                {
                    switch (direcRobo1)
                    {
                        case "N": direcRobo1 = "O"; break;
                        case "O": direcRobo1 = "S"; break;
                        case "S": direcRobo1 = "L"; break;
                        case "L": direcRobo1 = "N"; break;

                    }
                }

                else if (comandoRobo1[i].ToString().Equals("M", StringComparison.OrdinalIgnoreCase))
                {
                    switch (direcRobo1)
                    {
                        case "N": Robo1y++; break;
                        case "O": Robo1x--; break;
                        case "S": Robo1y--; break;
                        case "L": Robo1x++; break;

                    }
                }

            }
            Console.WriteLine($"{Robo1x} {Robo1y} {direcRobo1}");
            Console.WriteLine();

        }
    }
}