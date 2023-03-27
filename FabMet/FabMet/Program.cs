using System;
using ClassLibrary1;
using static ClassLibrary1.Class1;

namespace FabMet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Типи фасадів та робітники:");

            // створення фабрик для кожного стилю оформлення фасаду
            IMasterFactory contemporaryFactory = new ContemporaryMasterFactory();
            IMasterFactory classicFactory = new ClassicMasterFactory();
            IMasterFactory victorianFactory = new VictorianMasterFactory();

            // створення об'єктів FacadeDecorator з використанням фабрик
            FacadeDecorator contemporaryDecorator = new FacadeDecorator(contemporaryFactory);
            FacadeDecorator classicDecorator = new FacadeDecorator(classicFactory);
            FacadeDecorator victorianDecorator = new FacadeDecorator(victorianFactory);

            // виклик методу DecorateFacade для кожного об'єкта FacadeDecorator
            contemporaryDecorator.DecorateFacade();
            classicDecorator.DecorateFacade();
            victorianDecorator.DecorateFacade();


            Facade f = new Facade(contemporaryFactory);
            f.Decorate();

            Facade q = new Facade(classicFactory);
            q.Decorate();


            Facade h = new Facade(victorianFactory);
            h.Decorate();
        }
    }
}
