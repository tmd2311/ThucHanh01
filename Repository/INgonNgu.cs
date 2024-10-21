using Bai1.Models;
namespace Bai1.Repository
{
    public interface INgonNgu
    {
        TNgonNgu Add(TNgonNgu ngonNgu);
        TNgonNgu Update(TNgonNgu ngonNgu);
        TNgonNgu Delete(string maNgonNgu);
        TNgonNgu GetNgonNgu(string maNgonNgu);
        IEnumerable<TNgonNgu> GetAllNgonNgu();
    }
}
