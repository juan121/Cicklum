using BusinessModels;

namespace Repository
{
    public interface IDataRepo
    {
        //IDetailsDataBusiness Details { get; set; }
        IDataBusiness DataBusiness { get; set; }
        IDataBusiness GetData();
    }
}
