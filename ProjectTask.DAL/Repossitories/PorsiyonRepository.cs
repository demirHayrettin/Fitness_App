using ProjectTask.DATA;

namespace ProjectTask.DAL.Repositories
{
    internal class PorsiyonRepository : GenericRepository<Porsiyon>
    {
        public PorsiyonRepository(AppDbContext context) : base(context)
        {
        }
    }
}
