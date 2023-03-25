namespace Prime.Services
{
    public class IntService : PrimeService
    {
        public string IsIntNonVirtual(string candidate)
        {
            var returnVal = string.Format("{0} what the input in a non-virtual is Int.", candidate);
            Console.WriteLine(returnVal);
            return returnVal;
        }

        public new string IsPrimeNonVirtual(string candidate)
        {
            var baseReturnVal = base.IsPrimeNonVirtual(candidate);
            var returnVal = string.Format("{0} what the input in a non-virtual is Prime(Int).", candidate);
            Console.WriteLine(returnVal);
            return returnVal;
        }

        public override string IsPrimeVirtual(string candidate)
        {
            var baseReturnVal = base.IsPrimeVirtual(candidate);
            var returnVal = string.Format("{0} what the input in a virtual is Prime(Int).", candidate);
            Console.WriteLine(returnVal);
            return returnVal;
        }
    }
}