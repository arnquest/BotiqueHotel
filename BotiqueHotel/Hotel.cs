using System;
using System.Collections.Generic;
using System.Text;

namespace BotiqueHotel.Model
{
    internal class Hotel
    {
        private Room[][] rooms;
       
        public Hotel()
        {

        }
        public void printRooms()
        {

        }
        public bool AssignRoom(int roomnumber)
        {
            return true;
        }
        public bool MarkRepair(int roomNo)
        {
            return true;
        }
        public bool MarkCleaned(int roomNo)
        {
            return true;
        }
        public bool CheckOut(int roomNo)
        {
            return true;
        }
        public List<string> GetAvailableRooms()
        { 
            List<string> availableRooms = new List<string>();

            return availableRooms;
        }
    }
}
