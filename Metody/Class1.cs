using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody
{
    //Definiujemy klase publiczną.
    public class Gdzie_mieszkałeś
    {
        //Publiczna metoda wirtualna
        public virtual string Miasto() { return "Przemyśl"; }
    }
    //Publiczna klasa która dziedziczy po klasie "Gdzie_mieszkałeś"
    public class Gdzie_mieszkasz_obecnie : Gdzie_mieszkałeś
    {
        //Definiujemy metodę "override" która nadpisuje metodę wyżej.
        public override string Miasto() { return "Wrocław"; }
    }

    //Definiujemy publiczną klasę
    public class Samochód
    {
        //Publiczna wirtualna metoda
        public virtual string Marka() { return "Ferrari"; }

    }
    //Publiczna klasa dziedzicząca po "Samochód"
    public class Samochód2 : Samochód
    {
        //Definiujemy metodę "new" która dodaje kolejną metodę (Nie nadpisuje istniejącej).
        new public string Marka() { return "Porshe"; }
    }
}
