namespace PatronesExtra_3_Corregido.Proxy;

public interface IFileService
{
    void ReadFile();
}

public class RealFileService : IFileService
{
    public void ReadFile()
    {
        Console.WriteLine("Leyendo archivo...");
    }
}

public class FileProxy : IFileService
{
    private readonly RealFileService _realService = new();

    public void ReadFile()
    {
        Console.WriteLine("Validando permisos...");
        bool hasAccess = true;

        if (hasAccess)
            _realService.ReadFile();
        else
            Console.WriteLine("Acceso denegado");
    }
}

public static class ProxyDemo
{
    public static void Run()
    {
        IFileService file = new FileProxy();
        file.ReadFile();
    }
}
