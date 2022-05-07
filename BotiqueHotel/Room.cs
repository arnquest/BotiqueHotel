using System;

namespace BotiqueHotel.Model
{
    [Flags]
    public enum ROOM_STATUS
    {
        Available,  // 0
        Occupied,   // 1
        Vacant,     // 2
        Repair,     // 3
        Unknown     // 4
    }
    public class Room
    {

        public int roomId { get; set; }
        public string roomNumber { get; set; }
        public ROOM_STATUS status { get; set; }

        public Room()
        {
            this.roomId = 0;
            this.roomNumber = "";
            this.status = ROOM_STATUS.Unknown;
        }

        //Override the toString method, which can be converted to output room information
        public String toString()
        {
            //ternary operator
            return "[Room Id: " + this.roomId + ",Room Number: " + this.roomNumber + ", Status: " + this.status + "]";
        }
    }
}
