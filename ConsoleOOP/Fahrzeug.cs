using System.Globalization;

namespace ConsoleOOP
{
    public class Fahrzeug
    {
        // Properties

        public string Name { get; set; }
        public int MaximaleGeschwindigkeit { get; set; }
        public int AktuelleGeschwindigkeit { get; set; }

        public double Preis { get; set; }

        public bool Motorlaueft { get; set; }

        // Constructor
        public Fahrzeug(string name, int maxSpeed, int preis)
        {
            Name = name;
            MaximaleGeschwindigkeit = maxSpeed;
            Preis = preis;

            Motorlaueft = false;
            AktuelleGeschwindigkeit = 0;
        }

        // Methoden

        public virtual string Info()
        {
            return($"Das Fahrzeug  heisst: {Name}, kostet: {Preis}, Max Speed: {MaximaleGeschwindigkeit}, Current Speed: {AktuelleGeschwindigkeit}, Motor ist an: {Motorlaueft}");
        }

        public void StarteMotor()
        {
            if (!Motorlaueft) { Motorlaueft = true; }
        }

        public void StoppeMotor()
        {
            if (Motorlaueft) { Motorlaueft = false; }
        }

        public void Beschleunige(int a)
        {
            if (!Motorlaueft) { return; }


            if((AktuelleGeschwindigkeit + a) < 0) 
            { 
                AktuelleGeschwindigkeit = 0;
                return;
            }

            if((AktuelleGeschwindigkeit + a) > MaximaleGeschwindigkeit) 
            { 
                AktuelleGeschwindigkeit = MaximaleGeschwindigkeit;
                return;
            }
            
            
            AktuelleGeschwindigkeit += a;
            

        }


    }

    public class PKW:Fahrzeug
    {
        // Spezifische Prop
        public int SitzAnzahl { get; private set; }

        // Constructor
        public PKW(string name, int maxSpeed, int preis, int sitze):base(name, maxSpeed, preis)
        {
            SitzAnzahl = sitze;           
        }

        public override string Info()
        {
            string strInfo = base.Info();
            strInfo += $" und hat {SitzAnzahl} Sitze";
            return strInfo;
        }
    }

    public class Schiff : Fahrzeug, IBeladbar
    {
        public int Containerzahl { get; set; }
        public Fahrzeug Ladung { get; set; }

        public Schiff(string name, int maxSpeed, int preis, int containerZahl, Fahrzeug hasLadung) : base(name, maxSpeed, preis)
        {
            Containerzahl = containerZahl;
            Ladung = hasLadung;
        }

        public override string Info() 
        {
            string strInfo = base.Info();
            strInfo += $" und kann {Containerzahl} Containers tragen und has Ladung : {Ladung} ";
            return strInfo;
        }

        void IBeladbar.Belade(Fahrzeug fz)
        {
            if (fz != null)
            {
                Ladung = fz;
            }

        }

        Fahrzeug IBeladbar.Entlade()
        {
            if (Ladung != null)
            {
                Fahrzeug ladung = Ladung;
                
                // räume den Lager
                Ladung = null;

                return ladung;

            }
            return null;
        }
    }

    public interface IBeladbar
    {
        public Fahrzeug Ladung { get; set; }

        public void Belade(Fahrzeug fz);
        public Fahrzeug Entlade();
    }
}