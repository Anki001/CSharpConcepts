// See https://aka.ms/new-console-template for more information

using LiskovSubstitution1;
using LiskovSubstitution1.Concrete;
using LiskovSubstitution1.Enums;

var phoneOs = new PhoneOs();

Console.WriteLine(phoneOs.GetOS(Companies.Microsoft));
Console.WriteLine(phoneOs.GetOS(Companies.Opp));
Console.WriteLine(phoneOs.GetOS(Companies.Samsug));


var phoneOsLiskov = new PhoneOsLiskov();
OperatingSys operatingSys = phoneOsLiskov.GetOS(Companies.Apple);
Console.WriteLine(operatingSys.GetName());
