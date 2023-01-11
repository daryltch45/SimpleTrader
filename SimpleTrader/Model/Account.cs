using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTrader.Model
{
  public class Account
  {
    public int id { get; set; }
    public User AccountHolder { get; set; }

    public double Balance { get; set; }
    public IEnumerable<AssetTransaction> AssetTransactions { get; set; }
  }
}
