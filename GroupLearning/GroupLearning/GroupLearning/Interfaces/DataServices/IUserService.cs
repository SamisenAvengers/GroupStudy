﻿using GroupLearning.Models;

namespace GroupLearning.Interfaces.DataServices;

public interface IUserService
{
    Task<User> GetUserByEmail(string email);
    Task<User> GetUserByPhoneNumber(string phoneNumber);
    Task<User> GetUserByCredentialsAsync(string email, string password);
    Task<User> GetUserByIdAsync(int id);
    Task<IEnumerable<User>> GetAllUsersAsync();
    Task<User> CreateUserAsync(User user);
    Task<User> UpdateUserAsync(User user);
    Task<bool> DeleteUserAsync(int id);
}
