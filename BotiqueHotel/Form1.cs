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
            switch (dataGridViewRooms.Columns[e.ColumnIndex].Name)
            {
                case "Check-In":
                    break;
                case "Check-Out":
                    break;
                case "Cleaned":
                    break;
                case "Out-of-Service":
                    break;
                case "Repaired":
                    break;
            }
            
        }


        //public ObservableCollection<Room> RoomList { get { return _roomList; } }
    }
}
