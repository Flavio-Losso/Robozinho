namespace RoboTupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a borda maxima do espaço que o robo ira andar");
            String borda = Console.ReadLine();
            int bordax = Convert.ToInt32(Convert.ToString(borda[0]));
            int borday = Convert.ToInt32(Convert.ToString(borda[2]));

            Console.WriteLine("Informe a posição inicial do robo 01: ");
            String robo1 = Console.ReadLine();
            int Robo1x = Convert.ToInt32(Convert.ToString(robo1[0]));
            int Robo1y = Convert.ToInt32(Convert.ToString(robo1[2]));

            String direcRobo1 = Convert.ToString(robo1[4]);
            int pos1 = Robo1x;
            int pos2 = Robo1y;
            String dirini = direcRobo1;
            int movimento = 0;
            Boolean gambiarra = true;
            while (gambiarra == true)
            {
                Console.WriteLine();
                Console.WriteLine("De o comando para o robo ou X para sair: ");
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
                            case "N": if(Robo1y == borday)
                                {
                                    Console.WriteLine("O robo está na borda não é possivel mais andar");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Robo1y++;
                                    movimento++;
                                }
                                    break;
                            case "O":
                                if (Robo1x == 0)
                                {
                                    Console.WriteLine("O robo está na borda não é possivel mais andar");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Robo1x--;
                                    movimento++;
                                } break;
                            case "S": if (Robo1y == 0)
                                {
                                    Console.WriteLine("O robo está na borda não é possivel mais andar");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Robo1y--;
                                    movimento++;
                                }
                                break;
                            case "L":
                                if (Robo1x == bordax)
                                {
                                    Console.WriteLine("O robo está na borda não é possivel mais andar");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Robo1x++;
                                    movimento++;
                                }
                                break;

                        }
                    }
                    else if (comandoRobo1[i].ToString().Equals("X", StringComparison.OrdinalIgnoreCase))
                    {
                        gambiarra = false;
                        i = comandoRobo1.Length;
                        
                    }

                }
                Console.WriteLine($"{Robo1x} {Robo1y} {direcRobo1} Robo está aqui");
                Console.WriteLine();

            }
            Console.WriteLine($"O robo parou aqui e se desligou: {Robo1x} {Robo1y} {direcRobo1}");
            Console.WriteLine($"O robo partiu daqui: {pos1} {pos2} {dirini} e fez um total de :{movimento} movimentos");
            Console.WriteLine("Até logo");
            Console.WriteLine();
        }
    }
}