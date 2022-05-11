using Decorator;

var pizzaBase = new MediumPizza();

var mediumPizzaWithCheese = new CheesePizzaDecorator(pizzaBase);

Console.WriteLine($"mediumPizzaWithCheese: {mediumPizzaWithCheese.CalculatePrice()}");

var p2 = new SalamiPizzaDecorator(mediumPizzaWithCheese);
Console.WriteLine($"medium with cheese and salami : {p2.CalculatePrice()}");

var doubleSalamiCheesePizza = new SalamiPizzaDecorator(p2);
Console.WriteLine(doubleSalamiCheesePizza.CalculatePrice());