using Almacén.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Attendance.Services
{
    public abstract class ServiceBase<T> where T : class
    {
        private AlmacénContext db;
        protected readonly IDbSet<T> dbset;

        protected AlmacénContext DBContext
        {
            get { return db ?? (db = new AlmacénContext()); }
        }

        protected ServiceBase()
        {
            db = new AlmacénContext();
            dbset = DBContext.Set<T>();
        }

        protected ServiceBase(AlmacénContext dbContext)
        {
            this.db = dbContext;
            dbset = DBContext.Set<T>();
        }

        public void Dispose()
        {
            this.db.Dispose();
        }
    }
}