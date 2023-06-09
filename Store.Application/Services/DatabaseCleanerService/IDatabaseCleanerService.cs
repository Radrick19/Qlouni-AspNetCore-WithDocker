﻿using Store.Domain.Interfaces;
using Store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.Services.DatabaseCleanerService
{
    public interface IDatabaseCleanerService
    {
        Task DeleteUnactivatedUser(int userId);
        Task StartCleaner();
    }
}
