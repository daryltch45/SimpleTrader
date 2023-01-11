using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTrader.Model
{
  public class User : DomainObject
  {
    public int Id { get; set; }
    public string Email { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public DateTime Datejoined { get; set; }
  }
}
