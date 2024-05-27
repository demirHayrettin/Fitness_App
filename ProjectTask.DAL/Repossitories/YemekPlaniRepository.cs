using ProjectTask.DATA;

namespace ProjectTask.DAL.Repositories
{
    public class YemekPlaniRepository : GenericRepository<YemekPlani>
    {
        public YemekPlaniRepository(AppDbContext context) : base(context)
        {
        }
    }
}
