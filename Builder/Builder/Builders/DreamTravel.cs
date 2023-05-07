using Builder.Products;

namespace Builder.Builders
{
    /// <summary>
    /// A Concrete builder class
    /// </summary>
    public class DreamTravel : AgencyBuilder
    {
        public DreamTravel()
        {
            agency = new Agency("DreamTravel");
        }

        public override void AddWayoftravel()
        {
            agency["wayoftravel"] = "Plane";
        }

        public override void AddDestination()
        {
            agency["destination"] = "Zakintos";
        }

        public override void AddPrice()
        {
            agency["price"] = "240$";
        }

        public override void AddDuration()
        {
            agency["duration"] = "9 nights";
        }

        public override void AddHotel()
        {
            agency["hotel"] = "Plaza 5 stars";
        }

        public override void AddLunch()
        {
            agency["lunch"] = "Breakfast and Lunch";
        }
    }
}
