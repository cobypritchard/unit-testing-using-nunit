namespace Generic.Service;

public class GenericService<T>
{
    public string IsGenericNonVirtual(T candidate)
    {
        var returnVal = string.Format("{0} what the input in a non-virtual is Generic({1}).", candidate, typeof(T));
        Console.WriteLine(returnVal);
        return returnVal;
    }

    public virtual string IsGenericVirtual(T candidate)
    {
        var returnVal = string.Format("{0} what the input in a virtual is Generic({1}).", candidate, typeof(T));
        Console.WriteLine(returnVal);
        return returnVal;
    }
}
