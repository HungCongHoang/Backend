// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        using (Vukhi sungluc = new Vukhi())
        {
            sungluc.name = "sung luc";
            sungluc.tancong();

        };
        Vukhi sungmay = new Vukhi("Sung may", 5);
        // sungmay.tancong();
    }
}
