using BusinessModels;

namespace Repository
{
    public class DataRepo: IDataRepo
    {
        public IDataBusiness DataBusiness { get; set; }
        public DataRepo(IDataBusiness _dataBusiness)
        {
            DataBusiness = _dataBusiness;
        }
        public IDataBusiness GetData()
        {
            return DataBusiness;
        }
    }
}
