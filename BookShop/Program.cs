using BookShop.Services.Implementations.Base;
using BookShop.Services.Implementations.Books;

namespace BookShop
{
    public class Program
    {
        static void Main(string[] args)
        {
            BaseService<string> baseService = new BaseService<string>();
            baseService.Create("Sahin");
            baseService.Create("tail");
            baseService.Create("kamil");
            
            baseService.Delete();
            //baseService.Get();

        }
    }
}