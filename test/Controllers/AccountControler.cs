using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Linq;
using test.Contracts;
using test.Entities;
using test.Entities.DataTransferObjects;
using test.Entities.Models;
namespace test.Controllers
{
    [Route("account/[owner]")]
    [Microsoft.AspNetCore.Mvc.ApiController]
    public class AccountControler : ControllerBase
    {
        private ILoggerManager _logger;
        private IRepositoryWrapper _repository;

        private IMapper _mapper;

        public AccountControler(ILoggerManager logger, IRepositoryWrapper repository, IMapper mapper)
        {
            _logger = logger;
            _repository = repository;
            _mapper = mapper;
        }
        
[HttpGet]
        public IActionResult GetAccountsForOwner(Guid ownerId, [FromQuery] AccountParameters parameters)
        {
            var accounts = _repository.Account.GetAllOwners(ownerId, parameters);

            var metadata = new {
                accounts.TotalCount,
                accounts.PageSize,
                accounts.CurrentPage,
                accounts.TotalPages,
                accounts.HasNext,
                accounts.HasPrevious
            };

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metadata));

            _logger.LogInfo($"Returned {accounts.TotalCount} owners from database.");

            return Ok(accounts);
        }
    }
}
