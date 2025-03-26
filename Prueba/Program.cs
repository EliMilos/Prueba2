// See https://aka.ms/new-console-template for more information
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Hello, World!");
Console.WriteLine("Probando GIT");
class Persona
{
    public int edad; 
    public string name;

    public Persona()
    {
    }

    public Persona(int edad, string name)
    {
        this.edad = edad;
        this.name = name;
    }

    public void Saludar()
    {
        Console.WriteLine($"Hola, mi nombre es {name} y tengo {edad} años.");
    }

}
class Program
{
    static void Main()
    {
        Persona persona1 = new Persona(25, "Adrian");
        persona1.Saludar();
    }
}
