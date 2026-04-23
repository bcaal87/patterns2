namespace PatronesExtra_3.Chain;

public abstract class Handler
{
    protected Handler? Next;
    public void SetNext(Handler next) => Next = next;
    public abstract void Handle(string request);
}

public class Level1 : Handler
{
    public override void Handle(string request)
    {
        if (request == "password")
            Console.WriteLine("Nivel 1 resolvió.");
        else
            Next?.Handle(request);
    }
}

public class Level2 : Handler
{
    public override void Handle(string request)
    {
        if (request == "network")
            Console.WriteLine("Nivel 2 resolvió.");
        else
            Next?.Handle(request);
    }
}

public class Admin : Handler
{
    public override void Handle(string request)
    {
        Console.WriteLine("Admin resolvió: " + request);
    }
}

public static class ChainDemo
{
    public static void Run()
    {
        var l1 = new Level1();
        var l2 = new Level2();
        var admin = new Admin();

        l1.SetNext(l2);
        l2.SetNext(admin);

        l1.Handle("password");
        l1.Handle("network");
        l1.Handle("server down");
    }
}
