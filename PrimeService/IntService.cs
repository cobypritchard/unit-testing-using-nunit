namespace Prime.Services
{
    public class IntService : PrimeService
    {
        public string IsIntNonVirtual(string candidate)
        {
            return string.Format("{0} what the input in a non-virtual is Int.", candidate);
        }

        public new string IsPrimeNonVirtual(string candidate)
        {
            var baseReturnVal = base.IsPrimeNonVirtual(candidate);
            return string.Format("{0} what the input in a non-virtual is Prime(Int).", candidate);
        }

        public override string IsPrimeVirtual(string candidate)
        {
            var baseReturnVal = base.IsPrimeVirtual(candidate);
            return string.Format("{0} what the input in a virtual is Prime(Int).", candidate);
        }
    }
}