﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponsManagement.Data.Repository.Interfaces;

public interface IGenericPersist
{
    void Add<T>(T entity) where T : class;
    void UpDate<T>(T entity) where T : class;
    void Delete<T>(T entity) where T : class;
    bool SaveChanges();
}
