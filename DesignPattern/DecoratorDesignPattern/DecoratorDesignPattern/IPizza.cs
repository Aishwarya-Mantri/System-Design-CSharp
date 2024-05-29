﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public interface IPizza
    {
        public string GetPizzaType();
        public int GetCost();
    }
}
