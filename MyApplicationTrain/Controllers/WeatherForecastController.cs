using DataAccess;
using DataAccess.Models;
using DataAccess.Repository;
using DataAccess.Repository.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyApplicationTrain.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ISender _mediator;

        private readonly IUnitOfWork _unitOfWork;
        public WeatherForecastController(IUnitOfWork unitOfWork, ISender mediator)
        {
            _unitOfWork = unitOfWork;
            _mediator = mediator;
        }

        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet,ActionName("get")]
        public IEnumerable<User> Get()
        {
            var courses = _unitOfWork.UserAction.GetAll();

            return courses;
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
        public void Update(User user)
        {
            _unitOfWork.UserAction.Update(user);
            _unitOfWork.Save();
        }

        [HttpPost]
        public void Add(User user)
        {
            _unitOfWork.UserAction.Add(user);
            _unitOfWork.Save();
        }
    }
}

