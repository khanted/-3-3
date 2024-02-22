using System;
using static IPrintable;
public interface IArray : IPrintable
{
    void Initialize(bool userFill = false);
    decimal Average();
}