using System;
using EcommerceApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceApp.Data.Services;

public class GoodsService : IGoodsService
{
    private readonly AppDbContext context;
    private readonly ILogger<GoodsService> logger;

    public GoodsService(AppDbContext context,
                        ILogger<GoodsService> logger)
    {
        this.context = context;
        this.logger = logger;
    }


    public Goods Add(Goods goods)
    { 
        context.GoodsTable.Add(goods);
        context.SaveChanges();
        return goods; 
    }



    public Goods Delete(int id)
    {
        Goods goods = context.GoodsTable.Find(id);
        if(goods != null)
        {
            context.GoodsTable.Remove(goods);
            context.SaveChanges();
        }
        return goods;
    }



    public IEnumerable<Goods> GetAllGoods()
    {
         return context.GoodsTable;
    }



    public Goods GetGoods(int Id)
    {
        return context.GoodsTable.Find(Id);
    }


    

    public Goods Update(int id, Goods updateGoods)
    {
         var goods = context.GoodsTable.Attach(updateGoods);
         goods.State = EntityState.Modified;
         context.SaveChanges();
         return updateGoods;
    }
}