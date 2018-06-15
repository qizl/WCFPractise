using System.Collections.Generic;
using System.ServiceModel;
using WcfService.Models;

namespace WcfService
{
    [ServiceContract]
    public interface IStudentOperation
    {
        [OperationContract]
        List<Student> GetStudents();
    }
}
