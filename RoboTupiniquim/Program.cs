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

            Console.WriteLine();
            Console.WriteLine("De o comando para o robo: ");
            
            String comandoRobo1 = Console.ReadLine();
            x1 = robo1X;
            y1 = robo1y;
            for (int i = 0; i < comandoRobo1.Length; i++)
            {
                if (comandoRobo1[i].Equals("D"))
                {
                    switch (matriz[x1, y1])
                    {
                        case "N": matriz[x1, y1] = "L"; break;
                        case "L": matriz[x1, y1] = "S"; break;
                        case "S": matriz[x1, y1] = "O"; break;
                        case "O": matriz[x1, y1] = "N"; break;

                    }
                }
                else if (comandoRobo1[i].Equals("E"))
                {
                    switch (matriz[x1, y1])
                    {
                        case "N": matriz[x1, y1] = "O"; break;
                        case "O": matriz[x1, y1] = "S"; break;
                        case "S": matriz[x1, y1] = "L"; break;
                        case "L": matriz[x1, y1] = "N"; break;

                    }
                }
                direcRobo1 = matriz[x1, y1];
                switch (matriz[x1, y1])
                {
                    case "N": y1++; break;
                    case "L": x1++; break;
                    case "S": y1--; break;
                    case "O": x1--; break;
                }

            }
            matriz[robo1X, robo1y] = null;
            matriz[x1, y1] = direcRobo1;
            Console.WriteLine($"{x1} {y1} {matriz[x1,y1]} Estou Aqui :D");
            Console.WriteLine();

        }
    }
}