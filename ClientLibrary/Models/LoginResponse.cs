namespace ClientLibrary.Models
{
    public class LoginResponse
        (bool Success= false,
        string Message = null!,
        string Token = null!,
        string RefreshToken = null!
        );
}
