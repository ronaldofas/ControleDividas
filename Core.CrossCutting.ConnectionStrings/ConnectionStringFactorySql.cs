using System;

namespace Core.CrossCutting.ConnectionStrings
{
    public class ConnectionStringFactorySql
    {
        public string GetConnectionString()
        {
            return @"Data Source = localhost; Initial Catalog = ControleDividas; user id = ControleDividas; password = Controles10@; persist security info = True; Connect Timeout = 200; MultipleActiveResultsSets = True; ";
        }
    }
}
