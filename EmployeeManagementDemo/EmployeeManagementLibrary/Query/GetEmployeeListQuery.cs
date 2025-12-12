using EmployeeManagementLibrary.Models;
using MediatR;
namespace EmployeeManagementLibrary.Query
{
    public class GetEmployeeListQuery:IRequest<List<EmployeeModel>>;
    
}
