﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Utilities.IoC
{
    public interface IBaseModule
    {
        void Load(IServiceCollection serviceCollection);
    }
}
