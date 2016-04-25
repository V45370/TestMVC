using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList;
using ModelsAndRepository;

namespace TestMVC.Models
{
    public class ProductsViewModel
    {        
        public IPagedList<artikul> Products { get; set; }


    }
}