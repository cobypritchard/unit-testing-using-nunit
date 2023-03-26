namespace Generic.Service;

public class GenericService<T>
{
    public string IsGenericNonVirtual(T candidate)
    {
        return string.Format("{0} what the input in a non-virtual is Generic({1}).", candidate, typeof(T));
    }

    public virtual string IsGenericVirtual(T candidate)
    {
        return string.Format("{0} what the input in a virtual is Generic({1}).", candidate, typeof(T));
    }
}
