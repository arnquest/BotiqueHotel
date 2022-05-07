using System;
using System.Collections.Generic;
using System.Text;
using BotiqueHotel.Model;

namespace BotiqueHotel.Controller
{
    public class HotelController
    {
        private RoomList model;
        public HotelController()
        {
            model = new RoomList();
        }
        public List<Room> getAllRooms()
        {
            return model.getAll();
        }

        public List<Room> getAvailableRooms()
        {
            return model.getAvailableRooms();
        }
    }
}
