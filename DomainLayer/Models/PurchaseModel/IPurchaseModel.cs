﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.PurchaseModel
{
    public interface IPurchaseModel
    {
        int Id { get; set; }
        DateTime CreatedAt { get; set; }
    }
}
