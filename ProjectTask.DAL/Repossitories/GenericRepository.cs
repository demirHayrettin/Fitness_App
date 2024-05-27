using Microsoft.EntityFrameworkCore;

namespace ProjectTask.DAL.Repositories
{
    public class GenericRepository<TEntity> where TEntity : class, new()
    {
        private readonly AppDbContext context;

        public GenericRepository(AppDbContext context)
        {
            this.context = context;
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

