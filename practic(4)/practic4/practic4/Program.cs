using practic4;
class Program
{
    public static void Main()
    {

        //------------------------------------------------------//

        Ship ship = new Ship();

        Console.WriteLine("Ship y:" + ship.getY());

        ship.moveUp();

        Console.WriteLine("Ship y:" + ship.getY());

        //------------------------------------------------------//

        Console.WriteLine("\nCreating Fleet...\n");

        Ship[] fleet = {
            new Ship(3, 5, title: "MyShip"),
            new Ship(9, 1, maxSpeed: 300),
            new Ship(7, 8, hullLength: 21),
            new Ship(0, 2, teamSize: 19),
            new Ship(3, 1, title: "GalacticGuard", maxSpeed: 500),
            new Ship(8, 9, maxSpeed: 300, teamSize: 3)
        };

        for (int i = 0; i < fleet.Length; i++) {
            Console.WriteLine("Ship number " + i + ": x: " + fleet[i].getX() + "; y:" + fleet[i].getY());
        }

        Console.WriteLine("\nMoving ships...\n");

        fleet[0].moveUp();
        fleet[3].moveUp();
        fleet[5].moveUp();

        for (int i = 0; i < fleet.Length; i++) {
            Console.WriteLine("Ship number " + i + ": x: " + fleet[i].getX() + "; y:" + fleet[i].getY());
        }

        //------------------------------------------------------//

        Console.WriteLine("\nDetailed:\n");

        for (int i = 0; i < fleet.Length; i++) {
            Console.WriteLine("Ship number " + i + ":");
            Console.WriteLine("\ttitle: " + fleet[i].getTitle());
            Console.WriteLine("\tx: " + fleet[i].getX() + "; y: " + fleet[i].getY());
            Console.WriteLine("\tmaxSpeed: " + fleet[i].getMaxSpeed());
            Console.WriteLine("\thullLength: " + fleet[i].getHullLength());
            Console.WriteLine("\tteamSize: " + fleet[i].getTeamSize());
        }
    }
}