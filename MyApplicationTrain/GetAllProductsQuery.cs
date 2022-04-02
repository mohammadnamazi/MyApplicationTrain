using DataAccess.Models;
using MediatR;

namespace MyApplicationTrain
{
    public class GetAllProductsQuery : IRequest<List<Person>>
    {
    }
}
