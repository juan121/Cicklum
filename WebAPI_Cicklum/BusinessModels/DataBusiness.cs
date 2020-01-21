using System;
using System.Collections.Generic;

namespace BusinessModels
{
    public class DataBusiness: IDataBusiness
    {
        public string Name { get; } = "NewBusiness";

        public IEnumerable<IDetailsDataBusiness> Details { get; set; } = new List<DetailsDataBusiness>() {
                new DetailsDataBusiness() { NumStaf = 50, Type = Utilities.TypeEnum.Commercial },
                new DetailsDataBusiness() { NumStaf = 60, Type = Utilities.TypeEnum.Commercial },
                new DetailsDataBusiness() { NumStaf = 70, Type = Utilities.TypeEnum.Commercial }
        };
    }
}
