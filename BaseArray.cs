public abstract class BaseArray : IArray
{
    public abstract void Initialize(bool userFill = false);
    public abstract void Print();
    public abstract decimal Average();
}