namespace TestMVC.Models
{
    using System.Collections.Generic;
    using PagedList;
    using ModelsAndRepository;

    public class ProductsViewModel
    {       
        public IPagedList<artikul> Products { get; set; }
        public List<vid> Categories { get; set; }
    }
}