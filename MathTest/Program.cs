using System.Text;

Console.WriteLine("Welcome to the calculator app");
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Enter 'start' to start the calculator or 'exit' to exit the calculator");
string startOrExit = Console.ReadLine();
while (true)
{
    Console.WriteLine("Enter number 1 : ");
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the operation (+, -, *, /,sqrt,abs) : ");
    string operation = Console.ReadLine();
    if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
    {
        Console.WriteLine("Enter number 2 : ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        double result = 0;
        switch (operation)
        {
            case "+":
                result = num1 + num2;
                Console.WriteLine("The result is : " + result);
                break;
            case "-":
                result = num1 - num2;
                Console.WriteLine("The result is : " + result);
                break;
            case "*":
                result = num1 * num2;
                Console.WriteLine("The result is : " + result);
                break;
            case "/":
                result = num1 / num2;
                Console.WriteLine("The result is : " + result);
                break;
            case "^":
                result = Math.Pow(num1,num2);
                break;
            default:
                Console.WriteLine("Invalid operation");
                break;
        }
    }
    else if (operation == "sqrt")
    {
        double result = Math.Sqrt(num1);
        Console.WriteLine("The result is : " + result);
    }
    else if (operation == "abs")
    {
        double result = Math.Abs(num1);
        Console.WriteLine("The result is : " + result);
    }
    else if (operation == "exiswseis")
    {
        Console.WriteLine("Επιλέξτε τύπο εξίσωσης:");
        Console.WriteLine("1. Εξίσωση 1ου βαθμού (ax + b = 0)");
        Console.WriteLine("2. Εξίσωση 2ου βαθμού (ax^2 + bx + c = 0)");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            SolveQuadraticEquation();
        }
        else if (choice == 2)
        {
            SolveLinearEquation();
        }
        else
        {
            Console.WriteLine("Μη έγκυρη επιλογή.");
        }
    }
    else
    {
        Console.WriteLine("Invalid operation");
    }
    Console.WriteLine("Enter 'start' to start the calculator or 'exit' to exit the calculator");
    startOrExit = Console.ReadLine();

    if (startOrExit == "exit")
    {
        Console.WriteLine("Thank you for using the calculator app");
        break;
    }
    if(startOrExit == "continue")
    {
        continue;
    }
}

void SolveQuadraticEquation()
{
    Console.Write("Δώστε τον συντελεστή a: ");
    double a = double.Parse(Console.ReadLine());
    Console.Write("Δώστε τον συντελεστή b: ");
    double b = double.Parse(Console.ReadLine());

    if (a == 0)
    {
        Console.WriteLine(b == 0 ? "Άπειρες λύσεις." : "Δεν υπάρχει λύση.");
    }
    else
    {
        double x = -b / a;
        Console.WriteLine($"Η λύση είναι: x = {x}");
    }
}

void SolveLinearEquation()
{
    Console.Write("Δώστε τον συντελεστή a: ");
    double a = double.Parse(Console.ReadLine());
    Console.Write("Δώστε τον συντελεστή b: ");
    double b = double.Parse(Console.ReadLine());
    Console.Write("Δώστε τον συντελεστή c: ");
    double c = double.Parse(Console.ReadLine());

    if (a == 0)
    {
        Console.WriteLine("Αυτή δεν είναι εξίσωση 2ου βαθμού.");
        return;
    }

    double discriminant = b * b - 4 * a * c;

    if (discriminant > 0)
    {
        double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
        double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
        Console.WriteLine($"Δύο πραγματικές ρίζες: x1 = {x1}, x2 = {x2}");
    }
    else if (discriminant == 0)
    {
        double x = -b / (2 * a);
        Console.WriteLine($"Μία διπλή ρίζα: x = {x}");
    }
    else
    {
        double realPart = -b / (2 * a);
        double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
        Console.WriteLine($"Μιγαδικές ρίζες: x1 = {realPart} + {imaginaryPart}i, x2 = {realPart} - {imaginaryPart}i");
    }

}