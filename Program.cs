using ICloseToHelp;
using Model;


namespace TestInterface
{
    public class Program
    {
        public static async Task A()
        {
           
            MyApi myApi = new MyApi();
            CityList cities = await myApi.GetAllCities();
            PersonList pl=await myApi.GetAllPersons();
            ReportList rList = await myApi.GetAllReports();
            Console.WriteLine(rList.Count);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            A();
            

        }
    }
}
