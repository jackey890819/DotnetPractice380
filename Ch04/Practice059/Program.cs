// 實例 059 初始化唯讀欄位

SomeClass s1 = new("111");
Console.WriteLine(s1.GenericKey);

public class SomeClass
{
    public readonly string GenericKey;
    public SomeClass(string genericKey)
    {
        GenericKey = genericKey;
    }
}

// 新版方法：使用主要建構式
//public class SomeClass(string genericKey)
//{
//    public readonly string GenericKey = genericKey;
//}