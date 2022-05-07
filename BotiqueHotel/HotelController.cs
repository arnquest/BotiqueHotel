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
            return this.model.getAll();
        }

        public List<Room> getAvailableRooms()
        {
            return this.model.getAvailableRooms();
        }
        public bool checkIn(int roomId)
        {
            return this.model.checkIn(roomId);
        }
        public bool checkOut(int roomId)
        {
            return this.model.checkOut(roomId);
        }
        public bool setRoomAsCleaned(int roomId)
        {
            return this.model.setRoomAsCleaned(roomId);
        }
        public bool setRoomOOS(int roomId)
        {
            return this.model.SetOOS(roomId);
        }
        public bool setRoomAsRepaired(int roomId)
        {
            return this.model.setAsRepaired(roomId);
        }
    }
}
