/*
 * 實例 055 為結構定義建置函數
 */

// 不使用new運算子
Rectangle r1;
r1.Width = 10;
r1.Height = 25;
r1.Print();


// 使用new運算子
Rectangle r2 = new(25, 10);
r2.Print();


struct Rectangle
{
    public int Width;
    public int Height;

    public Rectangle(int w, int h)
    {
        Width = w;
        Height = h;
    }

    public void Print()
    {
        Console.WriteLine($"Rectangle: Width:{Width} Height:{Height}");
    }
}
