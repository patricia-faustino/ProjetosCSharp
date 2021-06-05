using System;

namespace ExHerIntMultipla.Devices
{
    class ComboDevice : Device, IScaner, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine("Combodevice Print " + document);
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Combodevice Process " + document);
        }
        public string Scan()
        {
            return "Combodevice Scan Result";
        }
    }
}
