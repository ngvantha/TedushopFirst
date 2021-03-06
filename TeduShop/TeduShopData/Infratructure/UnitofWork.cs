﻿namespace TeduShopData.Infratructure
{
    public class UnitofWork : IUnitofWork
    {
        private readonly IDbFactory dbFactory;
        private TeduShopDbContext dbContext;

        public UnitofWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public TeduShopDbContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}