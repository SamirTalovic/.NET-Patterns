using Iterator.Iterator;

namespace Iterator.Collection
{
    public class DreamTravelEveryPerkHotel : IPansionCollection
    {
        private List<EveryPerkHotel> items = new();

        public IHotelIterator CreateIterator()
        {
            return new HotelIterator(this);
        }

        public int Count
        {
            get { return items.Count; }
        }

        public void Add(params string[] hotels)
        {
            foreach(string hotel in hotels)
                items.Add(new EveryPerkHotel(hotel));
        }

        public object this[int index]
        {
            get { return items[index]; }
            set { items.Add((EveryPerkHotel)value); }
        }
    }
}
