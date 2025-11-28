using ModuleC_.ISAMM.COCOJV.Entities;

namespace ModuleC_.ISAMM.COCOJV.Repositories
{
    public class UserRepository : BaseRepository<User>
    {
        private static List<User> _users = new();

        public void Add(User user)
        {
            user.Id = Guid.NewGuid();
            user.CreatedDate = DateTime.UtcNow;
            user.UpdatedDate = DateTime.UtcNow;
            _users.Add(user);
        }
        public void Update(User user)
        {
            var index = _users.FindIndex(u => u.Id == user.Id);
            if (index != -1)
            {
                _users[index] = user;
            }
        }
        public void Delete(Guid id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                _users.Remove(user);
            }
        }




    }
}
