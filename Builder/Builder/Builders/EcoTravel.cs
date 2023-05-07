using Builder.Products;

namespace Builder.Builders
{
    /// <summary>
    /// A Concrete builder class
    /// </summary>
    public class EcoTravel : AgencyBuilder
    {
        public EcoTravel()
        {
            agency = new Agency ("EcoTravel");
        }

        public override void AddWayoftravel()
        {
            agency["wayoftravel"] = "Plane";
        }

        public override void AddDestination()
        {
            agency["destination"] = "Larikis";
        }

        public override void AddPrice()
        {
            agency["price"] = "320$";
        }

        public override void AddDuration()
        {
            agency["duration"] = "11 nights";
        }

        public override void AddHotel()
        {
            agency["hotel"] = "Mikos 5 stars";
        }

        public override void AddLunch()
        {
            agency["lunch"] = "Breakfast";
        }
    }
}
