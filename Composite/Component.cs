namespace Composite
{
    /// <summary>
    /// Component abstract class
    /// </summary>
    public abstract class Component
    {
        public int Prijavljeni { get; set; }

        public List<Component> Agency { get; set; }

        public Component(int hitPoints)
        {
            Prijavljeni = hitPoints;
            Agency = new List<Component>();
        }

        /// <summary>
        /// Return all available flavors and their hitpoints
        /// </summary>
        public void DisplayHitPoints()
        {
            foreach(var agent in this.Agency)
            {
                agent.DisplayHitPoints();
                this.Prijavljeni += agent.Prijavljeni;
            }

            Console.WriteLine($"{this.GetType().Name}: {this.Prijavljeni} prijavljenih.");
        }
    }
}
