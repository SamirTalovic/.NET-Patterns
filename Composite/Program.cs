using Composite.Composites;
using Composite.Leaves;

var newkaCola = new DreamTravel(0);
newkaCola.Agency.Add(new LOL(150));
newkaCola.Agency.Add(new Strew(150));

var nukaBerry = new EcoTravel(0);
nukaBerry.Agency.Add(new LOL(150));
nukaBerry.Agency.Add(new Strew(150));
nukaBerry.Agency.Add(new Monsuer(100));

var nukaFancy = new SwiftTravel(0);
nukaFancy.Agency.Add(new Bg(50));
nukaFancy.Agency.Add(new Strew(150));

newkaCola.DisplayHitPoints();
Console.WriteLine("--------------------------");

nukaBerry.DisplayHitPoints();
Console.WriteLine("--------------------------");

nukaFancy.DisplayHitPoints();

