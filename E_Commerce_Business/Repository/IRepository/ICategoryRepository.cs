﻿using E_Commerce_Models;

namespace E_Commerce_Business.Repository.IRepository
{
    public interface ICategoryRepository
    {
        public Task<CategoryDTO> Create(CategoryDTO objDTO);
        public Task<CategoryDTO> Update(CategoryDTO objDTO);
        public Task<int> Delete(int id);
        public Task<CategoryDTO> GetById(int id);
        public Task<IEnumerable<CategoryDTO>> GetAll();

    }
}
