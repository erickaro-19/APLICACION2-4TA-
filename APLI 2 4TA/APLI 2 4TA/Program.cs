using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace Progra_Agenda_Virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elige una opcion:");
            Console.WriteLine("1 - Crear");
            Console.WriteLine("2 - Editar");
            Console.WriteLine("3 - Mostrar");
            Console.WriteLine("4 - Salir");
            string op = Console.ReadLine();
            switch (op)
            {
                case ("1"):
                    Console.Clear();
                    Nuevo(); break;
                case ("2"):
                    Console.Clear();
                    Editar(); break;
                case ("3"):
                    Console.Clear();
                    Leer(); break;
                case ("4"):
                    Console.Clear();
                    Fin(); break;
            }
        }
        static void Nuevo()
        {
            StreamWriter archivo;
            string nombre;
            Console.WriteLine("colocael nombre del archivo.");
            nombre = Console.ReadLine();
            archivo = File.CreateText(nombre + ".txt");
        }
        static void Editar()
        {
            StreamWriter edit;
            string nombre, texto;
            Console.WriteLine("el nombre del archivo a editar.");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingresa texto");
            texto = Console.ReadLine();
            edit = File.AppendText(nombre + ".txt");
            edit.WriteLine(texto);
            edit.Close();
        }
        static void Leer()
        {
            TextReader Leer;
            string nombre, texto;
            Console.WriteLine("Que archivo quieres visualizar?");
            nombre = Console.ReadLine();
            Console.WriteLine("");
            Leer = File.OpenText(nombre + ".txt");
            texto = Leer.ReadToEnd();
            Console.WriteLine(texto);
            Leer.Close();
            Console.ReadKey();
        }
        static void Fin() { return; }
    }
}