// 實例 060 多載方法

Test t = new();
Console.WriteLine(t.Compute(5));
Console.WriteLine(t.Compute(5, 2));
Console.WriteLine(t.Compute(5, 2, 3));

public class Test
{
    public int Compute(int a)
    {
        return a * 1;
    }
    public int Compute(int a, int b)
    {
        return a * b;
    }
    public int Compute(int a, int b, int c)
    {
        return a * b * c;
    }
}