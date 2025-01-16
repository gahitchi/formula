


Console.WriteLine("formula = (A+B) * (C-D) + 100 * (E-F) \n");

Console.WriteLine("insert the first number A: ");
double A = Convert.ToDouble(Console.ReadLine()); Console.WriteLine("\n");

Console.WriteLine("insert the second number B: ");
double B = Convert.ToDouble(Console.ReadLine()); Console.WriteLine("\n");

Console.WriteLine("insert the third number C: ");
double C = Convert.ToDouble(Console.ReadLine()); Console.WriteLine("\n");

Console.WriteLine("insert the fourth number D: ");
double D = Convert.ToDouble(Console.ReadLine()); Console.WriteLine("\n");

Console.WriteLine("insert the fifth number E: ");
double E = Convert.ToDouble(Console.ReadLine()); Console.WriteLine("\n");

Console.WriteLine("insert the sixth number F: ");
double F = Convert.ToDouble(Console.ReadLine()); Console.WriteLine("\n");

double Op1(double a, double b)
{
    return a + b;
}

double Op2(double c, double d)
{
    return c - d;
}

double Op3(double e, double f)
{
    return e - f;
}

double risultato1 = 0.0;
void CalcoloOp1()
{
    risultato1 = Op1(A, B);
}

double risultato2 = 0.0;
void CalcoloOp2()
{
    risultato2 = Op2(C, D);
}

double risultato3 = 0.0;
void CalcoloOp3()
{
    risultato3 = Op3(E, F);
}

Thread ris1 = new (CalcoloOp1);
Thread ris2 = new (CalcoloOp2);
Thread ris3 = new (CalcoloOp3);

ris1.Start();
ris2.Start();
ris3.Start();

ris1.Join();
ris2.Join();
ris3.Join();

double risFin = (risultato1 * risultato2) + (100 * risultato3);
Console.WriteLine("result = " +  risFin);