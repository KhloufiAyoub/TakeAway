﻿using TakeAway.Models;

namespace TakeAway.DAL.Interfaces
{
    public interface IUserDAL
    {
        Task<User> GetUserAsync(string email, string password);
        Task<bool> CreateAsync(Client c);
        Task<bool> CreateAsync(RestaurantOwner r);
        Task<Client> GetClientAsync(int userId);
        Task<RestaurantOwner> GetRestaurantOwnerAsync(int userId);
    }
}
