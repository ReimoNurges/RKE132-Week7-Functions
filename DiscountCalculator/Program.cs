﻿
Console.WriteLine("Provide total: ");
int user = Int32.Parse(Console.ReadLine());

double discount = Calculatediscount(user);

Console.WriteLine($"Your discount is {discount}%");

double newTotal = CalculateNewTotal(user, discount);

Console.WriteLine($"Your update total with {discount}%: {newTotal}");



static double Calculatediscount(int total)
{
    if (total < 10) return 1;

    else if (total >= 10 && total < 20) return 5;

    else return 10;
}

static double CalculateNewTotal(double total, double discount)
{
    double result = total - (total * discount) / 100;
    return result;
}