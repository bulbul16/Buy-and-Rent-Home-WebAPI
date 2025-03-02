﻿using BuyandRentHomeWebAPI.Dtos;
using BuyandRentHomeWebAPI.Models;
using System.Threading.Tasks;

namespace BuyandRentHomeWebAPI.Services.Interfaces
{
    public interface IUserService
    {
        Task<User> Authenticate(LoginRequestDto loginRequest);
        LoginResponseDto CreateLoginCredintials(User user);
        Task<bool> UserAlreadyExists(string userName);
        Task<bool> Register(RegisterDto register);
    }
}
