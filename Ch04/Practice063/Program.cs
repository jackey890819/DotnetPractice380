// 實例 063 可變個數的方法參數

Console.WriteLine(Sample(1, 2));
Console.WriteLine(Sample(1, 2, 3));

static int Sample(params int[] numbers)
{
    return numbers.Sum();
}