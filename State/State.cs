namespace PatronesExtra_3_Corregido.State;

public interface IOrderState
{
    void Handle();
}

public class PendingState : IOrderState
{
    public void Handle() => Console.WriteLine("Orden pendiente");
}

public class PaidState : IOrderState
{
    public void Handle() => Console.WriteLine("Orden pagada");
}

public class Order
{
    private IOrderState _state;

    public Order(IOrderState state)
    {
        _state = state;
    }

    public void SetState(IOrderState state)
    {
        _state = state;
    }

    public void ShowStatus()
    {
        _state.Handle();
    }
}

public static class StateDemo
{
    public static void Run()
    {
        var order = new Order(new PendingState());
        order.ShowStatus();

        order.SetState(new PaidState());
        order.ShowStatus();
    }
}
