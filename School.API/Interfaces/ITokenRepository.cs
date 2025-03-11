
using School.MODEL;

namespace School.API.Interfaces
{
    public interface ITokenRepository
    {
        string CreateJwtToken(AuthUser user, List<string> roles);
    }
}
