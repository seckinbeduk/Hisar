﻿using Microsoft.Extensions.DependencyInjection;
using NetCoreStack.Data.Interfaces;

namespace NetCoreStack.Hisar.Server
{
    public abstract class HisarControllerServerBase : HisarControllerBase
    {
        private IMongoUnitOfWork _unitOfWork;
        public IMongoUnitOfWork UnitOfWork
        {
            get
            {
                if (_unitOfWork == null)
                    _unitOfWork = Resolver?.GetService<IMongoUnitOfWork>();

                return _unitOfWork;
            }
        }
    }
}