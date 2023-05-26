using Iterator.Collection;

namespace Iterator.Iterator
{
    public interface IHotelIterator
    {
        public EveryPerkHotel? First();
        public EveryPerkHotel? Next();
        public bool IsDone { get; }
        public EveryPerkHotel CurrentHotel { get; }
    }
}
