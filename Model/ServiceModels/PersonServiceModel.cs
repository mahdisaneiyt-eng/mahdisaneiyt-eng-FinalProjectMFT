using Model.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.ServiceModels
{
    public class PersonServiceModel
    {
        #region [- SelectAll() -]
        public List<Person> SelectAll()
        {
            using (var context = new ProjectDbContext())
            {
                try
                {
                    var persons = context.Person.ToList();
                    return persons;
                }
                catch (Exception)
                {
                    throw;
                }
                finally { }
            }
        }
        #endregion

        #region [- Insert(Person person) -]
        public void Insert(Person person)
        {
            using (var context = new ProjectDbContext())
            {
                try
                {
                    context.Person.Add(person);
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
                finally { }
            }
        }
        #endregion

        #region [- Update(Person person) -]
        public void Update(Person person)
        {
            using (var context = new ProjectDbContext())
            {
                try
                {
                    context.Person.Update(person);
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
                finally { }
            }
        }
        #endregion

        #region [- Delete(int id) -]
        public void Delete(int id)
        {
            using (var context = new ProjectDbContext())
            {
                try
                {
                    var person = context.Person.Find(id);
                    if (person != null)
                    {
                        context.Person.Remove(person);
                        context.SaveChanges();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally { }
            }
        }
        #endregion
    }
}
