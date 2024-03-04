using RGO.Models;

namespace RGO.DataAccess.Repository.IRepository
{
    public interface IRGO_OutputRepository : IRepository<RGOutput>
    {
        void Update(RGOutput obj);
    }
}

