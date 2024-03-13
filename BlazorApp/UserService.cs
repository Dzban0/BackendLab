namespace BlazorApp
{
    public class UserService
    {
        private Dictionary<string, string> _users = new Dictionary<string, string>();

        public void Add(string connectionId, string username)
        {
            _users[username] = connectionId;
        }

        public void RemoveByName(string username)
        {
            _users.Remove(username);
        }

        public string GetConnectioIdByName(string username)
        {
            return _users.ContainsKey(username) ? _users[username] : null;
        }

        public IEnumerable<(string ConnectionId, string Username)> GetAll()
        {
            return _users.Select(u => (u.Value, u.Key));
        }
    }
}
