// See https://aka.ms/new-console-template for more information
using System.Timers;

int nombres=0, nombre, edad,re;
string[] canciones = new string[5];
for (int i = 0; i < 5; i++) // 2
{
    Console.WriteLine("Ingrese nombre de la cancion");
    canciones [i] = Console.ReadLine();
}
 while (nombres<5) //1
 {
    Console.WriteLine("Nombre: " + canciones[nombres]);
    nombres++;
 }
for (int j = 0; j < 5; j++) // 4
{
    Console.WriteLine("Ingresar nombre de persona "); //3
    int.Parse(Console.ReadLine());
    Console.WriteLine("Ingresar edad de persona ");
    int.Parse(Console.ReadLine());
}
int[] v1 = new int[5]; //5
int[] v2 = new int[5];
int[] resultado = new int[5];
for (int k = 0; k < 5; k++) 
{
    Console.WriteLine("Ingresar numero a vector 1 ");
    v1[k] = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingresar numero a vector 2 ");
    v2[k] = int.Parse(Console.ReadLine());

    resultado[k] = re = v1[k] + v2[k];
}
for (int l = 0; l < 5; l++)
{
    Console.WriteLine("El resultado es: ", resultado[l]);
}







