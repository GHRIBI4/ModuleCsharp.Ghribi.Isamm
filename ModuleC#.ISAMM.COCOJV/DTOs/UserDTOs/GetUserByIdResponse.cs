using ModuleC_.ISAMM.COCOJV.Entities;

namespace ModuleC_.ISAMM.COCOJV.DTOs.UserDTOs
{
    public class GetUserByIdResponse
    {
        public GetUserByIdResponse( User user)
        {
            Id = user.Id;
            UserName = user.UserName;
            age = user.Age;
            Email = user.Email!;
            Region = user.Region!;
            CreatedDate = user.CreatedDate;
            UpdatedDate = user.UpdatedDate;
        }
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public int age { get; set; }
            
        public string Email { get; set; }
        public string Region { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
