
Console.WriteLine("Provide total:");
int UserInput = Int32.Parse(Console.ReadLine());
double discount = CalculatDiscount(UserInput);

Console.WriteLine($"Your discount is {discount} %");

double newTotal = CalculateNewTotal(UserInput, discount);

Console.WriteLine($"Your updated total with {discount} %: {newTotal}");
static double CalculatDiscount(int total)
{
    if (total < 10)
    {
        return 1;
    }
    else if (total >= 10 && total < 20)
    {
        return 5;
    }
    else
    {
        return 10;
    }
}

static double CalculateNewTotal(double total, double discount)
{
    double result = total - (total * discount) / 100;
    return result;
}