using ProjectTask.DATA;

namespace ProjectTask.DAL.Repositories
{
    public class YemekPlaniOgesiRepository : GenericRepository<YemekPlaniOgesi>
    {
        public YemekPlaniOgesiRepository(AppDbContext context) : base(context)
        {
        }
    }
}
