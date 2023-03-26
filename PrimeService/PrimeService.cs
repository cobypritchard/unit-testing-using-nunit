namespace Prime.Services
{
    public class PrimeService : IPrimeService
    {
        public virtual string IsPrimeNonVirtual(string candidate) // Had to make virtual for generic inference, is there a better way?
        {
            return string.Format("{0} what the input in a non-virtual is Prime.", candidate);
        }

        public virtual string IsPrimeVirtual(string candidate)
        {
            return string.Format("{0} what the input in a virtual is Prime.", candidate);
        }
    }
}