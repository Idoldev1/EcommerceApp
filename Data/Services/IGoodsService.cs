using System;
using EcommerceApp.Models;

namespace EcommerceApp.Data.Services;

public interface IGoodsService
{
    Goods GetGoods(int Id);
    IEnumerable<Goods> GetAllGoods();
    Goods Add(Goods goods);
    Goods Update (int id, Goods updateGoods);
    Goods Delete (int id);
}