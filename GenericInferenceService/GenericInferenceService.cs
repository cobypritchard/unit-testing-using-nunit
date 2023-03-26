using Prime.Services;

namespace GenericInference.Service;

public class GenericInferenceService<T> where T : IPrimeService, new()
{
    private T T1;

    public GenericInferenceService(T t1) 
    {
        T1 = t1;
    }

    public string IsGenericInferenceNonVirtual(string candidate)
    {
        return T1.IsPrimeNonVirtual(candidate);
    }

    public virtual string IsGenericInferenceVirtual(string candidate)
    {
        return T1.IsPrimeVirtual(candidate);
    }
}
