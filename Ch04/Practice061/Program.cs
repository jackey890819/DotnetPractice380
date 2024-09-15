// 實例 061 大類實例傳遞給方法後為什麼沒有被更改
// 測試時可以比方法有無ref的輸出

Product p = new()
{
    Name = "測試產品a",
    Code = 60009
};
Console.WriteLine(p);
Product.Update(ref p);
Console.WriteLine(p);


public class Product
{
    public string Name { get; set; }
    public int Code { get; set; }

    public static void Update(ref Product p)
    {
        p = new Product
        {
            Name = "測試產品c",
            Code = 700021
        };
    }

    public override string ToString()
    {
        return $"{Name}, {Code}";
    }
}