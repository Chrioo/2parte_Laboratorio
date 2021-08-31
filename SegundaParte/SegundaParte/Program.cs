using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaParte
{
    class Program
    {
        static void Main(string[] args)
        {
            Clspersona clsPersona = new Clspersona();
            NCLsPersona nclspersona = new NCLsPersona();


            Console.WriteLine("escriba su nombre");
            string nombre = (Console.ReadLine());


            Console.WriteLine("escriba su genero F_______ M");
            string sexo = (Console.ReadLine());




            Console.WriteLine("Ingre su edad porfavor");
            int edad = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Escriba su peso");
            Double peso = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Escriba su altura ");
            Double altura = Convert.ToDouble(Console.ReadLine());

            Clspersona persona = new Clspersona(nombre, edad, peso, altura);

            Clspersona persona1 = new Clspersona(nombre, edad, sexo);

            Console.WriteLine(nclspersona.CalcularIMC(persona));

            Console.WriteLine(nclspersona.EsMayorDeEdad(persona1));

            Console.WriteLine(persona.ToString());
            Console.ReadLine();





        }
    }

    internal class NCLsPersona
    {
        internal bool CalcularIMC(Clspersona persona)
        {
            throw new NotImplementedException();
        }

        internal bool EsMayorDeEdad(Clspersona persona1)
        {
            throw new NotImplementedException();
        }
    }

    internal class Clspersona
    {
        public Clspersona()
        {
        }

        public Clspersona(string nombre, int edad, string sexo)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public Clspersona(string nombre, int edad, double peso, double altura)
        {
            Nombre = nombre;
            Edad = edad;
            Peso = peso;
            Altura = altura;
        }

        public string Nombre { get; }
        public int Edad { get; }
        public double Peso { get; }
        public double Altura { get; }
    }
}
