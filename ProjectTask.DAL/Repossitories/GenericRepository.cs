using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTask.DAL.Repossitories
{
    internal class GenericRepository<TEntity> where TEntity : class, new()
    {
        public AppDbContext context;

        public GenericRepository()
        {
            context = new AppDbContext();
        }

        //GetAll
        public List<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }

        //GetById
        public TEntity GetById(int id)
        {
            try
            {
                return context.Set<TEntity>().Find(id);
            }
            catch (Exception)
            {

                throw new Exception("Aranılan kayıt bulunamadı");
            }
        }

        //Add
        public int Add(TEntity entity)
        {
            try

            {
                context.Set<TEntity>().Add(entity);

                return context.SaveChanges();

            }
            catch (Exception)
            {
                throw new Exception("Ekleme işlemi başarısız oldu!");

            }

        }
        // Update
        public int Update(TEntity entity)
        {
            try
            {
                context.Set<TEntity>().Update(entity);

                return context.SaveChanges();
            }

            catch (Exception)
            {

                throw new Exception("Güncelleme işlemi başarısız oldu");
            }
        }

        // Delete

        public int Delete(int id)
        {
            try
            {
                //TEntity deleteEntity = context.Set<TEntity>().Find(id);

                TEntity deleteEntity = GetById(id);

                context.Set<TEntity>().Remove(deleteEntity);
                return context.SaveChanges();
            }
            catch (Exception)
            {

                throw new Exception("Silme işlemi başarısız oldu!");
            }

        }

    }
}
