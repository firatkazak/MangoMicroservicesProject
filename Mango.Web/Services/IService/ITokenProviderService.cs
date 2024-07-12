namespace Mango.Web.Services.IService;

public interface ITokenProviderService
{
    void SetToken(string token);
    string GetToken();
    void ClearToken();
}
