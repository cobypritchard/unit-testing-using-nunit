namespace String.Services
{
    public abstract class StringService
    {
        public abstract string IsStringAbstract(string candidate);

        public string IsStringNonVirtual(string candidate)
        {
            return string.Format("{0} what the input in a non-virtual is String.", candidate);
        }

        public virtual string IsStringVirtual(string candidate)
        {
            return string.Format("{0} what the input in a virtual is String.", candidate);
        }
    }
}