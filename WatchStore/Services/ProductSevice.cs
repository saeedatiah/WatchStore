using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WatchStore.Models;

namespace WatchStore.Services
{
    public class ProductSevice
    {
        List<Product> _inMemoryProduct;
        public ProductSevice()
        {
            _inMemoryProduct = new List<Product>()
            {
                 new Product{Id=1, Name="aaa",Description="aaaaaaaa",ImgUrl="url",Price =100,Specifications="<h1>This is Specifications</h1>"},
            new Product{Id=1, Name="bbb",Description="bbbbbbbb",ImgUrl="url",Price =150,Specifications="<h1>This is Specifications</h1>"},
            new Product{Id=2, Name="ccc",Description="cccccccc",ImgUrl="url",Price =130,Specifications="<h1>This is Specifications</h1>"},
            new Product{Id=3, Name="ddd",Description="dddddddd",ImgUrl="url",Price =140,Specifications="<h1>This is Specifications</h1>"},
            new Product{Id=4, Name="eee",Description="eeeeeeee",ImgUrl="url",Price =800,Specifications="<h1>This is Specifications</h1>"},
            new Product{Id=5, Name="fff",Description="ffffffff",ImgUrl="url",Price =400,Specifications="<h1>This is Specifications</h1>"},
            new Product{Id=6, Name="ggg",Description="gggggggg",ImgUrl="url",Price =350,Specifications="<h1>This is Specifications</h1>"},
            new Product{Id=7, Name="hhh",Description="hhhhhhhh",ImgUrl="url",Price =190,Specifications="<h1>This is Specifications</h1>"},
            };
        }
        public List<Product> GetProducts() 
        {
            return _inMemoryProduct;

        }
        public Product GetProduct(int id) => _inMemoryProduct.FirstOrDefault(c => c.Id == id);

    }
}
