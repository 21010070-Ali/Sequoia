using System.Data;
using System.Security.Claims;

namespace RP.SOI.DotNet.Services;

public interface IAuthService
{
    bool Authenticate(string sql, 
                      string userId, 
                      string password, 
                  out ClaimsPrincipal? principal);
}

public class AuthService : IAuthService
{
    private readonly IDBService _dbSvc;
    public AuthService(IDBService dbSvc)
    {
        _dbSvc = dbSvc;
    }

    public bool Authenticate(string sql, string userId, string password,
                             out ClaimsPrincipal? principal)
    {
        principal = null;
        DataTable ds = _dbSvc.GetTable(sql, userId, password);
        if (ds.Rows.Count == 1)
        {
            principal =
               new ClaimsPrincipal(
                  new ClaimsIdentity(
                     new Claim[] {
                        new Claim(ClaimTypes.NameIdentifier, 
                                  ds.Rows[0][0].ToString()!),
                        new Claim(ClaimTypes.Name, 
                                  ds.Rows[0][1].ToString()!),
                        new Claim(ClaimTypes.Role, 
                                  ds.Rows[0][2].ToString()!)
                     }, "Basic"
                  )
               );
            return true;
        }
        return false;
    }
}
