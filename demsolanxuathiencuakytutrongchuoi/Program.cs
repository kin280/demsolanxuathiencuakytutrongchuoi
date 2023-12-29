internal class Program
{
    private static void Main(string[] args)
    {
        string str = "hello, work";

        Console.Write("nhap mot ky tu:");

        char dem = Console.ReadLine()[0];


        int count = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == dem)
            {

                count++;



            }

        }
        Console.WriteLine($"Số lần xuất hiện của ký tự '{dem}' trong chuỗi là: {count}");

    }
}