using LiskovSubstitution1.Concrete;
using LiskovSubstitution1.Enums;

namespace LiskovSubstitution1
{
    public class PhoneOsLiskov
    {
        public OperatingSys GetOS(Companies company)
        {
            switch (company)
            {
                case Companies.Microsoft:
                    return new Windows();
                case Companies.Apple:
                    return new AppleOs();
                case Companies.Samsug:
                case Companies.Redmi:
                case Companies.Motorola:
                    return new Android();
                case Companies.Nokia:
                case Companies.BlackBerry:
                    return new Basic();                
                default:
                    return new Unknown();
            }
        }
    }
}