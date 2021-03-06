﻿using TeduShop.Model.Model;
using TeduShopData.Infratructure;

namespace TeduShopData.Repositoris
{
    public interface IMenuRepository
    {
    }

    public class MenuRepository : RepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}