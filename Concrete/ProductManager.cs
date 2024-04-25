﻿using shopapp.business.Abstract;
using shopapp.data.Abstract;
using shopapp.data.Concrete.EfCore;
using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopapp.business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }
        public void Create(Product entity)
        {
            //yoxlamalar
            _productRepository.Create(entity);
        }

        public void Delete(Product entity)
        {
            //yoxlamalar
            _productRepository.Delete(entity);
        }

        public List<Product> GetAll()
        {
            //yoxlamalar
            return _productRepository.GetAll();
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public Product GetProductDetails(string url)
        {
            return _productRepository.GetProductDetails(url);
        }

        public List<Product> GetProductsByCategory(string name)
        {
            return _productRepository.GetProductsByCategory(name);
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
