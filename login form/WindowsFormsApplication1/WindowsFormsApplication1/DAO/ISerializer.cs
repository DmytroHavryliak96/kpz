﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.DAO
{
    public interface ISerializer<T>
    {
        string Serialize(List<T> input);
        List<T> Deserialize(string input);
    }
}
