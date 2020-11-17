using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using CarCommon;

namespace CarHost
{
    class Program
    {
        [ImportMany(typeof(ICarContract))]
        private ICarContract[] cars = null;
        static void Main(string[] args)
        {
            new Program().Run();
        }

        void Run()
        {
            var catalog = new DirectoryCatalog(".");
            var container = new CompositionContainer(catalog);
            container.ComposeParts(this);
            foreach (ICarContract contract in cars)
            {
                Console.WriteLine(contract.StartEngine("You"));
            }
        }
    }
}
