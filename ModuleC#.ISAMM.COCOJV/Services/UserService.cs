using ModuleC_.ISAMM.COCOJV.DTOs.UserDTOs;
using ModuleC_.ISAMM.COCOJV.Entities;
using ModuleC_.ISAMM.COCOJV.Repositories;

namespace ModuleC_.ISAMM.COCOJV.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public List<GetAllUserResponse> GetAll()
        {
            return _userRepository
                .GetAll()
                .Select(u => new GetAllUserResponse(u))
                .ToList();
        }

        public GetUserByIdResponse GetById(Guid id)
        {
            User user = _userRepository.GetById(id);
            if (user == null)
            {
                return null;
            }
            return new GetUserByIdResponse(user);
        }
        public void Create(CreateUserRequest request)
        {
            var user = new User(
            request.UserName,
            request.Password,
            request.Age,
            request.Email,
            request.Region
            );

            _userRepository.Add(user);
        }
        public bool Update(UpdateUserRequest request)
        {
            var user = _userRepository.GetById(request.Id);
            if (user == null)
            {
                return false;
            }

            if (!string.IsNullOrEmpty(request.UserName)) user.UserName = request.UserName;
            if (!string.IsNullOrEmpty(request.Password)) user.Password = request.Password;
            if (request.Age.HasValue) user.Age = request.Age.Value;
            if (!string.IsNullOrEmpty(request.Email)) user.Email = request.Email;
            if (!string.IsNullOrEmpty(request.Region)) user.Region = request.Region;

            user.UpdatedDate = DateTime.UtcNow;
            _userRepository.Update(user);
            return true;
        }
        public bool Delete(Guid id)
        {
            var user = _userRepository.GetById(id);
            if (user == null)
            {
                return false;
            }

            _userRepository.Delete(id);
            return true;
        }

    }
}
