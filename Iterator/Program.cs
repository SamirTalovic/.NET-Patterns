using Iterator.Collection;
using Iterator.Iterator;

DreamTravelEveryPerkHotel hotelBox = new();
Console.WriteLine("DreamTravel nudi:");
hotelBox.Add("Doručak premium,\nRučak minimum,\nVečera uz doplatu,\nBazen,\nSauna,\nHamam,\nPremium usluga,\nOsoblje dostupno 24h,\nTeretana, \nLezaljke,\nDostupna igraonica");

HotelIterator iterator = (HotelIterator)hotelBox.CreateIterator();

for(EveryPerkHotel item = iterator.First();
    !iterator.IsDone;
    item = iterator.Next())
{
    Console.WriteLine(item.Perk);
}
