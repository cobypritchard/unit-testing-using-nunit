namespace Prime.Services
{
    public interface IPrimeService
    {
        public string IsPrimeNonVirtual(string candidate);

        public virtual string IsPrimeVirtual(string candidate)
        {
            throw new NotImplementedException("Visual Method IsPrimeVirtual has not been Implemented");
        }
    }
}