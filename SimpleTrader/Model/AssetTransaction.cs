﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTrader.Model
{
  public class AssetTransaction : DomainObject
  {
    public int id { get; set; }
    public Account Account { get; set; }
    public bool IsPurchase { get; set; }
    public Stock Stock { get; set; }
    public int Shares { get; set; }
    public DateTime DateProcessed { get; set; }
  }
}
