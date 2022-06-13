﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSecondTry.Data.DAL.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        public List<T> GetAll();
        public T GetSingle(Func<T, bool> condition);
        public void Add(T entity);
        public void Edit(T entity);
        public void Delete(T entity);
        public void Sort();
        public void Save();
    }
}
