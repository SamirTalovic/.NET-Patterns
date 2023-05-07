using Builder.Builders;

namespace Builder.Directors
{
    /// <summary>
    /// The Director class
    /// </summary>
    public class AssemblyLine
    {
        public void Assemble(AgencyBuilder builder)
        {
            builder.AddWayoftravel();
            builder.AddDestination();
            builder.AddPrice();
            builder.AddDuration();
            builder.AddHotel();
            builder.AddLunch();
        }
    }
}
