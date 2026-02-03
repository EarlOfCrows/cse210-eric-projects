using System.IO.Pipelines;

public class Fraction
{
    private int _top;
    private int _bottom;
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int top_num)
    {
        _top = top_num;
        _bottom = 1;
    }
    public Fraction(int top_num, int bottom_num)
    {
        _top = top_num;
        _bottom = bottom_num;
    }
    public int GetTop()
    {
        return _top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetTop(int newtop)
    {
        if (newtop != 0){
        _top = newtop;
        }
    }
    public void SetBottom(int newbottom)
    {
        if (newbottom != 0){
        _bottom = newbottom;
        }
    }
    public double GetDecimalValue()
    {
        return (double)_top/_bottom;
    }
    public string DisplayFraction()
    {
        if (_top == _bottom){
            return $"{_top}";
        }
        else{
        return $"{_top}/{_bottom}";
        }
    }
}