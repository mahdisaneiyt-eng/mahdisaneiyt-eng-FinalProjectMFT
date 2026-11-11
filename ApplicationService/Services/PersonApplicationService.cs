using ApplicationService.Dtos;
using Model.DomainModels;
using Model.ServiceModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationService.Services
{
    public class PersonApplicationService
    {
        private readonly PersonServiceModel _personServiceModel;

        #region [- ctor -]
        public PersonApplicationService()
        {
            _personServiceModel = new PersonServiceModel();
        }
        #endregion

        #region [- GetAll() -]
        public List<GetPersonDto> GetAll()
        {
            var persons = _personServiceModel.SelectAll();
            var getPersonDtos = new List<GetPersonDto>();
            foreach (var item in persons)
            {
                var getPersondto = new GetPersonDto()
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                };
                getPersonDtos.Add(getPersondto);
            }
            return getPersonDtos;
        }
        #endregion

        #region [- Post(PostPersonDto dto) -]
        public void Post(PostPersonDto dto)
        {
            var person = new Person()
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
            };
            _personServiceModel.Insert(person);
        }
        #endregion

        #region [- Put(PutPersonDto dto) -]
        public void Put(PutPersonDto dto)
        {
            var person = new Person()
            {
                Id = dto.Id,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
            };
            _personServiceModel.Update(person);
        }
        #endregion

        #region [- Delete(int id) -]
        public void Delete(int id)
        {
            _personServiceModel.Delete(id);
        }
        #endregion
    }
}
