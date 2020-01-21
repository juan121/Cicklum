using static BusinessModels.Utilities;

namespace BusinessModels
{
    public class DetailsDataBusiness : IDetailsDataBusiness
    {
        public TypeEnum Type { get; set; } = TypeEnum.Industrial;
        public int NumStaf { get; set; } = 100;
    }
}
    