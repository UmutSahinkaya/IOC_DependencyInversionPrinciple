using IOC.console;

BL bl = new BL();

bl.GetProducts().ForEach(p => Console.WriteLine($"Id:{p.Id} Name:{p.Name} Price:{p.Price} Stock:{p.Stock}"));

Console.ReadLine();