public class rationNum
{
    private static int GCD(int a, int b)
    {
        return b == 0 ? Math.Abs(a) : GCD(b, a % b);
    }

    public readonly int Numerator;
    public readonly int Denominator;

    public rationNum(int numerator, int denominator)
    {
        if (denominator == 0)
            throw new ArgumentException("Знаменатель не может быть равен 0");

        int gcd = GCD(numerator, denominator);
        numerator /= gcd;
        denominator /= gcd;

        if (denominator < 0)
        {
            numerator = -numerator;
            denominator = -denominator;
        }

        Numerator = numerator;
        Denominator = denominator;
    }

    public override string ToString()
    {
        return Denominator == 1 ? $"{Numerator}" : $"{Numerator}/{Denominator}";
    }

    public static rationNum operator +(rationNum a, rationNum b) =>
        new rationNum(a.Numerator * b.Denominator + b.Numerator * a.Denominator, a.Denominator * b.Denominator);

    public static rationNum operator -(rationNum a, rationNum b) =>
        new rationNum(a.Numerator * b.Denominator - b.Numerator * a.Denominator, a.Denominator * b.Denominator);

    public static rationNum operator *(rationNum a, rationNum b) =>
        new rationNum(a.Numerator * b.Numerator, a.Denominator * b.Denominator);

    public static rationNum operator /(rationNum a, rationNum b)
    {
        if (b.Numerator == 0)
            throw new DivideByZeroException("Нельзя делить на 0");
        return new rationNum(a.Numerator * b.Denominator, a.Denominator * b.Numerator);
    }

    public static rationNum operator -(rationNum a) =>
        new rationNum(-a.Numerator, a.Denominator);

    public static bool operator ==(rationNum a, rationNum b)
    {
        if (ReferenceEquals(a, b)) return true;
        if (a is null || b is null) return false;
        return a.Numerator == b.Numerator && a.Denominator == b.Denominator;
    }

    public static bool operator !=(rationNum a, rationNum b) => !(a == b);

    public static bool operator <(rationNum a, rationNum b) =>
        a.Numerator * b.Denominator < b.Numerator * a.Denominator;

    public static bool operator >(rationNum a, rationNum b) =>
        a.Numerator * b.Denominator > b.Numerator * a.Denominator;

    public static bool operator <=(rationNum a, rationNum b) => a < b || a == b;

    public static bool operator >=(rationNum a, rationNum b) => a > b || a == b;

}
