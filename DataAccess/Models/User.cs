namespace DataAccess.Models
{
    public class User
    {
        public int? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? UserGroupId { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public DateTime? CreationDateTime { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
    }
}
