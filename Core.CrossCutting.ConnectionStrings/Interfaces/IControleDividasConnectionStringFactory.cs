using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCutting.ConnectionStrings.Interfaces
{
    public interface IControleDividasConnectionStringFactory
    {
        string GetConnectionString();
    }
}
