using ProjectTask.DATA;

namespace ProjectTask.DAL.Repositories
{
    public class YemekRepository : GenericRepository<Yemek>
    {
        public YemekRepository(AppDbContext context) : base(context)
        {
        }
    }
}
