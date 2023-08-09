/*
    Створiть та опишiть клас «Місто». 

    Виконайте перевантаження 

    + (для  збільшення кількості жителів на вказану кількість), 

    – (для зменшення кількості жителів на вказану кількість), 

    == (перевірка на рівність двох міст за кількістю жителів), 

    < і > (перевірка на меншу чи більшу кількість мешканців), 

    != і Equals. 
*/

using Task_3;

City city1 = new City("City1", 2800000);
City city2 = new City("City2", 800000);

Console.WriteLine("Initial number of residents in cities:");
Console.WriteLine(city1.Name + ": " + city1.Population);
Console.WriteLine(city2.Name + ": " + city2.Population);

city1 += 100000;
city2 -= 50000;

Console.WriteLine("Changed number of residents in cities:");
Console.WriteLine(city1.Name + ": " + city1.Population);
Console.WriteLine(city2.Name + ": " + city2.Population);

if (city1 == city2)
    Console.WriteLine("Cities have the same number of residents");
else if (city1 > city2)
    Console.WriteLine("In " + city1.Name + " more residents than in " + city2.Name);
else
    Console.WriteLine("In " + city2.Name + " more residents than in " + city1.Name);


Console.WriteLine("Equals: " + city1.Equals(city2));