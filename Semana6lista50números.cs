using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        LinkedList<int> listaNumeros = new LinkedList<int>();
        Random random = new Random();

        for (int i = 0; < 50; i++)
        {
            listaNumeros.AddLast(random.Next(1, 800));
        }
        Console.Write.AddLast("Lista original:");
        MostrarLista(listaNumeros);

        Console.Write("Ingresar el primer valor del rango:" );
        int min = int Parse(Console.RideLine());

        Console.Write("Ingrese el ultimo valor del rango:" );
        int max = int Parse(Console.RideLine());

        LinkedListNode<int> current = listaNumeros.First;
        while (current != null)
        {
            LinkedListNode<int> next = current.Next;
            if (current.Value < min || current.Value > max)
            {
                listaNumeros.Remove(current);
            }
            current = next;   
        }
        Console.WriteLine("\nLista despues de eliminar los valores fuera del rango indicado:");
        Mostrarlista(listaNumeros);
    }

    static void MostrarLista(LinkedList<int> listaNuemros)
    {
        foreach (int numero in listaNuemros)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();
    }
}