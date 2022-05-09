using System;

public class ChallengePOO2
{
    public static void Main()
    {
        Persona persona = new Persona();
        //persona.Saludar();

        Estudiante estudiante = new Estudiante();
        estudiante.SetEdad(25);
        estudiante.Saludar();
        estudiante.VerEdad();
        estudiante.Estudiar();

        Profesor profesor = new Profesor();
        profesor.SetEdad(50);
        profesor.Saludar();
        profesor.VerEdad();
        profesor.Explicar();
    }
}

public class Persona
{
    protected int edad;

    public void Saludar()
    {
        Console.WriteLine("hola");
    }

    public void SetEdad(int n)
    {
        edad = n;
    }
}

public class Estudiante : Persona
{
    public void Estudiar()
    {
        Console.WriteLine("estoy estudiando");
    }

    public void VerEdad()
    {
        Console.WriteLine("tengo {0} años" , edad);
    }
}

public class Profesor : Persona
{
    public void VerEdad()
    {
        Console.WriteLine("tengo {0} años", edad);
    }
    public void Explicar()
    {
        Console.WriteLine("y estoy explicando");
    }
}