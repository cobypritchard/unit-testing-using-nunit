namespace String.Services
{
    public class TextService : StringService
    {
        public override string IsStringAbstract(string candidate)
        {
            return  string.Format("{0} what the input in a abstract is String(Text).", candidate);
        }

        public new string IsStringNonVirtual(string candidate)
        {
            base.IsStringNonVirtual(candidate);
            return string.Format("{0} what the input in a non-virtual is String(Text).", candidate);
        }

        public override string IsStringVirtual(string candidate)
        {
            base.IsStringVirtual(candidate);
            return string.Format("{0} what the input in a virtual is String(Text).", candidate);
        }
    }
}