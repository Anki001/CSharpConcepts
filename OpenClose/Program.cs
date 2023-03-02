// See https://aka.ms/new-console-template for more information
using OpenClose;

var totalBillAmount = 1000;
Console.WriteLine("Get Discount with customer type:");

Customer goldCust = new();
goldCust.CustType = 1;

Console.WriteLine($"Total bill amount of gold customer: {goldCust.GetDiscount(totalBillAmount)}");

Customer silverCust = new();
silverCust.CustType = 0;

Console.WriteLine($"Total bill amount of silver customer: {silverCust.GetDiscount(totalBillAmount)}");

OcCustomer customer = new();
Console.WriteLine($"OC - Total bill amount of regular customer: {customer.GetDiscount(totalBillAmount)}");

OcCustomer silverCustomer = new SilverCustomer();
Console.WriteLine($"OC - Total bill amount of silver customer: {silverCustomer.GetDiscount(totalBillAmount)}");

OcCustomer goldCustomer = new GoldCustomer();
Console.WriteLine($"OC - Total bill amount of gold customer: {goldCustomer.GetDiscount(totalBillAmount)}");

OcCustomer platinumCustomer = new PlatinumCustomer();
Console.WriteLine($"OC - Total bill amount of gold customer: {platinumCustomer.GetDiscount(totalBillAmount)}");

