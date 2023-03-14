namespace RoboTupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o tamanho da matriz: ");
            String tamanhoMatriz = Console.ReadLine();
            int x1 = Convert.ToInt32(Convert.ToString(tamanhoMatriz[0]));
            int y1 = Convert.ToInt32(Convert.ToString(tamanhoMatriz[2]));

            String[,] matriz = new String[x1, y1];

            Console.WriteLine("Informe a posição inicial do robo 01: ");
            String robo1 = Console.ReadLine();
            int robo1X = Convert.ToInt32(Convert.ToString(robo1[0]));
            int robo1y = Convert.ToInt32(Convert.ToString(robo1[2]));
            
            String direcRobo1 = Convert.ToString(robo1[4]);
            matriz[robo1X, robo1y] = direcRobo1;

            Console.WriteLine($"{robo1X} {robo1y} {matriz[robo1X, robo1y]}");
            Console.WriteLine();
            Console.WriteLine("De o comando para o robo: ");
            
            String comandoRobo1 = Console.ReadLine();
            /*if(comandoRobo1 == "Frente")
            {
                String aux = matriz[robo1X, robo1y];
                matriz[robo1X, robo1y] = null;
                robo1X++;
                matriz[robo1X, robo1y] = aux;
            }
            Console.WriteLine($"{robo1X} {robo1y} {matriz[robo1X, robo1y]} Estou aqui capitão");
            Console.WriteLine();
            */
            x1 = robo1X;
            y1 = robo1y;
            for (int i = 0; i < comandoRobo1.Length; i++)
            {
                matriz[robo1X, robo1y] = null;
                if (comandoRobo1[i].Equals("D"))
                {
                    switch (direcRobo1)
                    {
                        case "N": direcRobo1 = "L"; break;
                        case "L": direcRobo1 = "S"; break;
                        case "S": direcRobo1 = "O"; break;
                        case "O": direcRobo1 = "N"; break;

                    }
                }
                else if (comandoRobo1[i].Equals("E"))
                {
                    switch (direcRobo1)
                    {
                        case "N": direcRobo1 = "O"; break;
                        case "O": direcRobo1 = "S"; break;
                        case "S": direcRobo1 = "L"; break;
                        case "L": direcRobo1 = "N"; break;

                    }
                }

                switch (direcRobo1)
                {
                    case "N": y1++; break;
                    case "L": x1++; break;
                    case "S": y1--; break;
                    case "O": x1--; break;
                }

            }
            matriz[x1, y1] = direcRobo1;
            Console.WriteLine($"{x1} {y1} {matriz[x1,y1]}");
            Console.WriteLine();

        }
    }
}