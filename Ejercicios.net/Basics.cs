using System;
using System.Collections.Generic;
using System.Linq;

//Ejercicios de https://csharpexercises.com/
public class Basics
{
  
    #region  Basics  
    //Recibir 3 nº, sumar los 2 primeros y multiplicar por el segundo.
    public static void AddNumber(double a, double b, double c)
	{
		Console.WriteLine("1)Resultado: "+ (a + b) * c);
	}

    //Convertir de Celsius a Fahrenheit
    public static void CelFar()
    {
        //double cels = Convert.ToDouble(Console.ReadLine());
        double cels = 37;
        if (cels < -271.15)
        {
            Console.WriteLine("2)Temperatura no valida");
        }
        else
        {
            double fH = (cels * 9 / 5) + 32;
            Console.WriteLine($"2)Convertir grados: {cels}Cº son {fH}Fº");
        }
    }

    //Operaciones básicas
    public static void Operation(double a, double b)
    {
        var sum = a + b;
        var rest = a - b;
        var mult = a * b;
        var div = a / b;
        string t = b == 0 ? "No se puede dividir por 0" : div.ToString();

        Console.WriteLine($"3)Operaciones básicas:  Suma:{sum}  > Resta:{rest}  > Multiplicación:{mult}  > División: {t}");
    }

    //Comprobar si dos operaciones dan el mismo resultado
    public static bool CheckResult(double a, double b)
    {
        return a == b;
    }

    //Modulo del primer número entre el segundo, y entre el tercero
    public static void Module(double a, double b, double c)
    {
        Console.WriteLine("5)Módulo: " +(a % b)%c);
        
    }

    //calcular cubo
    public static void Cube(double a)
    {
        Console.WriteLine("5)Cubo: " +Math.Pow(a, 3));
    }

    //Intercambiar numeros
    public static void Swap(int a, int b)
    {
        int newA = b;
        int newB = a;
        Console.WriteLine($"6)Intercambio: Before a = {a}, b = {b};  After a ={newA}, b={newB}");
    }
    #endregion

    #region Loops

    //arbol de navidad
    public static void Tree()
    {
        Console.WriteLine("11)Arbol de Navidad");
        for (int i = 0; i < 2; i++)  //dos capas del árbol
        {
            for (int t = 0; t < 8; t += 2) //salto de dos para poder centrar los * que sean impares los * pintados
            {
                for (var k = 0; k < (8 - t) / 2; k++)  //espacios para centrar
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= t; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");//salto de línea para cada linea de ramas
            }
            if (i == 1)
                Console.WriteLine("    |");
        }
    }
    #endregion

    #region Strings
    
    //comprimir string
    public static string Compress(string str)
    {
        Console.WriteLine("12)Comprimir String");
        var compress = str[0];
        int contador = 0;
        string miString = "";

        foreach (var c in str)
        {
            if (c == compress)
            {
                contador++;
            }
            else
            {
                miString += $"{compress}{contador}";
                compress = c;
                contador = 1;
            }
        }
        miString += $"{compress}{contador}";
        return miString;
    }
    #endregion

    #region LINQ
    //Rango de numero
    public static void Linq()
    {
        Console.WriteLine("1)Uso de Link");
        List<int> list = new List<int> { 67, 92, 153, 15 };
        var elementosmin = list.Where(x => x > 30 && x < 100);

        foreach (var e in elementosmin)
        {
            Console.Write($"{e} ");
        }
    }
    #endregion
}
