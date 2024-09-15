// 實例 064 使用按參考傳遞的傳回值

Console.WriteLine("不使用按參考傳遞的回傳值");
Test1 t1 = new(100);
t1.DisplayValue();
int x = t1.Value;
x = 200;
Console.WriteLine("修改屬性傳回值後");
t1.DisplayValue();

Console.WriteLine("\n\n使用按參考傳遞的回傳值");
Test2 t2 = new(100);
t2.DisplayValue();
ref int y = ref t2.Value;
y = 200;
Console.WriteLine("修改屬性傳回值後");
t2.DisplayValue();



public class Test1
{
    private int _local;
    public Test1(int local)
    {
        _local = local;
    }
    public void DisplayValue()
    {
        Console.WriteLine($"{_local}");
    }
    public int Value => _local;
}

public class Test2
{
    private int _local;
    public Test2(int local)
    {
        _local = local;
    }
    public void DisplayValue()
    {
        Console.WriteLine($"{_local}");
    }
    public ref int Value => ref _local;
}