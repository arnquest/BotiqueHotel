using System;
using System.Collections.Generic;
using System.Text;

namespace BotiqueHotel
{
    public class Room
    {
        private int roomnumber;
        private String type;
        private bool flag;

        public Room()
        {
        }

        public Room(int roomnumber, String type, bool flag)
        {
            this.roomnumber = roomnumber;
            this.type = type;
            this.flag = flag;
        }

        public int getRoomnumber()
        {
            return roomnumber;
        }

        public void setRoomnumber(int roomnumber)
        {
            this.roomnumber = roomnumber;
        }

        public String getType()
        {
            return type;
        }

        public void setType(String type)
        {
            this.type = type;
        }

        public bool isFlag()
        {
            return flag;
        }

        public void setFlag(bool flag)
        {
            this.flag = flag;
        }
  
        //Override the toString method, which can be converted to output room information
        public String toString()
        {
            //ternary operator
            return "[" + this.getRoomnumber() + "," + this.getType() + "," + (this.isFlag() ? "Occupy" : "free") + "]";
        }
    }
}
