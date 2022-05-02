using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Pair_Programming_Dia1
{
    //Hacer una aplicacion que le pida al usuario una lista de 10 numeros enteros y que el programa los divida en dos listas, una de numeros pares y otro de impares
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            Console.WriteLine("1_Ej1");
            Console.WriteLine("2_Ej2");
            option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    int[] arrayUsuario = new int[10];
                    int[] arrayPar = new int[10];
                    int[] arrayImpar = new int[10];
                    int p = 0, j = 0; //recorre arrays par e impar

                    //cargo array por teclado
                    Console.WriteLine("Introduzca 10 numeros en su lista. ");
                    for (int i = 0; i < arrayUsuario.Length; i++)
                    {
                        Console.Write("Numero " + i + ": ");
                        arrayUsuario[i] = Int32.Parse(Console.ReadLine());
                    }

                    //ordeno numeros en sus respectivos arrays
                    for (int i = 0; i < arrayUsuario.Length; i++)
                    {
                        if (arrayUsuario[i] % 2 == 0)
                        {
                            arrayPar[p] = arrayUsuario[i];
                            p++;
                        }
                        else
                        {
                            arrayImpar[j] = arrayUsuario[i];
                            j++;
                        }
                    }
                    //muestro array par
                    for (int i = 0; i < arrayPar.Length; i++)
                    {
                        Console.Write("Array par: " + arrayPar[i] + ", ");
                    }
                    //muestro array impar
                    for (int i = 0; i < arrayPar.Length; i++)
                    {
                        Console.Write("Array impar: " + arrayImpar[i] + ", ");
                    }
                    Console.ReadKey();

                    break;
                case 2:
                    //Crear una matriz de numeros enteros de 2 columnas 4 filas, luego intercambiar las comlumnas

                    int[,] matriz = new int[4, 2];
                    //cargo la matriz por teclado
                    for (int i = 0; i < 4; i++)
                    {
                        for (j = 0; j < 2; j++)
                        {
                            Console.Write("Ingrese posicion [" + (i + 1) + "," + (j + 1) + "]: ");
                            string linea;
                            linea = Console.ReadLine();
                            matriz[i, j] = int.Parse(linea);
                        }
                    }
                    //muestro la matriz original
                    Console.WriteLine("Matriz original.");
                    for (int i = 0; i < 4; i++)
                    {
                        for (j = 0; j < 2; j++)
                        {
                            Console.Write(matriz[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.ReadKey();

                    int aux = 0;
                    //invierto las columnas
                    for (int i = 0; i < 4; i++)
                    {
                        for (j = 0; j < 1; j++)
                        {
                            aux = matriz[i, j];
                            matriz[i,j] = matriz[i,j+1];
                            matriz[i, j+1] = aux;
                        }
                    }
                    Console.WriteLine("Matriz con columnas invertidas.");
                    //muestro la matriz invertida
                    for(int i = 0; i < 4; i++)
                    {
                        for (j = 0; j < 2; j++)
                        {
                            Console.Write(matriz[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.ReadKey();

                    break;
            }

        }

            }
          
}

