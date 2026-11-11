using ApplicationService.Dtos;
using Model.DomainModels;
using Model.ServiceModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationService.Services
{
    public class ProductApplicationService
    {
        private readonly ProductServiceModel _productServiceModel;

        #region [- ctor -]
        public ProductApplicationService()
        {
            _productServiceModel = new ProductServiceModel();
        }
        #endregion

        #region [- GetAll() -]
        public List<GetProductDto> GetAll()
        {
            var products = _productServiceModel.SelectAll();
            var getProductDtos = new List<GetProductDto>();
            foreach (var item in products)
            {
                var getProductDto = new GetProductDto()
                {
                    Id = item.Id,
                    Code = item.Code,
                    Title = item.Title,
                    UnitPrice = item.UnitPrice,
                    Quantity = item.Quantity,
                };
                getProductDtos.Add(getProductDto);
            }
            return getProductDtos;
        }
        #endregion

        #region [- Post(PostProductDto dto) -]
        public void Post(PostProductDto dto)
        {
            var product = new Product()
            {
                Code = dto.Code,
                Title = dto.Title,
                UnitPrice = dto.UnitPrice,
                Quantity = dto.Quantity,
            };
            _productServiceModel.Insert(product);
        }
        #endregion

        #region [- Put(PutProductDto dto) -]
        public void Put(PutProductDto dto)
        {
            var product = new Product()
            {
                Id = dto.Id,
                Code = dto.Code,
                Title = dto.Title,
                UnitPrice = dto.UnitPrice,
                Quantity = dto.Quantity,
            };
            _productServiceModel.Update(product);
        }
        #endregion

        #region [- Delete(int id) -]
        public void Delete(int id)
        {
            _productServiceModel.Delete(id);
        }
        #endregion
    }
}
