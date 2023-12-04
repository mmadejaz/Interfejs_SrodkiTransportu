/*
Przygotuj klasę opisującą środki transportu przeznaczone do poruszania się na lądzie, po wodzi i w powietrzu.
 - interfejsy: Jazda z metodą jedz(), Plywanie z metodą plyn() oraz Latanie z metodą lec()
 - klasy opisujące środki transportu: auto, statek i samolot.
 - jak zaimplementujesz amfibię?
 */
namespace Interfejs_SrodkiTransportu
{
    abstract class SrodekTransportu
    {
        protected string nazwa;
        public SrodekTransportu(string nazwa)
        {
            this.nazwa = nazwa;
        }
        public override string ToString()
        {
            return nazwa;
        }
    }
    interface ILadowy
    {
        void jedz();
        void zatrzymaj();
    }
    interface IWodny
    {
        void plyn();
        void zakotwicz();
    }
    class Auto : SrodekTransportu, ILadowy
    {
        public Auto(string nazwa) : base(nazwa) { }
        public void jedz()
        {
            Console.WriteLine($"{nazwa} jedzie!");
        }        
        public void zatrzymaj()
        {
            Console.WriteLine($"{nazwa} zatrzymal sie!");
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
    class Statek : SrodekTransportu, IWodny
    {
        public Statek(string nazwa) : base(nazwa) { }
        public void plyn()
        {
            Console.WriteLine($"{nazwa} płynie!");
        }
        public void zakotwicz()
        {
            Console.WriteLine($"{nazwa} zakotwiczył!");
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
    class Amfibia : Auto, IWodny
    {
        public Amfibia(string nazwa) : base(nazwa) { }
        public void plyn()
        {
            Console.WriteLine($"{nazwa} płynie!");
        }
        public void zakotwicz()
        {
            Console.WriteLine($"{nazwa} zakotwiczył!");
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}