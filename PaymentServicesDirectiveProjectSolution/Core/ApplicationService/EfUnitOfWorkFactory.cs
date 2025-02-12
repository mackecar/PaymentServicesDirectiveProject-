﻿using Domain.Repositories;
using Infrastructure.DataAccess.EFDataAccess;
using Microsoft.EntityFrameworkCore.Storage;

namespace ApplicationService
{
    public class EfUnitOfWorkFactory : IUnitOfWorkFactory
    {
        public static IUnitOfWork CreateUnitOfWork()
        {
            IUnitOfWork unitOfWork = new EfUnitOfWork();
            return unitOfWork;
        }

        IUnitOfWork IUnitOfWorkFactory.CreateUnitOfWork()
        {
            return CreateUnitOfWork();
        }
    }
}
