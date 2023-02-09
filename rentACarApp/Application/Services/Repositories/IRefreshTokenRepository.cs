﻿using Freezone.Core.Persistence.Repositories;
using Freezone.Core.Security.Entities;

namespace Application.Services.Repositories;

public interface IRefreshTokenRepository : IAsyncRepository<RefreshToken>, IRepository<RefreshToken>
{
    
}