﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace RentACar.Core.Utilities.IOC
{
    public interface ICoreModule
    {
        void Load(IServiceCollection serviceCollection);

    }
}
