/*
 * 實例 056 建置函數的互相呼叫
 */

A a1 = new(100);
A a2 = new();

Console.WriteLine(a1.Num);
Console.WriteLine(a2.Num);


public class A
{
    public int Num;

    public A(int num)
    {
        this.Num = num;
    }
    public A() : this(1000) { }
}