internal class Program
{
    private static int colorIndex = 0;
    private static ConsoleColor[] colores = new ConsoleColor[]
    {
        ConsoleColor.Green, ConsoleColor.Yellow, ConsoleColor.Red, ConsoleColor.Blue, ConsoleColor.Cyan
    };
    private static void Main(string[] args)
    {
        int opcion;
        bool continuar = true;
        do
        {
            Console.Clear();
            Console.WriteLine("     Menu 1"+System.Environment.NewLine);
            Console.WriteLine("1. Dibujar rectangulos");
            Console.WriteLine("2. Dibujar espiral");
            Console.WriteLine("0. Salir");
            Console.WriteLine("Escribe una opción: ");
            //opcion = Convert.ToInt32(Console.ReadLine());
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Rectangulos();
                        break;
                    case 2:
                        Console.Clear();
                        Espiral();
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("BYE BYE");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opción no permitida");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ingresa una opción válida");
            }
            Console.ReadKey();
        } while (continuar != false);
       
    }
    //Metodo para hacer los rectangulos
    private static void Rectangulos()
    {
        int anchoPantalla = Console.WindowWidth;
        int altoPantalla = Console.WindowHeight;
        int posX = anchoPantalla / 2;
        int posY = altoPantalla / 2;
        int limite;
        Console.SetCursorPosition(posX, posY); //columnas    filas
        //Solo una linea VERDE
        for (int i = posX; i < (posX+4); i++)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            System.Threading.Thread.Sleep(100);
            Console.SetCursorPosition(i, posY);
            Console.Write("*");
        }
        //Fin de la linea VERDE
        //Inicio primera vuelta ROJO
        posX = posX - 5; //columna
        posY = posY - 2; //fila
        for (int g1 = posX; g1 < (posX + 13); g1++)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Threading.Thread.Sleep(100);
            Console.SetCursorPosition(g1, posY);
            Console.Write("*");
        }
        posX = 68;//columna
        posY = 13;//fila
        for (int g2 = posX; g2 < (posX + 4); g2++)
        {
            System.Threading.Thread.Sleep(100);
            Console.SetCursorPosition(posX, posY++);
            Console.Write("*");
        }
        posX = 68;//columna
        posY = 17;//fila
        for (int g3 = 0 ; g3 < 13; g3++)
        {
            limite = posX - g3;
            if (limite < 0) break;
            System.Threading.Thread.Sleep(100);
            Console.SetCursorPosition(limite, posY);
            Console.Write("*");
        }
        posX = 55; //columna
        posY = 17; //fila 
        for (int g4 = posX; g4 < (posX + 4); g4++)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Threading.Thread.Sleep(100);
            Console.SetCursorPosition(posX, posY--); 
            Console.Write("*");
        }
        //Fin primera vuelta ROJO
        //Inicio segunda vuelta AZUL
        posX = 51; //columna
        posY = 11; //fila
        for (int g5 = posX;g5 < (posX + 21); g5++)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Threading.Thread.Sleep(100);
            Console.SetCursorPosition(g5, posY);
            Console.Write("*");
        }
        posX = 72; //columna
        posY = 11; //fila
        for(int g6 = posX; g6 < (posX + 8) ; g6++)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Threading.Thread.Sleep(100);
            Console.SetCursorPosition(posX, posY++);
            Console.Write("*");
        }
        posX = 72; //columna
        posY = 19; //fila
        for (int g7 = 0; g7 < 22 ; g7++)
        {
            limite = posX - g7;
            if (limite < 0) break;
            System.Threading.Thread.Sleep(100);
            Console.SetCursorPosition(limite, posY);
            Console.Write("*");
        }
        posX = 51; //columna
        posY = 19; //fila
        for (int g8 = posX; g8 < (posX + 8); g8++)
        {
            System.Threading.Thread.Sleep(100);
            Console.SetCursorPosition(posX, posY--);
            Console.Write("*");
        }
        // Fin segunda vuelta AZUL
        //inicio tercera vuelta AMARILLO
        posX = 46; //columna
        posY = 9; //fila
        for (int g9 = posX; g9 < (posX + 30); g9++) 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Threading.Thread.Sleep(100);
            Console.SetCursorPosition(g9, posY);
            Console.Write("*");
        }
        posX = 76; //columna
        posY = 9; //fila
        for (int g10 = posX; g10 < (posX + 12) ; g10++)
        {
            System.Threading.Thread.Sleep(100);
            Console.SetCursorPosition(posX, posY++);
            Console.Write("*");
        }
        posX = 76;
        posY = 21;
        for (int g11 = 0; g11 < 30 ; g11++)
        {
            limite = posX - g11;
            if (limite < 0) break;
            System.Threading.Thread.Sleep(100);
            Console.SetCursorPosition(limite,posY);
            Console.Write("*");
        }
        posX = 46;
        posY = 21;
        for (int g12 = posX ; g12 < (posX + 12); g12++)
        {
            System.Threading.Thread.Sleep(100);
            Console.SetCursorPosition(posX, posY--);
            Console.Write("*");
        }
        //Fin tercera vuelta AMRILLO
        //Inicio ultima vuelta MAGENTA
        posX = 42;
        posY = 7;
        for (int g13 = posX ;g13 < (posX + 38); g13++)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            System.Threading.Thread.Sleep(100);
            Console.SetCursorPosition(g13, posY);
            Console.Write("*");
        }
        posX = 80; //columna  
        posY = 7; //fila
        for (int g14 = posX; g14 < (posX + 17); g14++)
        {
            System.Threading.Thread.Sleep(100);
            Console.SetCursorPosition(posX, posY++);
            Console.Write("*");
        }
        posX = 80;
        posY = 23;
        for (int g15 = 0; g15 < 38 ; g15++)
        {
            limite = posX - g15;
            if (limite < 0) break;
            System.Threading.Thread.Sleep(100);
            Console.SetCursorPosition(limite,posY);
            Console.Write("*");
        }
        posX = 42;
        posY = 23;
        for (int g16 = posX; g16 < (posX + 17); g16++)
        {
            System.Threading.Thread.Sleep(100);
            Console.SetCursorPosition(posX, posY--);
            Console.Write("*");
        }
        //Fin ultima vuleta MAGENTA
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(3,26);
        Console.WriteLine("\nPresiona Enter para regresar al menú");
    }

    //Metodo para hacer la espiral

    public static ConsoleColor siguienteColor()
    {
        ConsoleColor color = colores[colorIndex];
        colorIndex = (colorIndex + 1) % colores.Length; // Ciclo circular entre los colores
        return color;
    }

    private static void Espiral()
    {
        int anchoPantalla = Console.WindowWidth / 2;
        int altoPantalla = Console.WindowHeight / 2;
        int posX = 5; // columna inicial
        int posY = 1; // fila inicial
        int giros = 5;
        int girosCompletados = 0; // Contador de giros

        Console.SetCursorPosition(anchoPantalla + posX, altoPantalla);

        do
        {
            for (int columna = 0; columna <= posX; columna++)
            {
                Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
                Console.ForegroundColor = siguienteColor();
                Console.Write("*");
                Thread.Sleep(100);
            }
            for (int fila = 0; fila < posY; fila++)
            {
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop - 1);
                Console.ForegroundColor = siguienteColor();
                Console.Write("*");
                Thread.Sleep(100);
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop - 1);
            posX += 5;
            posY += 2;

            for (int columna = 0; columna < posX; columna++)
            {
                Console.ForegroundColor = siguienteColor();
                Console.Write("*");
                Thread.Sleep(100);
            }
            for (int fila = 0; fila < posY; fila++)
            {
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop + 1);
                Console.ForegroundColor = siguienteColor();
                Console.Write("*");
                Thread.Sleep(100);
            }
            Console.SetCursorPosition(Console.CursorLeft + 1, Console.CursorTop + 1);
            posX += 3;
            posY += 2;
            girosCompletados++;
        } while (girosCompletados < giros); // Controla la cantidad de giros

        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(3, 26);
        Console.WriteLine("\nPresiona Enter para regresar al menú");

    }
}