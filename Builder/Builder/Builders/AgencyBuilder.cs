using Builder.Products;


namespace Builder.Builders
{
    /// <summary>
    /// The Builder abstract class
    /// </summary>
    public abstract class AgencyBuilder
    {
        protected Agency agency;

        // Get the agency instance
        public Agency Agency
        {
            get { return agency; }
        }

        public abstract void AddWayoftravel();
        public abstract void AddDestination();
        public abstract void AddPrice();
        public abstract void AddDuration();
        public abstract void AddHotel();
        public abstract void AddLunch();
    }
}
