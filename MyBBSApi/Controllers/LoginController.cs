using Microsoft.AspNetCore.Mvc;
using MyBBSApi.DAL;
using MyBBSApi.Entities;

namespace MyBBSApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController:ControllerBase
    {
        [HttpGet("{n}-{p}")]
        public Users GetUser(string n,string p){
            var user = new UserDAL().GetUserByLogin(n,p);
        return new UserDAL().GetUserByLogin(n,p);
        }
    }
}