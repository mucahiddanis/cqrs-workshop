﻿using Microsoft.EntityFrameworkCore;
using OrderApi.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderApi.Data.Repositories.MsSql
{
    public interface IOrderRepository
    {
        Task Create(Order order);

        Task Update(Order order);

        Task<Order> Get(string orderCode);
    }

    public class OrderRepository : IOrderRepository
    {
        private readonly WorkshopDbContext _dbContext;

        public OrderRepository(WorkshopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(Order order)
        {
            _dbContext.Orders.Add(order);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Update(Order order)
        {
            _dbContext.Orders.Update(order);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Order> Get(string orderCode)
        {
            return await _dbContext.Orders.SingleOrDefaultAsync(x => x.OrderCode == orderCode);
        }
    }
}
