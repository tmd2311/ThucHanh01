using Bai1.Models;

namespace Bai1.Repository
{
    public class NgonNgu : INgonNgu
    {
        private readonly QlthuVienContext _context;
        public NgonNgu(QlthuVienContext context)
        {
            _context = context;
        }
        public TNgonNgu Add(TNgonNgu ngonNgu)
        {
            _context.TNgonNgus.Add(ngonNgu);
            _context.SaveChanges();
            return ngonNgu;
        }

        public TNgonNgu Delete(string maNgonNgu)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TNgonNgu> GetAllNgonNgu()
        {
            return _context.TNgonNgus;
        }

        public TNgonNgu GetNgonNgu(string maNgonNgu)
        {
            return _context.TNgonNgus.Find(maNgonNgu);
        }

        public TNgonNgu Update(TNgonNgu ngonNgu)
        {
            _context.TNgonNgus.Update(ngonNgu);
            _context.SaveChanges(true);
            return ngonNgu;
        }
    }
}
