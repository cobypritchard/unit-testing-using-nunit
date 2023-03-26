namespace String.Services
{
    public class TextService : StringService
    {
        public override string IsStringAbstract(string candidate)
        {
            var returnVal = string.Format("{0} what the input in a abstract Is String(Text).", candidate);
            //Console.WriteLine(returnVal);
            return returnVal;
        }

        public new string IsStringNonVirtual(string candidate)
        {
            base.IsStringNonVirtual(candidate);
            var returnVal = string.Format("{0} what the input in a non-virtual Is String(Text).", candidate);
            //Console.WriteLine(returnVal);
            return returnVal;
        }

        public override string IsStringVirtual(string candidate)
        {
            base.IsStringVirtual(candidate);
            var returnVal = string.Format("{0} what the input in a virtual Is String(Text).", candidate);
            //Console.WriteLine(returnVal);
            return returnVal;
        }
    }
}