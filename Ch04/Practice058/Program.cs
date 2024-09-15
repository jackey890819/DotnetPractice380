// 實例 058 驗證屬性值的有效性

User u = new();
try
{
    u.UserName = "Tom";
    u.Password = "12345678";
    u.trySetName();
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}


public class User
{
    private string _userName;
    public string UserName
    {
        get { return _userName; }
        set
        {
            if (value.Length > 16)
            {
                throw new ArgumentException("使用者名稱不能超過16個字元");
            }
            _userName = value;

        }
    }

    private string _password;
    public string Password
    {
        get { return _password; }
        set
        {
            if (value.Length < 8)
            {
                throw new ArgumentException("密碼至少需要8個字元");
            }
            _password = value;
        }
    }

    public void trySetName()
    {
        //UserName = "00000000001111111111"; // 這個會值出例外
        _userName = "00000000001111111111"; // 這個不會
    }
}