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
        public bool checkIn(int roomId)
        {
            return model.checkIn(roomId);
        }
        public bool checkOut(int roomId)
        {
            return model.checkOut(roomId);
        }
        public bool setRoomAsCleaned(int roomId)
        {
            return model.setRoomAsCleaned(roomId);
        }
        public bool setRoomOOS(int roomId)
        {
            return model.SetOOS(roomId);
        }
        public bool setRoomAsRepaired(int roomId)
        {
            return model.setAsRepaired(roomId);
        }
    }
}
