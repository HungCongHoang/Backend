public class Vukhi : IDisposable
{
    public string name = "ten vu khi";
    int dosatthuong = 1;
    int a = 1;
    int b = 2;
    public Vukhi()
    {
        Console.WriteLine("da khoi tao");
    }
    public Vukhi(string name, int _dosatthuong)
    {
        this.name = name;
        dosatthuong = _dosatthuong;
    }

    public void tancong()
    {
        Console.Write(name + ": ");
        for (int i = 1; i <= dosatthuong; i++)
        {
            Console.Write(" * ");
        }
        Console.WriteLine();
    }

    public void Dispose()
    {
        Console.WriteLine("da huy");
    }
}
