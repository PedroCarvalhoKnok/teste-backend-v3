﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheatricalPlayersRefactoringKata.Domain.Entities;

namespace TheatricalPlayersRefactoringKata.Domain.Interfaces
{
    public interface IPlayRepository
    {
        Task<Entities.Play> AddAsync(Entities.Play play);
    }
}
