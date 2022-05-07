using System;
using System.Collections.Generic;
using System.Linq;

namespace BotiqueHotel.Model
{

    public class RoomList
    {
        private List<Room> _roomList;

        public RoomList()
        {
            this._roomList = new List<Room>();

            Room rm = new Room();
            rm.roomId = 1;
            rm.roomNumber = "1A";
            rm.status = ROOM_STATUS.Available;
            Add(rm);

            Room rm2 = new Room();
            rm2.roomId = 2;
            rm2.roomNumber = "1B";
            rm2.status = ROOM_STATUS.Occupied;
            Add(rm2);

            Room rm3 = new Room();
            rm3.roomId = 3;
            rm3.roomNumber = "1C";
            rm3.status = ROOM_STATUS.Occupied;
            Add(rm3);

            Room rm4 = new Room();
            rm4.roomId = 4;
            rm4.roomNumber = "1D";
            rm4.status = ROOM_STATUS.Vacant;
            Add(rm4);

            Room rm5 = new Room();
            rm5.roomId = 5;
            rm5.roomNumber = "1E";
            rm5.status = ROOM_STATUS.Available;
            Add(rm5);
        }
        public void Add(Room r)
        {
            this._roomList.Add(r);
        }
        public List<Room> getAll()
        {
            // xml or mysql if time permits
            return this._roomList;
        }

        /// <summary>
        /// After the guest checks out the room, the room become Vacant
        /// </summary>
        /// <param name="roomId"></param>
        /// <returns>successful/unsuccessful</returns>
        public bool checkOut(int roomId)
        {
            try
            {
                foreach (var room in this._roomList.Where(rm => rm.roomId == roomId))
                {
                    if (room.status == ROOM_STATUS.Occupied)
                    {
                        return setRoomAsVacant(roomId);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Once a room is repaired, it will become Vacant
        /// Available and Occupied rooms cannot be repaired.
        /// </summary>
        /// <param name="roomId"></param>
        /// <returns>successful/unsuccessful</returns>
        public bool setAsRepaired(int roomId)
        {
            try
            {
                foreach (var room in this._roomList.Where(rm => rm.roomId == roomId))
                {
                    if (room.status == ROOM_STATUS.Repair)
                    {
                        room.status = ROOM_STATUS.Vacant;
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;

        }

        /// <summary>
        /// Housekeeping may take a Vacant room for repairs by making the room as Repair
        /// In other words, only Vacant room can be set as Repair
        /// </summary>
        /// <param name="roomId"></param>
        /// <returns>successful/unsuccessful</returns>
        public bool SetOOS(int roomId)
        {
            try
            {
                foreach (var room in this._roomList.Where(rm => rm.roomId == roomId))
                {
                    if (room.status == ROOM_STATUS.Vacant)
                    {
                        room.status = ROOM_STATUS.Repair;
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Only Available rooms can be assigned to guests which will then become Occupied
        /// </summary>
        /// <param name="roomId"></param>
        /// <returns>successful/unsuccessful</returns>

        public bool checkIn(int roomId)
        {
            try
            {
                foreach (var room in this._roomList.Where(rm => rm.roomId == roomId))
                {
                    if (room.status == ROOM_STATUS.Available)
                    {
                        room.status = ROOM_STATUS.Occupied;
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        /// <summary>
        /// After the guest checks out of the room, the room becomes Vacant
        /// </summary>
        /// <param name="roomId"></param>
        /// <returns>successful/unsuccessful</returns>
        private bool setRoomAsVacant(int roomId)
        {
            try
            {
                foreach (var room in this._roomList.Where(rm => rm.roomId == roomId))
                {
                    room.status = ROOM_STATUS.Vacant;
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        /// <summary>
        /// If housekeeping cleans a Vacant room, it becomes available
        /// </summary>
        /// <param name="roomId"></param>
        /// <returns>successful/unsuccessful</returns>
        public bool setRoomAsCleaned(int roomId)
        {
            try
            {
                foreach (var room in this._roomList.Where(rm => rm.roomId == roomId))
                {
                    if (room.status == ROOM_STATUS.Vacant)
                    {
                        room.status = ROOM_STATUS.Available;
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        /// <summary>
        /// get all available rooms
        /// </summary>
        /// <returns>list of Available Rooms</returns>
        public List<Room> getAvailableRooms()
        {
            try
            {
                List<Room> avaiRooms = new List<Room>();
                avaiRooms = this._roomList;
                return avaiRooms.FindAll(n => n.status == ROOM_STATUS.Available);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return this._roomList;
        }

        /// <summary>
        /// get no. of items in the list
        /// </summary>
        /// <returns></returns>
        public int getCount()
        {
            return this._roomList.Count;
        }
    }
}
