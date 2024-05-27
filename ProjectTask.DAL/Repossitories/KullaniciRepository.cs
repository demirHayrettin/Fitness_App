using ProjectTask.DATA;

namespace ProjectTask.DAL.Repositories
{
    internal class KullaniciRepository : GenericRepository<Kullanici>
    {
        public KullaniciRepository(AppDbContext context) : base(context)
        {
        }
    }
}