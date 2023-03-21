// See https://aka.ms/new-console-template for more information
using ProxyDesignPattern;

IImage image1 = new ProxyImage("cat.jpg");
IImage image2 = new ProxyImage("dog.jpg");

// image1 will be loaded from disk
image1.Display();

// image1 will not be loaded from disk again, since it is cached
image1.Display();

// image2 will be loaded from disk
image2.Display();

// image2 will not be loaded from disk again, since it is cached
image2.Display();
