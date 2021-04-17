using MSell.CRUDs.DAL.src.Repositories;
using MSell.CRUDs.Share.src.ENTITY;
using System.Collections.Generic;


namespace MSell.CRUDs.BL.src
{
    public class BoProduct
    {
        private ProductRepository _repository;
        public BoProduct()
        {
            _repository = new ProductRepository();
        }

        public IList<Product> GetAllProduct() => _repository.GetAll();
       
    }
}
