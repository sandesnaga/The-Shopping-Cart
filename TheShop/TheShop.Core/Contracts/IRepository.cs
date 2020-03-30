﻿using System.Linq;
using TheShop.Core.Models;

namespace TheShop.Core.Contracts

{
    public interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> Collection();
        void Commit();
        void Delete(string Id);
        T Find(string Id);
        void Insert(T t);
        void Update(T t);
    }
}