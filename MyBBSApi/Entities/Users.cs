namespace MyBBSApi.Entities
{
    public class Users : BaseEntity
    {
       
        public string UserNo { get; set; }
        public string UserName { get; set; }
        public int UserLevel { get; set; }

        public string Password { get; set; }
    }
}