namespace ModuleC_.ISAMM.COCOJV.DTOs.UserDTOs
{
    public class CreateUserRequest
    {
        public required string UserName { get; set; }
        public required string Password { get; set; }
        public int Age { get; set; }
        public string? Email { get; set; }
        public string? Region { get; set; }
    }
}
