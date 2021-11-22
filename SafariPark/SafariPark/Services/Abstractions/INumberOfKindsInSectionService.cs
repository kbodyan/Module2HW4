﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Models;

namespace SafariPark.Services.Abstractions
{
    public interface INumberOfKindsInSectionService
    {
        int[] NumberOfKindsInSection(Animal[] section);
    }
}
