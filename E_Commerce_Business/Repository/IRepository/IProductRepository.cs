﻿using E_Commerce_Models;

namespace E_Commerce_Business.Repository.IRepository
{
    public interface IProductRepository
    {
        public Task<ProductDTO> Create(ProductDTO objDTO);
        public Task<ProductDTO> Update(ProductDTO objDTO);
        public Task<int> Delete(int id);
        public Task<ProductDTO> GetById(int id);//detay sayfası
        public Task<IEnumerable<ProductDTO>> GetAll();//Ürünleri listeleme için
        public Task<List<ProductDTO>> GetProductByCategoryId(int id);
    }
}
