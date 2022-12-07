using NikhilBook.DataAccess.Repository.IRepository;
using NikhilBook.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NikhilBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]


        public class CategoryController : Controller
        {
            private readonly IUnitOfWork _unitOfWork;

            public CategoryController(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }

            public IActionResult Index()
            {
                return View();
            }
            #region
            [HttpGet]
            public IActionResult GetAll()
            {
                var allObj = _unitOfWork.Category.GetAll();
                return Json(new { data = allObj });
            }
            #endregion

        }
    
}
