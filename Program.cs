// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
internal class Program
{
    private static void Main(string[] args)
    {
     
        Console.WriteLine("Tacos");
       var tacos = new Tacos();
       Console.WriteLine($"El precio del taco es : {Tacos.CalcularTotalPrecio()}");
       var pollo = new pollo(orden:Tacos);
         Console.WriteLine("Burrito");
       var tacos = new Tacos();
       Console.WriteLine($"El precio del brrito es : {Burritos.CalcularTotalPrecio()}");
       var chile = new Chile(orden: Burritos);
       
    }
}