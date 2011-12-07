using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ContinueEventArgs
/// </summary>
public class ContinueEventArgs : EventArgs
{
    public string AccountNumber { get; set; }
    public char AccountLetter { get; set; }
}