using AutoMapper;
using DataAccess;
using DataAccess.Models;
using DataAccess.Repository;
using DataAccess.Repository.Interfaces;
using DataAccess.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyApplicationTrain.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController : ControllerBase
    {

        private readonly ISender _mediator;

        private readonly IUnitOfWork _unitOfWork;
        public readonly IMapper _mapper;
        public UserController(IUnitOfWork unitOfWork, ISender mediator , IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mediator = mediator;
            _mapper = mapper;
        }

        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet,ActionName("get")]
        public IEnumerable<Person> Get()
        {
            return _unitOfWork.UserAction.GetAll();
        }


        [HttpGet, ActionName("getAll")]
        public async Task<IActionResult> GetAll()
        {
            var products = await _mediator.Send(new GetAllProductsQuery());
            return Ok(products);
        }

        [HttpDelete]
        public void Remove(int id)
        {
            _unitOfWork.UserAction.Remove(id);
            _unitOfWork.Save();
        }

        [HttpPut]
        public void Update(Person user)
        {

            _unitOfWork.UserAction.Update(user);
            _unitOfWork.Save();
        }

        [HttpPost]
        public void Add(PersonViewModel user)
        {
            Person person = _mapper.Map<Person>(user);
            _unitOfWork.UserAction.Add(person);
            _unitOfWork.Save();
           
        }
    }
}

