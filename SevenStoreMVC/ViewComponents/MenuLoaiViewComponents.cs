using SevenStoreMVC.Data;
using Microsoft.AspNetCore.Mvc;
using SevenStoreMVC.ViewModels;
using NuGet.Protocol.Core.Types;

namespace SevenStoreMVC.ViewComponents
{
    public class MenuLoaiViewComponent: ViewComponent
    {
        private readonly Hshop2023Context db;
        public MenuLoaiViewComponent(Hshop2023Context context) => db = context;

        public IViewComponentResult Invoke()
        {
            var data = db.Loais.Select(lo => new MenuLoaiVm
            {
                MaLoai = lo.MaLoai,
                Tenloai = lo.TenLoai,
                Soluong = lo.HangHoas.Count
            }).OrderBy(p => p.Tenloai);
            
            return View(data);
        }
    }
}
