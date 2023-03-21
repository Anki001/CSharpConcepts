// See https://aka.ms/new-console-template for more information
using BuilderDesignPattern;
using BuilderDesignPattern.Concrete;
using BuilderDesignPattern.Interfaces;
using Newtonsoft.Json;

// Client

Waiter waiter = new Waiter();
IPizzaBuilder builder = new VeggiePizza();

builder.SetCrust("Thin Crust");
builder.SetSauce("Tomato sacue");
builder.SetToppings(new List<string> { "Mushroom", "Onion", "Peppers" });

waiter.SetBuilder(builder);

Pizza pizza = waiter.GetPizza();

Console.WriteLine(JsonConvert.SerializeObject(pizza));
