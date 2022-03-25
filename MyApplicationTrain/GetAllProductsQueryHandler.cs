using DataAccess.Models;
using DataAccess.Repository.Interfaces;
using MediatR;

namespace MyApplicationTrain
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<User>>
    {
        private readonly IUserActionRepository _userRepo;

        public GetAllProductsQueryHandler(IUserActionRepository userRepo)
        {
            _userRepo = userRepo;
        }
        public Task<List<User>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var users = Task.Run( ()  => _userRepo.GetAllTask());
            return  users;
        }
    }
}
