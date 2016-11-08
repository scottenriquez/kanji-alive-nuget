﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using KanjiAlive.Models.Response;

namespace KanjiAlive.Http
{
    public interface IConnection
    {
        Task<T> Get<T>(Uri uri);
    }
}
