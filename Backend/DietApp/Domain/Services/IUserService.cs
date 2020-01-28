﻿using DietApp.Domain.Models;
using DietApp.Domain.Responses;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DietApp.Domain.Services
{
    public interface IUserService
    {
        Task<User> FindByEmail(string email);
        Task<User> FindById(int id);
        Task<User> FindByNickname(string nickname);
        Task<IEnumerable<User>> SearchUsers(string nickname, int userId);
        IEnumerable<User> FindByIdRange(IEnumerable<int> ids);
        Task<User> FindByIdIncludeFriendships(int id);
        int GetCurrentUserId(HttpContext httpContext);
        Task<IEnumerable<User>> List();
        Task<CreateUserResponse> Create(User user);
        Task<UpdateUserResponse> Update(User user);
        Task<UpdateUserResponse> UpdatePrivacy(int userId, bool isPrivate);
        Task<UpdateUserResponse> UpdateNutrientGoals(int userId, int calorieLimitLower, int calorieLimit, int calorieLimitUpper, int carbsLimitLower, int carbsLimit, int carbsLimitUpper, int fatLimitLower, int fatLimit, int fatLimitUpper, int proteinLimitLower, int proteinLimit, int proteinLimitUpper);
    }
}
