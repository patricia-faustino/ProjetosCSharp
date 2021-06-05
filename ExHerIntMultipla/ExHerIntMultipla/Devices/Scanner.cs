using System;
namespace ExHerIntMultipla.Devices
{
    class Scanner : Device, IScanner
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scaner processing: " + document);
        }
        public string Scan()
        {
            return "Scaner scan result";
        }

    }
}
