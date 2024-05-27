using ProjectTask.DATA;

namespace ProjectTask.DAL.Repositories
{
    public class BesinRepository : GenericRepository<Besin>
    {
        public BesinRepository(AppDbContext context) : base(context)
        {
        }
    }
}