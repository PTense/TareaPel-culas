using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
            private String titulo;
            private int16 año;
            private String país;
            private String director;
        private List<Actor> actores = new List<Actor>();

        //Constructores
        public Pelicula()
        public Pelicula(string titulo, int16 año)
        {
            this.titulo=titulo;
            this.año=año;
                
                
                
        //Métodos
        public string GetTitulo(){return titulo;}
        public void SetTitulo(string title){titulo=title}
     
        public void Imprime()
        {
     //       Console.WriteLine($"{titulo} ({año})");
            Console.WriteLine($"{titulo} ({año}");

        }


    }

    public class Actor
    {
        //Propiedades

        //Constructores


        //Métodos 
        public void Imprime()
        {
            Console.WriteLine($"{Nombre} ({Año})");
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {


        static void Main(string[] args)
        {
    
            Pelicula p1 = new Pelicula();
            p1.SetTitulo("Everything Everywhere All at Once");
            p1.SetAño(2022);
            Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetAño());
            
            Pelicula p2 = new Pelicula();
            p2.SetTitulo("Parasyte");
            p2.SetAño(2019);
            Console.WriteLine("{0}({1})", p2.GetTitulo(), p2.GetAño());
            
        }
    }
}
