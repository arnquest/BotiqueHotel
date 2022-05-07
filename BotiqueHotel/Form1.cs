using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BotiqueHotel.Controller;
using BotiqueHotel.Model;

namespace BotiqueHotel
{
    public partial class FrmBoutiqueHotelMain : Form
    {
        //private ObservableCollection<Room> _roomList
        //= new ObservableCollection<Room>();

        HotelController controller;
        public FrmBoutiqueHotelMain()
        {
            InitializeComponent();
            controller = new HotelController();
        }

        private void FrmBoutiqueHotelMain_Load(object sender, EventArgs e)
        {
            List<Room> rooms = this.controller.getAllRooms();
            PopulateListViewData(rooms);

            DataGridViewButtonColumn checkInBtn = new DataGridViewButtonColumn
            {
                Text = "Check-In",
                HeaderText = "",
                UseColumnTextForButtonValue = true,
                Name = "Check-In",
                DataPropertyName = "Check-In"
        };
            dataGridViewRooms.Columns.Add(checkInBtn);

            DataGridViewButtonColumn checkOutBtn = new DataGridViewButtonColumn
            {
                Text = "Check-Out",
                HeaderText = "",
                UseColumnTextForButtonValue = true,
                Name = "Check-Out",
                DataPropertyName = "Check-Out"
            };
            dataGridViewRooms.Columns.Add(checkOutBtn);

            DataGridViewButtonColumn cleanedBtn = new DataGridViewButtonColumn
            {
                Text = "Cleaned",
                HeaderText = "",
                UseColumnTextForButtonValue = true,
                Name = "Cleaned",
                DataPropertyName = "Cleaned"
            };
            dataGridViewRooms.Columns.Add(cleanedBtn);

            DataGridViewButtonColumn oosBtn = new DataGridViewButtonColumn
            {
                Text = "Out-of-Service",
                HeaderText = "",
                UseColumnTextForButtonValue = true,
                Name = "Out-of-Service",
                DataPropertyName = "Out-of-Service"
            };
            dataGridViewRooms.Columns.Add(oosBtn);

            DataGridViewButtonColumn repairedBtn = new DataGridViewButtonColumn
            {
                Text = "Repaired",
                HeaderText = "",
                UseColumnTextForButtonValue = true,
                Name = "Repaired",
                DataPropertyName = "Repaired"
            };
            dataGridViewRooms.Columns.Add(repairedBtn);
        }
        public void PopulateListViewData(List<Room> rooms)
        {
            dataGridViewRooms.Rows.Clear();

            foreach (Room rm in rooms)
            {
                roomBindingSource.Add(new Room() { roomId = rm.roomId, roomNumber = rm.roomNumber, status = rm.status });
            }

            dataGridViewRooms.Update();
            dataGridViewRooms.Refresh();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            List<Room> rooms = this.controller.getAllRooms();
            PopulateListViewData(rooms);
        }

        private void btnShowAvailable_Click(object sender, EventArgs e)
        {
            List<Room> rooms = this.controller.getAvailableRooms();
            PopulateListViewData(rooms);
        }

        private void dataGridViewRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewRooms[0, e.RowIndex].Value != null)
            { 
                int roomId = Convert.ToInt32(dataGridViewRooms[0, e.RowIndex].Value);

                switch (dataGridViewRooms.Columns[e.ColumnIndex].Name)
                {
                    case "Check-In":
                        if (controller.checkIn(roomId))
                        {
                            MessageBox.Show(this, "Check In Successful!", "Successful!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(this, "This room is not available for Check In", "Unable to Check In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case "Check-Out":
                        if (controller.checkOut(roomId))
                        {
                            MessageBox.Show(this, "Check Out Successful!!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(this, "This room is not available for Check Out", "Unable to Check Out", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case "Cleaned":
                        if (controller.setRoomAsCleaned(roomId))
                        {
                            MessageBox.Show(this, "Updated the room as cleaned", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(this, "Unable to update this room as Cleaned", "Unable to set it as Cleaned", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case "Out-of-Service":
                        if (controller.setRoomOOS(roomId))
                        {
                            MessageBox.Show(this, "Successfully updated the room for repair", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(this, "Unable to update this room for repair", "Unable to set it as Repair", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case "Repaired":
                        if (controller.setRoomAsRepaired(roomId))
                        {
                            MessageBox.Show(this, "Successfully updated the room as Repaired", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(this, "Unable to update this room as Repaired", "Unable to set it as Repaired", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                }

                List<Room> rooms = this.controller.getAllRooms();
                PopulateListViewData(rooms);

            }
            
        }


        //public ObservableCollection<Room> RoomList { get { return _roomList; } }
    }
}
