using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SevenStoreMVC.Data;
using SevenStoreMVC.Helpers;
using SevenStoreMVC.ViewModels;

namespace SevenStoreMVC.Controllers
{
    public class KhachHangController : Controller
    {
        private readonly Hshop2023Context db;
        private readonly IMapper _mapper;

        public KhachHangController(Hshop2023Context context, IMapper mapper) { 
            db = context;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult DangKy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DangKy(RegisterVM model)
        {
            if (ModelState.IsValid) 
            {
                var khachHang = _mapper.Map<KhachHang>(model);
                khachHang.RandomKey = Util.GenerateRamdomKey();
            }
            return View();
        }
    }
}
