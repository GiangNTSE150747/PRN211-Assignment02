using FStoreAppLibrary.Data_Layer;
using FStoreAppLibrary.Models;
using System.Collections;

public class Program : FStoreContext
{
    public static void Main()
    {
        Member member = new Member
        {
            MemberId = 3,
            Email = "Emxample@gmail.com",
            CompanyName = "Fsoft",
            City = "HCM",
            Country = "Vietnam",
            Password = "123"
        };

        Console.WriteLine(MemberDBContext.Instance.Insert(member));
        Console.ReadLine();
        
    }
}