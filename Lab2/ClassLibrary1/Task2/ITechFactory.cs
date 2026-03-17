using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Task2
{
    public interface ITechFactory
    {
        IDevice CreateLaptop();
        IDevice CreateNetbook();
        IDevice CreateEBook();
        IDevice CreateSmartphone();
    }

    public class IProneFactory : ITechFactory
    {
        public IDevice CreateLaptop() => new IProneLaptop();
        public IDevice CreateNetbook() => new IProneNetbook();
        public IDevice CreateEBook() => new IProneEBook();
        public IDevice CreateSmartphone() => new IProneSmartphone();
    }

    public class KiaomiFactory : ITechFactory
    {
        public IDevice CreateLaptop() => new KiaomiLaptop();
        public IDevice CreateNetbook() => new KiaomiNetbook();
        public IDevice CreateEBook() => new KiaomiEBook();
        public IDevice CreateSmartphone() => new KiaomiSmartphone();
    }

    public class BalaxyFactory : ITechFactory
    {
        public IDevice CreateLaptop() => new BalaxyLaptop();
        public IDevice CreateNetbook() => new BalaxyNetbook();
        public IDevice CreateEBook() => new BalaxyEBook();
        public IDevice CreateSmartphone() => new BalaxySmartphone();
    }
}
