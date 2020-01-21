using System;
using System.Collections.Generic;
using System.Text;
using static BusinessModels.Utilities;

namespace BusinessModels
{
    public interface IDetailsDataBusiness
    {
        TypeEnum Type { get; set; }
        int NumStaf { get; set; }
    }
}
