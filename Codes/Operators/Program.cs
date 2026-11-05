// See https://aka.ms/new-console-template for more information

int a = 5;
int b = 10;

Console.WriteLine("Add: " + a + b); // bukan jadi penjumlahan tapi gabungin string
// Console.WriteLine("Substract: " + a - b); ga work, + dan - ada di level yang sama
Console.WriteLine("Multiply: " + a * b);
Console.WriteLine("Division: " + a / b);
Console.WriteLine("Gilang" + "Agung");

// di bawah ini bisa jalan semua
Console.WriteLine("Add: " + (a + b));
Console.WriteLine("Substract: " + (a - b));
Console.WriteLine("Multiply: " + (a * b));
Console.WriteLine("Division: " + (a / b));
