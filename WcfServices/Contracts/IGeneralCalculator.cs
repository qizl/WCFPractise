using System.ServiceModel;

namespace Contracts
{
    [ServiceContract]
    public interface IGeneralCalculator
    {
        [OperationContract]
        double Add(double x, double y);
    }
}
