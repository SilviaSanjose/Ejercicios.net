using System;
using System.Collections.Generic;


//Ejercicios POO de: https://www.exercisescsharp.com/es/
#region Crear clase y 3 objetos de la misma 
public class Persona
{
	public string Nombre { get; set; } //variable nombre con su getter and setter
    public string Apellido { get; set; }
    
    public Persona(string nom)
    {
        Nombre = nom;
    }
    public override string ToString()
    {
        return $"Hola {Nombre} {Apellido}";
    } 
    ~Persona()
    {
        //Nombre = "";
        Nombre = string.Empty;
    }
    
}
public class CrearInstancias
{
    public static void miObjeto()
    {
        //List<Persona> nombres = new List<Persona>();  //creo mi lista tipo persona
        Persona[] nombres = new Persona[3];  //creo array de tipo Persona

        for (int i = 0; i < 3; i++)
        {
            //nombres.Add(new Persona() { nombre = Console.ReadLine()});  //añado cada nombre a mi lista
            //*cada elemento del array es un objeto Persona y con el setter se le da el valor al apellido, y el nombre que se pasa en el constructor
            nombres[i] = new Persona(Console.ReadLine()) { Apellido = Console.ReadLine() };
        }

        foreach (Persona n in nombres)
        {
            Console.WriteLine(n.ToString());
        }

    }

    public static void EstudianteProfesor()
    {
        Persona persona1 = new Persona("Silvia");
    }
}
#endregion 

#region Clase Estudiante y Profesor
public class Persona2
{
    public int edad;
    public void Saludar()
    {
        Console.WriteLine("Estoy saludando");
    }
    public void SetEdad(int e)
    {
        edad = e;
    }
}
public class Estudiante : Persona2
{
    public void Estudiar()
    {
        Console.WriteLine("Estoy estudiando");
    }
    public void VerEdad()
    {
        Console.WriteLine($"Mi edad es {edad} años");
    }
}
public class Profesor : Persona2
{
    public void Explicar()
    {
        Console.WriteLine("Estoy Explicando");
    }
}

public class InstanciarEstudianteProfesor
{
    public static void MostrarAcciones()
    {
        Persona2 persona1 = new Persona2();
        persona1.Saludar();

        Estudiante estudiante1 = new Estudiante();
        estudiante1.SetEdad(23);
        estudiante1.Saludar();
        estudiante1.VerEdad();
        estudiante1.Estudiar();

        Profesor profesor1 = new Profesor();
        profesor1.SetEdad(44);
        profesor1.Saludar();
        profesor1.Explicar();

    }
}
#endregion

#region Albúm de fotos
public class AlbumFoto
{
    protected int numPaginas;

    public AlbumFoto()
    {
        numPaginas = 16;
    }
    public AlbumFoto(int p)
    {
        numPaginas = p;
    }
    public void GetNumeroPaginas()
    {
        Console.WriteLine($"Número de páginas: {numPaginas}");
    }
}
public class SuperAlbumFotos : AlbumFoto
{
    public SuperAlbumFotos()
    {
        numPaginas = 64;
    }
}
public class Albumtest
{
    public static void CrearAlbum()
    {
        AlbumFoto primerAlbum = new AlbumFoto();
        primerAlbum.GetNumeroPaginas();

        AlbumFoto segundoAlbum = new AlbumFoto(24);
        segundoAlbum.GetNumeroPaginas();

        SuperAlbumFotos granAlbum = new SuperAlbumFotos();
        granAlbum.GetNumeroPaginas();
    }
}
#endregion

#region Clase Estudiante y Profesor con constructor (Herencia de clases)
public class Persona3
{
    protected string Nombre2 { get; set; }

    public Persona3()
    {
    }
    public Persona3(string nombre)
    {
        Nombre2 = nombre;
    }
    public override string ToString()
    {
        return $"hola {Nombre2}";
    }
}
public class Estudiante3 : Persona3
{
    public Estudiante3(string nombre) //: base(nombre)
    {
        Nombre2 = nombre;
    }
    public void Estudiar()
    {
        Console.WriteLine("Estoy estudiando");
    }
}
public class Profesor3 : Persona3
{
    public Profesor3(string nombre) //: base(nombre)
    {
        Nombre2 = nombre;
    }
    public void Explicar()
    {
        Console.WriteLine("Explicando");
    }
}
public class InstanciarEstudianteProfesorConstructor
{
    public static void MostrarAcciones2()
    {
        Persona3[] mispersonas = new Persona3[3];
        for (int m=0; m<3; m++){
            if (m <2 ) 
            {
                mispersonas[m] = new Estudiante3("estudiante " + Console.ReadLine());
            }
            else 
            {
                mispersonas[m] = new Profesor3("profesor " + Console.ReadLine());
            }
        }

        foreach (Persona3 p in mispersonas)
        {
            Type t = p.GetType();
            if (t.Equals(typeof(Estudiante3)))
            {
                Console.WriteLine(p);
                ((Estudiante3)p).Estudiar();  //es necesario indicar el tipo de objeto
            }else
            {
                Console.WriteLine(p);
                ((Profesor3)p).Explicar();
            }

        }
        


    }
}
#endregion

#region  Interfaces
public class Interfaces { 
    public interface IVehiculo
    {
        public void Conducir();
   
        public bool Repostar(int l);
    
    }
    public class Coche : IVehiculo
    {
        protected int Gasolina { get; set; }
        public Coche(int g)
        {
            Gasolina = g;
        }
        public void Conducir()
        {
            //throw new NotImplementedException();
            if(Gasolina > 0)
            {
                Console.WriteLine("Coche conduciendo");
            }
            else
            {
                Console.WriteLine("No tengo gasolina... :-(");
            }
        }
        public bool Repostar(int l)
        {
            // throw new NotImplementedException();
            Gasolina = l;
            return true;
        }
    }
    public static void InterfazCoche()
    {
        Coche miCoche = new Coche(0);
        miCoche.Conducir();
        Console.WriteLine("¿Cuántos litros vas a respostar");
        int rellenar = Convert.ToInt32(Console.ReadLine());
        miCoche.Repostar(rellenar);
        miCoche.Conducir();

    }
}
#endregion