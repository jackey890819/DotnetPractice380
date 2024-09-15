// 實例 062 輸出參數

double d1 = 1.25, d2 = 4.5, d3;
Work(d1, d2, out d3);
Console.WriteLine(d3);

static void Work(double x, double y, out double result)
{
    result = x * y;
}
