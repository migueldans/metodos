using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos
{
    class Program
    {


        //    static void Main(string[] args)
        //    {
        //       // metodo para identificar pares e impares

        //    Console.WriteLine("Introduzca un numero");
        //        int num = Convert.ToInt32(Console.ReadLine());
        //    esPar(num);
        //    Console.ReadLine();

        //    }

        //public static void esPar(int numReceived)
        //{
        //    if (numReceived % 2 == 0)
        //    {
        //        Console.WriteLine("El numero introducido es par");
        //    }
        //    else
        //    {
        //        Console.WriteLine("El numero introducido es impar");
        //    }

        //    Console.ReadLine();
        //}

        ////Escribe una función que escriba “Hola” 3 veces. Llámala desde el programa principal.

        //static void Main(string[] args)
        //{
        //    hello();
        //    Console.ReadLine();
        //}

        //public static void hello()
        //{
        //    for (int i = 0; i < 3; i++)
        //        Console.WriteLine("Hello");
        //}

        //Escribe una función que escriba “Hola” tantas veces como el número que le pasamos de parámetro.
        //Llámala desde el programa principal dos veces, primero con 5 y después con 3.

        //static void Main(string[] args)
        //{
        //    VecesHola(5);
        //    VecesHola(3);
        //}

        //public static void VecesHola (int veces)
        //{
        //    for (int i=0; i<veces; i++)
        //    {
        //        Console.WriteLine("Hola");
        //    }
        //    Console.ReadLine();
        //}


        ////Escribe una función que devuelva el resultado de sumar los dos parámetros que le pasamos.
        ////En el programa principal, pide al usuario 2 números. 
        ////Usa esos 2 números como parámetros de la función y después asigna el valor que devuelve la función a una tercera variable en el programa.
        ////Finalmente, muestra el valor de la variable en la pantalla.

        //static void Main(string[] args)
        //{
        //    double num1, num2;
        //    double divide;

        //    do
        //    {
        //        Console.WriteLine("Escribe un numero");
        //        num1 = Convert.ToDouble(Console.ReadLine());
        //        Console.WriteLine("Escribe un numero");
        //        num2 = Convert.ToDouble(Console.ReadLine());
        //        if (num2 != 0)
        //        {
        //            divide = divideTwoNumbers(num1, num2);
        //            Console.WriteLine(divide);
        //        }
        //        Console.ReadLine();
        //    }
        //    while (num2 != 0);
        //}
        //public static double divideTwoNumbers (double num1, double num2)
        //{
        //return num1 / num2;
        //}

        ////Crea una aplicación que nos calcule el área de un circulo, cuadrado o triangulo. 
        ////Pediremos que figura queremos calcular su área y según lo introducido pedirá los valores necesarios para calcular el área. 
        ////Crea un método por cada figura para calcular cada área, este devolverá un número real. Muestra el resultado por pantalla
        ////Aquí te mostramos que necesita cada figura:
        ////Circulo: (radio^2)*PI
        ////Triangulo: (base * altura) / 2
        ////Cuadrado: lado* lado

        //static void Main(string[] args)

        //{
        //    int shape;
        //    double radius, height, base1, side;

        //    Console.WriteLine("Elija una figura para calcular su area:");
        //    Console.WriteLine("1.circulo");
        //    Console.WriteLine("2.cuadrado");
        //    Console.WriteLine("3.triangulo");
        //    shape = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Has elegido ");
        //    switch (shape)
        //    {
        //        case 1:
        //            Console.WriteLine("1.Circulo");
        //            Console.WriteLine("Introduce el radio del circulo en cm.");
        //            radius = Convert.ToDouble(Console.ReadLine());
        //            CircleArea(radius);
        //            break;
        //        case 2:
        //            Console.WriteLine("2.cuadrado");
        //            Console.WriteLine("Introduce el lado del cuadrado en cm.");
        //            side = Convert.ToDouble(Console.ReadLine());
        //            SquareArea(side);
        //            break;
        //        case 3:
        //            Console.WriteLine("3.rectangulo");
        //            Console.WriteLine("Introduce la base del rectangulo en cm.");
        //            base1 = Convert.ToDouble(Console.ReadLine());
        //            Console.WriteLine("Introduce la altura del rectangulo en cm.");
        //            height = Convert.ToDouble(Console.ReadLine());
        //            RectangleArea(base1, height);
        //            break;
        //    }

        //Console.ReadLine();

        //}

        //public static void CircleArea(double radiusReceived)
        //{
        //    double CircleArea = (Math.Pow(radiusReceived,2) ) * Math.PI;

        //    Console.WriteLine("El area de circulo con radio " + radiusReceived + " es " + CircleArea + " cm2.");

        //    Console.ReadLine();
        //}

        //public static void SquareArea(double sideReceived)
        //{
        //    double SquareArea = sideReceived * sideReceived /2;

        //    Console.WriteLine("El area de cuadrado con lado " + sideReceived + " es " + SquareArea + " cm2.");

        //    Console.ReadLine();
        //}

        //public static void RectangleArea(double base1Received, double heightReceived)
        //{
        //    double RectangleArea = base1Received * heightReceived;

        //    Console.WriteLine("El area del rectangulo con base " + base1Received + " y altura " + heightReceived + " es de " + RectangleArea + " cm2.");

        //    Console.ReadLine();
        //}

        ////Crea una aplicación que nos genere una cantidad de números enteros aleatorios que nosotros le pasaremos por teclado. 
        ////Crea un método donde pasamos como parámetros entre que números queremos que los genere, podemos pedirlas por teclado antes de generar los números. 
        ////Este método devolverá un número entero aleatorio. Muestra estos números por pantalla.

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("¿Cuantas veces quieres generar numeros aleatoriamente?");
        //    int numRnd = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Introduzca numero bajo para generar un numero aleatorio");
        //    int minRnd = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Introduzca numero alto para generar un numero aleatorio");
        //    int maxRnd = Convert.ToInt32(Console.ReadLine());


        //    Num(numRnd, minRnd, maxRnd);
        //    Console.ReadLine();


        //}

        //public static void Num (int numRnd, int minRnd, int maxRnd)
        //{

        //    Random rndm = new Random();
        //    for (int i = 0; i < numRnd; i++)
        //    {
        //        int num = rndm.Next(minRnd, maxRnd);
        //        Console.WriteLine(num);
        //    }
        //}

        //// Crea una aplicación que nos calcule el factorial de un número pedido por teclado, lo realizara mediante un método al que le pasamos el número como parámetro.
        ////Para calcular el factorial, se multiplica los números anteriores hasta llegar a uno. Por ejemplo, si introducimos un 5, realizara esta operación 5*4*3*2*1=120.

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Insert un número para generar su factorial");
        //    int numFact = Convert.ToInt32(Console.ReadLine());
        //    Num(numFact);
        //    Console.ReadLine();

        //}
        //public static void Num(int numFact)
        //{

        //    for (int i = numFact; i > 1;  i--)
        //    {
        //        numFact = numFact *(i-1);

        //    }
        //    Console.WriteLine(numFact);
        //}


        ////Crea una aplicación que nos cuente el número de cifras de un número entero positivo (hay que controlarlo) pedido por teclado.
        ////Crea un método que realice esta acción, pasando el número por parámetro, devolverá el número de cifras.
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Escribe un numero de varias cifras");
        //    int addNumber = Convert.ToInt32(Console.ReadLine());
        //    addNumber(bla);
        //    while (addNumber <=0)
        //    {
        //        Console.WriteLine("Escriba un numero positivo de varias cifras");
        //        Console.ReadLine();
        //    }



        //}
        //public static void bla(int addNumber)
        //{
        //    for (int i=0; i<addNumber.Length;i++)
        //    {

        //    }
        //}

        ////Diseña  un  método  pedirMes().  Solicita  un  número  de  mes  y  valida  que  se  trata  de  un número de mes correcto. Devuelve dicho número de mes. 
        ////Diseña un método pedirAnio(). Recibe como parámetros los límites entre los que debe de estar el año que se debe solicitar por teclado.
        ////Devuelve el año entre dichos límites.Validar que el límite máximo sea mayor que el límite mínimo y en caso contrario, cambiarles el valor.
        ////Diseña un método pedirDia(). Solicita un número de día por teclado, y dado un mes y un año válidos  recibidos por  parámetro, devuelve un  día correcto.
        ////(Nota:  puede llamar  al método esBisiesto)
        ////Crea un nuevo método mostrarSiguienteDia() que recibe un día, un mes y un año válido(estos tres datos forman la fecha actual) y muestra en pantalla 2 fechas: 
        ////la actual y la del día siguiente, a calcular a partir del día actual.
        ////Pruébalo en  un programa  que pida  al usuario  una fecha(pedirDia(), pedirMes(), pedirAnio()) y muestre la fecha del día siguiente.
        ////Ejemplo:  
        ////Fecha actual: 31/12/2011 
        ////Día siguiente: 1/1/2012 

        //static void Main(string[] args)
        //{

            
        //    Console.WriteLine("Introduzca un mes en numero del 1 al 12");
        //    int month = Convert.ToInt32(Console.ReadLine());
        //    month = AskMonth(month);
        //    Console.WriteLine("EL numero del mes es " + month);
        //    Console.ReadLine();

        //    Console.WriteLine("Introduzca un año:");
        //    int year1 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Introduzca otro año:");
        //    int year2 = Convert.ToInt32(Console.ReadLine());

        //    int limMax = Math.Max(year1, year2);
        //    int limMin = Math.Min(year1, year2);
        //    int year = RandomYear(limMin, limMax);
            
        //    Console.WriteLine("El año es " + year);
        //    Console.ReadLine();

        //    Console.WriteLine("Introduzca un día del mes");
        //    int day = Convert.ToInt32(Console.ReadLine());
        //    day = AskDay(day,month,year);
        //    Console.WriteLine("El numero del dia es " + day);
        //    Console.ReadLine();




        
        //}
        //public static int AskDay (int dayReceived,int month,int year)
        //{
        //    while (dayReceived > 1 || dayReceived < 31)
        //    {
        //        if (DateTime.IsLeapYear(year))
        //        {
        //            if (month == 2)
        //            {
        //                if (dayReceived > 29)
        //                {
        //                    Console.WriteLine("Introduzca otro día");
        //                    dayReceived = Convert.ToInt32(Console.ReadLine());
        //                }
        //                return dayReceived;
        //            }
        //            else if (month == 4 || month == 6 || month == 9 || month == 11)
        //            {
        //                if (dayReceived > 30)
        //                {
        //                    Console.WriteLine("Introduzca otro día");
        //                    dayReceived = Convert.ToInt32(Console.ReadLine());
        //                }
        //                return dayReceived;

        //            }
        //            return dayReceived;

        //        }

        //        else
        //        {
        //            if (month == 2)
        //            {
        //                if (dayReceived > 28)
        //                {
        //                    Console.WriteLine("Introduzca otro día");
        //                    dayReceived = Convert.ToInt32(Console.ReadLine());
        //                }
        //                return dayReceived;
        //            }
        //            else if (month == 4 || month == 6 || month == 9 || month == 11)
        //            {
        //                if (dayReceived > 30)
        //                {
        //                    Console.WriteLine("Introduzca otro día");
        //                    dayReceived = Convert.ToInt32(Console.ReadLine());
        //                }
        //                return dayReceived;
        //            }
        //            return dayReceived;
        //        }
                 
                
        //    }
        //    return dayReceived;
        //}
        //public static int RandomYear (int limMin, int limMax)
        //{
        //    Random rnd = new Random();
        //    int RandomYear= rnd.Next(limMin, limMax);
        //    return RandomYear;
        //}

        //public static int AskMonth(int monthReceived)
        //{
        //    //si hiciesemos do while entonces no tendriamos que pedir el mes en el main
        //    while(monthReceived <1 || monthReceived > 12)
        //    {
        //        Console.WriteLine("El mes introducido es incorrecto, introduzca otro.");
        //        monthReceived = Convert.ToInt32(Console.ReadLine());
        //    }
        //    return monthReceived;
        //}

        //+++++++++++++++++++++++++++++++++BIEN HECHO Y TERMINADO++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        static void Main(string[] args)
        {
            int month, year, day, maxYear, minYear;

            //Generamos un mes
            month = AskMonth();

            //Generamos un año
            Console.WriteLine("Introduce un límite mínimo:");
            minYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce un límite máximo:");
            maxYear = Convert.ToInt32(Console.ReadLine());
            year = AskYear(minYear, maxYear);

            //Generamos día
            day = AskDay(month, year);

            //Generamos el día siguiente
            NextDay(day, month, year);


        }
        public static void NextDay(int day, int month, int year)
        {
            Console.WriteLine("Fecha actual: " + day + "/" + month + "/" + year);

            if (DateTime.IsLeapYear(year) && month == 2 && day == 29)
            {
                month++;
                day = 1;

            }
            else if (!DateTime.IsLeapYear(year) && month == 2 && day == 28)
            {
                month++;
                day = 1;
            }
            else if ((month == 4 || month == 6 || month == 9 || month == 11) && day == 30)
            {
                month++;
                day = 1;
            }
            else if ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10) && day == 31)
            {
                month++;
                day = 1;
            }
            else if (month == 12 && day == 31)
            {
                year++;
                month = 1;
                day = 1;
            }
            else
            {
                day++;
            }
            Console.WriteLine("Fecha día siguiente: " + day + "/" + month + "/" + year);
            Console.ReadLine();
        }

        public static int AskDay(int month, int year)
        {
            int day;
            bool correcto = false;
            do
            {
                Console.WriteLine("Introduce un día");
                day = Convert.ToInt32(Console.ReadLine());

                if (DateTime.IsLeapYear(year) && month == 2)
                {
                    if (day > 0 && day < 30)
                    {
                        correcto = true;
                    }
                }
                else if (!DateTime.IsLeapYear(year) && month == 2)
                {

                    if (day > 0 && day < 29)
                    {
                        correcto = true;
                    }
                }
                else if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    if (day > 0 && day < 31)
                    {
                        correcto = true;
                    }
                }
                else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                {
                    if (day > 0 && day < 32)
                    {
                        correcto = true;
                    }
                }

            } while (!correcto);

            return day;
        }


        public static int AskMonth()
        {
            int month;
            do
            {
                Console.WriteLine("Introduce un mes");
                month = Convert.ToInt32(Console.ReadLine());

            } while (month < 1 || month > 12);

            return month;
        }

        public static int AskYear(int minYear, int maxYear)
        {
            int aux, year;
            Random rnd = new Random();

            if (minYear > maxYear)
            {
                //Creo la variable auxiliar para guardar el valor de minYear para que
                //cuando lo cambie no se pierda
                aux = minYear;
                minYear = maxYear;
                maxYear = aux;
                year = rnd.Next(minYear, maxYear + 1);
                return year;
            }
            else
            {
                year = rnd.Next(minYear, maxYear + 1);
                return year;
            }
        }
    }
}










