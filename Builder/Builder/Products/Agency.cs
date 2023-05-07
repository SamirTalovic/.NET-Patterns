namespace Builder.Products
{
    /// <summary>
    /// The Product class
    /// </summary>
    public class Agency
    {
        private readonly string agencyName;
        private readonly Dictionary<string, string> desc =
            new();

        public Agency(string agencyName)
        {
            this.agencyName = agencyName;
        }

        // Indexer
        public string this[string key]
        {
            get { return desc[key]; }
            set { desc[key] = value; }
        }

        public void Display()
        {
            Console.WriteLine("\n----------------------------");
            Console.WriteLine($"Name: {agencyName}");

            Console.WriteLine($" Wayoftravel: {desc["wayoftravel"]}");
            Console.WriteLine($" Destination: {desc["destination"]}");
            Console.WriteLine($" Price: {desc["price"]}");
            Console.WriteLine($" Duration: {desc["duration"]}");
            Console.WriteLine($" Hotel: {desc["hotel"]}");
            Console.WriteLine($" Lunch: {desc["lunch"]}");
        }
    }
}
