using FStoreAppLibrary.Data_Layer;
using FStoreAppLibrary.Data_Layer.Repository;
using FStoreAppLibrary.Models;

public class Program : FStoreContext
{
    public static void Main()
    {
        IMemberRepository memberRepository = new MemberRepository();
        if (((MemberRepository)memberRepository).CheckExistAdmin("GiangNTSE@gmail", "123"))
        {
            Console.WriteLine("Dungs");
        }
        else
        {
            Console.WriteLine("Sai");
        }
        Console.ReadLine();
    }
}