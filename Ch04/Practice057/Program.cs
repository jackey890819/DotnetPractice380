// 實例 057 靜態建置函數

Console.WriteLine(Test.Sample);
Console.WriteLine(Test.Sample);
Console.WriteLine(Test.Sample);

public class Test
{
    public static string Sample { get; }

    /// <summary>
    /// 靜態建置函數。用於初始化靜態成員。在任何靜態成員首次呼叫前會被呼叫，且往後不再被呼叫。
    /// </summary>
    static Test()
    {
        Sample = "示範屬性";
        Console.WriteLine("靜態建置函數被呼叫。");
    }
}