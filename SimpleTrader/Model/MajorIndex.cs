using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTrader.Domain.Model
{
  public enum MajorIndexType
  {
    AAPL,
    FONR,
    MNKD
  }
  public class MajorIndex
  {
    public MajorIndexType Symbol { get; set; }
    public double Price { get; set; }
    public double Changes { get; set; }
  }
}