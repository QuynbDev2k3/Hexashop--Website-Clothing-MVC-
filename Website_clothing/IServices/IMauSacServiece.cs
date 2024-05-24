using Website_clothing.Models;

namespace Website_clothing.IServices
{
    public interface IMauSacServiece
    {
        public List<MauSac> GetAll();
        public bool Add(MauSac p);
        public bool Edit(Guid id, MauSac p);
        public bool Delete(Guid id);
    }
}
