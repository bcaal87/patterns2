using PatronesExtra_3_Corregido.Proxy;
using PatronesExtra_3_Corregido.Chain;
using PatronesExtra_3_Corregido.State;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("=== PROXY ===");
ProxyDemo.Run();

Console.WriteLine("\n=== CHAIN OF RESPONSIBILITY ===");
ChainDemo.Run();

Console.WriteLine("\n=== STATE ===");
StateDemo.Run();
