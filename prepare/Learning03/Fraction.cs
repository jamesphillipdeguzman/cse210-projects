using System;


namespace Learning03;

public class Fraction
{
    // Private attributes / fields
    private int _top;
    private int _bottom;

    // private int _number;

    // Define 3 constructors for the Fraction class...
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
        // _number = _top / _bottom;


    }

    public Fraction(int wholeNum)
    {
        _top = wholeNum;
        _bottom = 1;
        // _number = top / _bottom;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
        // _number = top / bottom;
    }

    // Define getters and setters

    public int GetTop()
    {
        return _top;
    }

    public int SetTop(int top)
    {
        _top = top;
        _bottom = 1;
        return top / _bottom;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public int SetBottom(int bottom)
    {
        _bottom = bottom;
        _top = 3;
        return _top / _bottom;
    }

    public string GetFractionString()
    {
        string myFractionString = $"{_top}/{_bottom}";
        return myFractionString;
    }

    public double GetDecimalValue()
    {
        double myDoubleNumber = (double)_top / (double)_bottom; // use explicit cast to convert variables to double data type
        return myDoubleNumber;
    }



    public override string ToString()
    {

        return $"{_top}/{_bottom}";

    }



}






