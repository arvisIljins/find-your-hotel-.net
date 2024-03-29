﻿using System.Collections.Generic;
using System.Threading.Tasks;
using HotelBooking.Models;

namespace HotelBooking.Service.HotelService
{
    public interface IHotelService
    {
        public Task<ServiceResponse<List<Hotel>>> GetHotelsList();
        public Task<ServiceResponse<Hotel>> GetHotelById(int placeId);
        public Task<ServiceResponse<Hotel>> Add(Hotel place);
        
    }
}
