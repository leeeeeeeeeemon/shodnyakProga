using System;
using System.Collections.Generic;
using System.Text;

namespace Shodnyak.SQLite
{
     public interface ISQLite
    {
        string GetDatabasePath(string filename);
    }
}
