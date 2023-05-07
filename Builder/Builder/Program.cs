using Builder.Builders;
using Builder.Directors;

public class Demo
{
    static void Main(string[] args)
    {
        AgencyBuilder builder;

        // Create a pizza assembly line
        AssemblyLine shop = new AssemblyLine();

        // Construct and display pizzas
        builder = new EcoTravel();
        shop.Assemble(builder);
        builder.Agency.Display();

        builder = new DreamTravel();
        shop.Assemble(builder);
        builder.Agency.Display();

        // Wait for user
        Console.ReadKey();
    }
}

