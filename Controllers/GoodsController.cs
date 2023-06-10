using EcommerceApp.Data;
using EcommerceApp.Data.Services;
using EcommerceApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApp.Controllers;

[Authorize]
public class GoodsController : Controller
{ 
    private readonly IGoodsService _service;
    private readonly ILogger logger;

    public GoodsController(IGoodsService service, ILogger<GoodsController> logger)
    {
         _service = service;
        this.logger = logger;
    }


    [AllowAnonymous]
    public IActionResult Index()
    {
        var data = _service.GetAllGoods();
        return View(data);
    }



    [HttpGet]
     public IActionResult Create()
    {
        return View();
    }



    [HttpPost]
    [Authorize]
    public IActionResult Create(Goods goods)
    {
        if (!ModelState.IsValid)
        {
            return View(goods);
        }
        _service.Add(goods);
        return RedirectToAction(nameof(Index));
    }




    [AllowAnonymous]
    public IActionResult Details(int? id)
    {
        var goodsDetails = _service.GetGoods(id ?? 1);
        if (goodsDetails == null)
        { 
            return View("Error");
        }
        return View(goodsDetails);
    }




    [HttpGet]
    [Authorize]
    public IActionResult Edit(int id)
    {
        var goodsDetails = _service.GetGoods(id);
        if (goodsDetails == null)
        { 
            return View("NotFound");
        }
        return View(goodsDetails);
    }



    [HttpPost]
    [Authorize]
    public IActionResult Edit(int id, Goods goods)
    {
        if (!ModelState.IsValid)
        {
            return View(goods);
        }
        _service.Update(id, goods);
        return RedirectToAction(nameof(Index));
    }
}