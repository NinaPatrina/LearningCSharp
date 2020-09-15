using System;

public static class RealNumberExtension
{
    public static double Expreal(this int realNumber, RationalNumber r)
    {
        throw new NotImplementedException("You need to implement this extension method.");
    }
}

public struct RationalNumber
{
    //public int rationalNumber;
    private int numerator;
    private int denominator;
    public RationalNumber(int numerator, int denominator)
    {
        if (numerator == 0 || denominator == 0) denominator = 1;
        this.numerator = numerator;
        this.denominator = denominator;
        //this.rationalNumber = numerator / denominator;
    }

    public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
    {
        return new RationalNumber((r1.numerator * r2.denominator + r2.numerator * r1.denominator), (r1.denominator * r2.denominator));
    }

    public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
    {
        return new RationalNumber((r1.numerator * r2.denominator - r2.numerator * r1.denominator), (r1.denominator * r2.denominator));
    }

    public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
    {
        return new RationalNumber((r1.numerator * r2.numerator), (r1.denominator * r2.denominator));
    }

    public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
    {
        if (r1.denominator * r2.numerator == 0) return new RationalNumber(0, 1);
        return new RationalNumber((r1.numerator * r2.denominator), (r1.denominator * r2.numerator));
    }

    public RationalNumber Abs()
    {
        return new RationalNumber(Math.Abs(numerator), Math.Abs(denominator));
    }

    public RationalNumber Reduce()
    {
        RationalNumber rn = new RationalNumber(numerator, denominator); ;
        int gcd = GCD(rn);
        return new RationalNumber(numerator / gcd, denominator / gcd);
    }

    public RationalNumber Exprational(int power)
    {
        if (power >= 0)
            return new RationalNumber((int)Math.Pow((double)numerator, (double)power), (int)Math.Pow((double)denominator, (double)power));
        else
        {
            power = Math.Abs(power);
            return new RationalNumber((int)Math.Pow((double)denominator, (double)power), (int)Math.Pow((double)numerator, (double)power));
        }
    }

    // public double Expreal(int baseNumber)
    //{return new RationalNumber((Math.Pow((double)baseNumber,(double)numerator), (double)denominator);
    // Math.Pow(A, 1.0 / N);

    public int GCD(RationalNumber rn)
    {
        while (rn.numerator != 0 && rn.denominator != 0)
        {
            if (rn.numerator > rn.denominator) rn.numerator %= rn.denominator;
            else rn.denominator %= rn.numerator;
        }
        return rn.numerator == 0 ? rn.denominator : rn.numerator;
    }
}
