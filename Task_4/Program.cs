/*
    Створiть та опишiть клас «Кредитна картка». 

    Додайте до вже створеного класу інформацію про суму грошей на картці. 

    Виконайте перевантаження 

    + (для збільшення суми грошей на вказану кількість), 

    – (для зменшення суми грошей на вказану кількість), 

    == (перевірка на рівність CVC коду), 

    < і > (перевірка на меншу чи більшу кількість суми грошей), 

    != і Equals. 

    Використовуйте механізм властивостей полів класу.
*/

using Task_4;

CreditCard card1 = new CreditCard("1234567890123456", 123, 1000.0m);
CreditCard card2 = new CreditCard("9876543210987654", 456, 1500.0m);

Console.WriteLine("Initial balance on the cards:");
Console.WriteLine(card1.CardNumber + ": " + card1.Balance);
Console.WriteLine(card2.CardNumber + ": " + card2.Balance);

card1 += 500.0m;
card2 -= 200.0m;

Console.WriteLine("Changed balance on cards:");
Console.WriteLine(card1.CardNumber + ": " + card1.Balance);
Console.WriteLine(card2.CardNumber + ": " + card2.Balance);

if (card1 == card2)
    Console.WriteLine("The CVC codes of the cards are the same");
else
    Console.WriteLine("CVC codes of cards are different");

if (card1 < card2)
    Console.WriteLine(card1.CardNumber + " has a smaller balance than " + card2.CardNumber);
else if (card1 > card2)
    Console.WriteLine(card1.CardNumber + " has a larger balance than " + card2.CardNumber);


Console.WriteLine("Equals: " + card1.Equals(card2));