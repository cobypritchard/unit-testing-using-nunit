namespace Prime.Services
{
    public class PrimeService : IPrimeService
    {
        public string IsPrimeNonVirtual(string candidate)
        {
            var returnVal = string.Format("{0} what the input in a non-virtual is Prime.", candidate);
            //Console.WriteLine(returnVal);
            return returnVal;
        }

        public virtual string IsPrimeVirtual(string candidate)
        {
            var returnVal = string.Format("{0} what the input in a virtual is Prime.", candidate);
            //Console.WriteLine(returnVal);
            return returnVal;
        }
    }
}