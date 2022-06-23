using LINQtoCSV;
using MyFirstApp.Models;

Console.WriteLine("Hello, World!");

var ctx = new CsvContext();
var contacts = ctx.Read<Contact>("Contacts.csv");

foreach (var contact in contacts)
{
    Console.WriteLine(contact);
}

DoSomething();


static void DoSomething() =>
    Console.WriteLine("Created this method...");

