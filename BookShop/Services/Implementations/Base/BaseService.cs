using BookShop.Services.Interfaces.BaseInterface;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BookShop.Services.Implementations.Base
{
    internal class BaseService<T> : IBaseInterface
    {



        public T[] products;
        public BaseService()
        {
            products = new T[0];
        }



        public void Create(T element)
        {
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = element;

        }

        public void Delete()
        {
            foreach (var product in products)
            {
                break;
            }
        }


        public void Get()
        {

            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }


    }
}
