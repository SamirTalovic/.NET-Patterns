using Iterator.Collection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Iterator
{
    public class HotelIterator : IHotelIterator
    {
        private DreamTravelEveryPerkHotel DreamTravelEveryPerkHotel;
        private int current = 0;
        private int step = 1;

        public HotelIterator(DreamTravelEveryPerkHotel dreamTravelEveryPerkHotel)
        {
            this.DreamTravelEveryPerkHotel = dreamTravelEveryPerkHotel;
        }

        public bool IsDone => current >= DreamTravelEveryPerkHotel.Count;

        public EveryPerkHotel? First()
        {
            current = 0;
            return DreamTravelEveryPerkHotel[current] as EveryPerkHotel;
        }

        public EveryPerkHotel? Next()
        {
            current += step;
            if (!IsDone)
                return DreamTravelEveryPerkHotel[current] as EveryPerkHotel;
            else
                return null;
        }

        public EveryPerkHotel CurrentHotel=> DreamTravelEveryPerkHotel[current] as EveryPerkHotel;
    }
}
