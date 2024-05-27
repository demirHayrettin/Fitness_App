using ProjectTask.DATA;

namespace ProjectTask.DAL.Repositories
{
    internal class OgunRepository : GenericRepository<Ogun>
    {
        public OgunRepository(AppDbContext context) : base(context)
        {
        }
    }
}
