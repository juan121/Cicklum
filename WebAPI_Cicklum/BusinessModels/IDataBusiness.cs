using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessModels
{
    public interface IDataBusiness
    {
        string Name { get; }
        IEnumerable<IDetailsDataBusiness> Details { get; set; }
    }
}
