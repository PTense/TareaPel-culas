using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
            private string titulo;
            private int año;
            private string pais;
            private string director;
            private List<Actor> actores = new List<Actor>();

        //Constructores
        public Pelicula(){}
        public Pelicula(string titulo, int año)
        {
            this.titulo=titulo;
            this.año=año;
        }
                
                
                
        //Métodos
        public string GetTitulo(){return titulo;}
        public void SetTitulo(string title){titulo=title;}
        
        public int GetAño(){return año;}
        public void SetAño(int year){año=year;}
        public string GetPais(){return pais;}
        public void SetPais(string cty){pais=cty;}
        public string GetDirector(){return director;}
        public void SetDirector(string dir){director=dir;}
     
        
        
        public void Imprime()
        {
          //Console.WriteLine($"{titulo} ({año})");
            Console.WriteLine($"{titulo} ({año}");

        }
        
        public void AgregaActor(Actor actor)
        {
            actores.Add(actor);
        }
        public void ImprimeActores()
        {
            foreach (Actor persona in actores)
            {
                Console.WriteLine($"{persona.GetNombre()} ({persona.GetAño()})");
            }

        }
    }

    public class Actor
    {
        //Propiedades
        string nombre;
        int año;

        //Constructores
        public Actor(){}
        public Actor(string nombre, int año)
        {
            this.nombre = nombre;
            this.año = año;
        }

        //Métodos 
        public string GetNombre(){return nombre;}
        public void SetNombre(string name){nombre=name;}
        public int GetAño(){return año;}
        public void SetAño(int year){año=year;}
        
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
            
            List<Pelicula> peliculas = new List<Pelicula>();
            peliculas.Add(new Pelicula("Ratatouille", 2007));
            peliculas.Add(new Pelicula("Kung Fu Panda", 2008));
            peliculas.Add(new Pelicula("Whiplash", 2014));
            peliculas.Add(new Pelicula("Fight Club", 1999));
            peliculas.Add(new Pelicula("Interestellar", 2014));
            
            foreach(Pelicula film in peliculas)
            {
                film.Imprime();
            }
            
            p1.AgregaActor(new Actor("Michelle Yeoh", 1962));
            p1.AgregaActor(new Actor("Ke Huy Quan", 1971));
            p1.ImprimeActores();

            p2.AgregaActor(new Actor("Choi Woo-shik", 1990));
            p2.AgregaActor(new Actor("Cho Yeo-jeong", 1981));
            p2.ImprimeActores();
                
            
        }
    
     }
}