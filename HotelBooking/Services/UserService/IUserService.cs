﻿using System;
using HotelBooking.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.Service.UserService
{
    public interface IUserService
    {
        public ActionResult<CreateUser> AddNewUser(CreateUser user);
        public User GetUser(Login login);
        public User GetUserById(int userId);
        public bool GeneratePasswordChangLink(string email);
        public bool CheckIfKeyValid(Key key);
        public bool ChangePassword(Login login);
    }
}
