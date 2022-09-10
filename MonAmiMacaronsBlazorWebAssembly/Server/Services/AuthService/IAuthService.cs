﻿namespace MonAmiMacaronsBlazorWebAssembly.Server.Services.AuthService
{
    public interface IAuthService
    {
        Task<ServiceResponse<string>> Login(string email, string password);
        Task<ServiceResponse<int>> Register(User user, string password);
        Task<bool> UserExists(string email);
        Task<ServiceResponse<bool>> ChangePassword(int userId, string newPassword);

    }
}
