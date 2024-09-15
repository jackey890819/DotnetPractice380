/*
 * 實例 056 建置函數的互相呼叫
 */

Production p1 = new();
Production p2 = new(Guid.NewGuid(), "p2", DateTime.Today.AddDays(-1));
Production p3 = new("p3", DateTime.Today.AddDays(-2));

p1.Print();
Console.WriteLine("-");
p2.Print();
Console.WriteLine("-");
p3.Print();


public class Production
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime ProductDate { get; set; }

    public Production(Guid id, string name, DateTime productDate)
    {
        Id = id;
        Name = name;
        ProductDate = productDate;
    }

    public Production(string name, DateTime productDate)
        : this(Guid.NewGuid(), name, productDate) { }

    public Production()
        : this(Guid.NewGuid(), "未知產品", DateTime.Today) { }

    public void Print()
    {
        Console.WriteLine($"產品編號：{Id}\n產品名稱：{Name}\n生產日期：{ProductDate}");
    }
}
