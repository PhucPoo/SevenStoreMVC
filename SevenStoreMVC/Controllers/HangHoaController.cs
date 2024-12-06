using Microsoft.AspNetCore.Mvc;
using SevenStoreMVC.Data;
using SevenStoreMVC.ViewModels;
using System.Data.Common;

namespace SevenStoreMVC.Controllers
{
    public class HangHoaController : Controller
    {
        private readonly Hshop2023Context db;
        public HangHoaController(Hshop2023Context context) 
        { 
            db = context; 
        }
        public IActionResult Index(int? Loai)
        {
            var hangHoas = db.HangHoas.AsQueryable();
            if (Loai.HasValue)
            {
                hangHoas = hangHoas.Where(p => p.MaLoai == Loai.Value);
            }

            var result = hangHoas.Select(p => new HangHoaVM
            {
                MaHh = p.MaHh,
                TenHh = p.TenHh,
                DonGia = p.DonGia ?? 0,
                Hinh = p.Hinh ?? "",
                MoTaNgan = p.MoTaDonVi ?? "",
                TenLoai = p.MaLoaiNavigation.TenLoai
            });
            return View(result);
        }

        public IActionResult Search (String? query)
        {
            var hangHoas = db.HangHoas.AsQueryable();

            if(query!=null)
            {
                hangHoas = hangHoas.Where(p => p.TenHh.Contains(query));
            }

            var result = hangHoas.Select(p => new HangHoaVM
            {
                MaHh = p.MaHh,
                TenHh = p.TenHh,
                DonGia = p.DonGia ?? 0,
                Hinh = p.Hinh ?? "",
                MoTaNgan = p.MoTaDonVi ?? "",
                TenLoai = p.MaLoaiNavigation.TenLoai
            });
            return View(result);
        }
    }
}
