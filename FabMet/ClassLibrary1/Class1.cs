using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        // інтерфейс, який будуть реалізовувати об'єкти майстрів
        public interface IMaster
        {
            string DecorateFacade();
        }

        // класи майстрів, які реалізовують інтерфейс IMaster
        public class ContemporaryMaster : IMaster
        {
            public string DecorateFacade()
            {
                string a = "Оздоблення фасаду в сучасному стилі.";
                return a;
            }
        }

        public class ClassicMaster : IMaster
        {
            public string DecorateFacade()
            {
               string b ="Оздоблення фасаду в класичному стилі.";
                return b;
            }
        }

        public class VictorianMaster : IMaster
        {
            public string DecorateFacade()
            {
               string q = "Оздоблення фасаду у вікторіанському стилі.";
                return q;
            }
        }

        // інтерфейс фабрики, який буде реалізовувати клас фабрики
        public interface IMasterFactory
        {
            IMaster CreateMaster();
        }

        // класи фабрик, які реалізують інтерфейс IMasterFactory
        public class ContemporaryMasterFactory : IMasterFactory
        {
            public IMaster CreateMaster()
            {
                return new ContemporaryMaster();
            }
        }

        public class ClassicMasterFactory : IMasterFactory
        {
            public IMaster CreateMaster()
            {
                return new ClassicMaster();
            }
        }

        public class VictorianMasterFactory : IMasterFactory
        {
            public IMaster CreateMaster()
            {
                return new VictorianMaster();
            }
        }
        // клас, який використовує фабрики для створення об'єктів майстрів
        public class FacadeDecorator
        {
            private IMasterFactory _factory;

            public FacadeDecorator(IMasterFactory factory)
            {
                _factory = factory;
            }

            public void DecorateFacade()
            {
                IMaster master = _factory.CreateMaster();
                master.DecorateFacade();
            }
        }
        public abstract class Designer
        {
            // метод для розробки плану оформлення фасаду будинку
            public abstract string DesignFacade();
        }
        // клас майстра сучасного стилю
        public class ContemporaryMaster1 : IMaster
        {
            public string DecorateFacade()
            {
                return "The facade of the building is decorated in a contemporary style.";
            }
        }

        // фабрика майстрів сучасного стилю
        public class ContemporaryMasterFactory1 : IMasterFactory
        {
            public IMaster CreateMaster()
            {
                return new ContemporaryMaster();
            }
        }

        // клас фасаду будинку
        public class Facade
        {
            private IMasterFactory masterFactory;
            private Designer designer;

            public Facade(IMasterFactory factory, Designer designer)
            {
                this.masterFactory = factory;
                this.designer = designer;
            }
            public Facade(IMasterFactory f)
            {
                this.masterFactory = f;
            }

            public string Decorate()
            {
               // string facadeDesign = designer.DesignFacade();
                IMaster master = masterFactory.CreateMaster();
                string facadeDecoration = master.DecorateFacade();
                Console.WriteLine(facadeDecoration);
                return $" {facadeDecoration}";
            }
        }
    }
}
