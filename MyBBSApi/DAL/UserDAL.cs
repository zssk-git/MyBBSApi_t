using MyBBSApi.Entities;
using MyBBSApi.SqlContext;

namespace MyBBSApi.DAL
{
    public class UserDAL
    {
        DapperHelper _db = new DapperHelper();
        public Users GetUserByLogin(string userName,string Password){
            string sql = "Select * From Users Where UserName = @userName And Password = @password";
            var user = _db.QueryFirst<Users>(sql,new {userName,Password});
            if(user == null){
                return default;
            }
            else{
                return user;
            }
        }
        
    }
}