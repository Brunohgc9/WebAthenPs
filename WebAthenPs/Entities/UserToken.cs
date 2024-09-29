namespace WebAthenPs.API.Entities
{
    public class UserToken
    {
        public string? Token {  get; set; }
        public DateTime TokenExpiration { get; set; }
        public Guid UserId { get; set; } // Adicione esta linha

    }
}
