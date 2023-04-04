using LiskovSubstitution1.Enums;

namespace LiskovSubstitution1
{
    // Identify the issue in this code and try to fix it
    // Issues - Violation of Open-Close and Liskov Substitution principle
    // Open-Close: If we want to add any new mobile company we need to modify zthis class and GetOs()
    
    // Liskov Substitution: Samsung, Redmi and Motorola are returning the same os,
    // so can have common implemtation for it, and ask user to mobile company for which he want OS

    public class PhoneOs
    {
        public string GetOS(Companies company)
        {
            switch (company)
            {
                case Companies.Microsoft:
                    return "Windows";
                case Companies.Apple:
                    return "iOS";
                case Companies.Samsug:
                case Companies.Redmi:
                case Companies.Motorola:
                    return "Android";
                case Companies.Nokia:
                case Companies.BlackBerry:
                    return "Basic";
                default:
                    return "Unknown";
            }
        }
    }
}
