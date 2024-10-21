using Bai1.Models;
using Bai1.Models.SanhModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc; 
namespace Bai1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SachAPIController : ControllerBase
    {
        QlthuVienContext db = new QlthuVienContext();
        [HttpGet]
        public IEnumerable<Sach> GetAllSach()
        {
            var sach = (from p in db.TSaches
                        select new Sach
                        {
                            MaSach = p.MaSach,
                            TenSach = p.TenSach,
                            MaNgonNgu = p.MaNgonNgu,
                            FileAnh = p.FileAnh
                        }).ToList();
            return sach;
        }

        [HttpGet("maNgonNgu")]
        public IEnumerable<Sach> GetAllSach(string maNgonNgu)
        {
            var sach = (from p in db.TSaches
                        where p.MaNgonNgu == maNgonNgu
                        select new Sach
                        {
                            MaSach = p.MaSach,
                            TenSach = p.TenSach,
                            MaNgonNgu = p.MaNgonNgu,
                            FileAnh = p.FileAnh
                        }).ToList();
            return sach;

        }




    }
}
