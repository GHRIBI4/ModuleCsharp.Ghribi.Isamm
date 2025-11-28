namespace ModuleC_.ISAMM.COCOJV.DTOs.UserDTOs
{
    public class UpdateUserRequest
    {
        public required Guid Id { get; set; }

        public string? UserName { get; set; }
        public string? Password { get; set; }
        public int? Age { get; set; }
        public string? Email { get; set; }
        public string? Region { get; set; }
    }
}
