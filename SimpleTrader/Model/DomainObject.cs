using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTrader.Model
{
  /// <summary>
  /// Just to make sure that all our domains have an an id 
  /// They will all inheritate from this class
  /// </summary>
  public class DomainObject 
  {
    public int id { get; set; }
  }
}
