using System;


namespace Metody
{
    //Definiujemy interfejs
    interface Zawody
    {
        void Tomasz_Telwak();
    }
    //Definiujemy klasę abstrakcyjną
    public abstract class Wiek
    {
        //Definiujemy metodę wirtualną
        public virtual void Mój_wiek(int Wiek) { Console.WriteLine("Wiek: "+Wiek); Console.ReadKey(); }
    }
    class Metody : Wiek
    {
        static void Main(string[] args)
        {
            //Metoda Statyczna (Nie trzeba tworzyć obiektu)
            Jak_masz_na_imie("Tomasz");
            //Tworzenie obiektu
            Metody Glowna = new Metody();
            //Metoda bez modyfikatorów (Musimu utworzyć obiekt).
            Glowna.Jak_masz_na_nazwisko("Telwak");
            //Klasa abstrakcyjna odwołanie do metody wirtualnej
            Glowna.Mój_wiek(23);

            //Tworzenie obiektu (Ludzie)
            Ludzie Zawody = new Ludzie();
            //interfejs
            Zawody.Tomasz_Telwak();
            //Tworzymy obiekty
            Gdzie_mieszkałeś Gdzie_mieszkałeś = new Gdzie_mieszkałeś();
            Gdzie_mieszkasz_obecnie Gdzie_mieszkasz = new Gdzie_mieszkasz_obecnie();
            Samochód Wymarzony = new Samochód();
            Samochód2 Wymarzony2 = new Samochód2();
            //Wyświetlamy rezultat
            Console.WriteLine("Mieszkałem w: " + Gdzie_mieszkałeś.Miasto());
            Console.WriteLine("Mieszkam w: " + Gdzie_mieszkasz.Miasto());
            Console.ReadKey();
            Console.WriteLine("Pierwszy wymarzony samochód: " + Wymarzony.Marka());
            Console.WriteLine("Drugi wymarzony samochód: " + Wymarzony2.Marka());
            Console.ReadKey();


        }



        //Metoda statyczna może być wywoływania bez konieczności tworzenia obiektu.
        public static String Jak_masz_na_imie(string Imie)
        {
            Console.WriteLine("Mam na imię: "+Imie);
            Console.ReadKey();
            return Imie;
        }
        //Metoda bez modyfikatorów.
        public string Jak_masz_na_nazwisko(string Nazwisko)
        {
            Console.WriteLine("Mam na Nazwisko: " + Nazwisko);
            Console.ReadKey();
            return Nazwisko;
        }

    }
    //Nowa klasa Dziedzicząca interfejs (Metody w interfejsie muszą być wykorzystywane)
    class Ludzie : Zawody
    {
        public void Tomasz_Telwak()
        {
            Console.WriteLine("Mój zawód to: Programista");
            Console.ReadKey();
        }
    }
    
}
