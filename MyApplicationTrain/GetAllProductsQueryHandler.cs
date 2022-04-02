using DataAccess.Models;
using DataAccess.Repository.Interfaces;
using MediatR;

namespace MyApplicationTrain
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<Person>>
    {
        private readonly IUserActionRepository _userRepo;

        public GetAllProductsQueryHandler(IUserActionRepository userRepo)
        {
            _userRepo = userRepo;
        }
        public Task<List<Person>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var Persons = Task.Run( ()  => _userRepo.GetAllTask());
            return Persons;
        }
    }
}
