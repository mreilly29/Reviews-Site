﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite
{
    public interface IReviewRepository
    {
        List<Review> GetAll();
    }
}
