namespace String.Services
{
    public abstract class StringService
    {
        public abstract string IsStringAbstract(string candidate);

        public string IsStringNonVirtual(string candidate)
        {
            var returnVal = string.Format("{0} what the input in a non-virtual Is String", candidate);
            Console.WriteLine(returnVal);
            return returnVal;
        }

        public virtual string IsStringVirtual(string candidate)
        {
            var returnVal = string.Format("{0} what the input in a virtual Is String.", candidate);
            Console.WriteLine(returnVal);
            return returnVal;
        }
    }
}