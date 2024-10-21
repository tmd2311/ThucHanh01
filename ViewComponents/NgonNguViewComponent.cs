using Bai1.Models;
using Bai1.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
namespace Bai1.ViewComponents
{
    public class NgonNguViewComponent : ViewComponent
    {
        private readonly INgonNgu _ngonNgu;
        public NgonNguViewComponent(INgonNgu ngonNgu)
        {
            _ngonNgu = ngonNgu;
        }   
        public IViewComponentResult Invoke()
        {
            var ngonNgu = _ngonNgu.GetAllNgonNgu().OrderBy(x => x.MaNgonNgu);
            return View(ngonNgu);
        }
    }
}
