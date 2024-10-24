namespace battleahip
{
    internal class Game
    {
        static int xc = 4, yc = 3, ships = 3, p=3;
      // static int[,] p1Ships= new int[xc,yc];

        static int[,,] GameArray = new int[p*2,xc,yc];
        public static void SetupGame()
        {
            for (int i= 0; i < p; i++)
            {
                Console.WriteLine($"player {i + 1} place your ships");
                for (int j = 0; j < ships; j++) { placeships(i); }
            }
               

        }

        private static void ShowShips(int player)
        {
            for (int x = 0; x < xc; x++)
            {
                for (int y = 0; y < yc; y++)
                    Console.WriteLine($"coords: {x},{y} {GameArray[player,x,y]}");
            }
        }

        static void placeships(int player)
        {
            ShowShips(player);

            Console.WriteLine("place a ship (x,y)");
            int x, y;
            do { Console.WriteLine("put x"); }
            while (!int.TryParse(Console.ReadLine(), out x) || x < 0 || x >= xc);
            do { Console.WriteLine("put y"); }
            while (!int.TryParse(Console.ReadLine(), out y) || y < 0 || y >= yc);
            GameArray[player,x, y] = 1;
            //TODO CHECK IF SHIP ALREADY EXIST ON LOCATION/CONDINATEWW AND TTHAT 
        }
       
        }
    }


