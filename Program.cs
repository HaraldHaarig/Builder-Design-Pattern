namespace BuilderDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HausBuilder builder = new HausBuilder();
            Director director = new Director(builder);

            // Familienhaus bauen
            director.BuildFamilienhaus();
            Haus familienhaus = director.GetHaus();
            Console.WriteLine(familienhaus.ToString);

            // Villa bauen
            builder = new HausBuilder(); // Reset des Builders
            director.BuildVilla();
            Haus villa = director.GetHaus();
            Console.WriteLine(villa);
        }
    }
}
