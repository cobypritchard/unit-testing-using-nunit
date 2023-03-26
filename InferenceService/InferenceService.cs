using Prime.Services;

namespace Inference.Service;

public class InferenceService
{
    private IPrimeService primeService;

    public InferenceService(IPrimeService _primeService)
    {
        primeService = _primeService;
    }

    public string IsInferenceNonVirtual(string candidate)
    {
        return primeService.IsPrimeNonVirtual(candidate);
    }

    public virtual string IsInferenceVirtual(string candidate)
    {
        return primeService.IsPrimeVirtual(candidate);
    }
}
