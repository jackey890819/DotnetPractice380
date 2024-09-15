/*
 * 實例 054 宣告公共類別
 */
Ant v1 = default(Ant);          // 書中的宣告方式
var v2 = default(Dragonfly);    // 使用var的宣告方式
Spider? v3 = default;           // 個人比較愛用的方式(另外宣告為nullable)


Console.WriteLine(v1 is null);
Console.WriteLine(v2 is null);
Console.WriteLine(v3 is null);


public class Ant { }
public class Dragonfly { }
public class Spider { }
