using ProjectTask.DATA;

namespace ProjectTask.DAL.Repositories
{
    public class YemekKategoriRepository : GenericRepository<YemekKategori>
    {
        public YemekKategoriRepository(AppDbContext context) : base(context)
        {
        }
    }
}
