﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SinavOlusturma.Core
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
