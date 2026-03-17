using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Task2
{
    public interface IDevice
    {
        string Brand { get; }
        string DeviceType { get; }
        void ShowInfo();
    }

    public class IProneLaptop : IDevice { public string Brand => "IProne"; public string DeviceType => "Laptop"; public void ShowInfo() => Console.WriteLine($"{Brand} {DeviceType}"); }
    public class IProneNetbook : IDevice { public string Brand => "IProne"; public string DeviceType => "Netbook"; public void ShowInfo() => Console.WriteLine($"{Brand} {DeviceType}"); }
    public class IProneEBook : IDevice { public string Brand => "IProne"; public string DeviceType => "EBook"; public void ShowInfo() => Console.WriteLine($"{Brand} {DeviceType}"); }
    public class IProneSmartphone : IDevice { public string Brand => "IProne"; public string DeviceType => "Smartphone"; public void ShowInfo() => Console.WriteLine($"{Brand} {DeviceType}"); }

    public class KiaomiLaptop : IDevice { public string Brand => "Kiaomi"; public string DeviceType => "Laptop"; public void ShowInfo() => Console.WriteLine($"{Brand} {DeviceType}"); }
    public class KiaomiNetbook : IDevice { public string Brand => "Kiaomi"; public string DeviceType => "Netbook"; public void ShowInfo() => Console.WriteLine($"{Brand} {DeviceType}"); }
    public class KiaomiEBook : IDevice { public string Brand => "Kiaomi"; public string DeviceType => "EBook"; public void ShowInfo() => Console.WriteLine($"{Brand} {DeviceType}"); }
    public class KiaomiSmartphone : IDevice { public string Brand => "Kiaomi"; public string DeviceType => "Smartphone"; public void ShowInfo() => Console.WriteLine($"{Brand} {DeviceType}"); }

    public class BalaxyLaptop : IDevice { public string Brand => "Balaxy"; public string DeviceType => "Laptop"; public void ShowInfo() => Console.WriteLine($"{Brand} {DeviceType}"); }
    public class BalaxyNetbook : IDevice { public string Brand => "Balaxy"; public string DeviceType => "Netbook"; public void ShowInfo() => Console.WriteLine($"{Brand} {DeviceType}"); }
    public class BalaxyEBook : IDevice { public string Brand => "Balaxy"; public string DeviceType => "EBook"; public void ShowInfo() => Console.WriteLine($"{Brand} {DeviceType}"); }
    public class BalaxySmartphone : IDevice { public string Brand => "Balaxy"; public string DeviceType => "Smartphone"; public void ShowInfo() => Console.WriteLine($"{Brand} {DeviceType}"); }
}
