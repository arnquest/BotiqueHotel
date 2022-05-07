
using System.Windows.Forms;

namespace BotiqueHotel
{
    partial class FrmBoutiqueHotelMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomIdDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumberDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewRooms = new System.Windows.Forms.DataGridView();
            this.roomIdDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumberDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowAvailable = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(BotiqueHotel.Model.Room);
            // 
            // roomIdDataGridViewTextBoxColumn
            // 
            this.roomIdDataGridViewTextBoxColumn.DataPropertyName = "roomId";
            this.roomIdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.roomIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.roomIdDataGridViewTextBoxColumn.Name = "roomIdDataGridViewTextBoxColumn";
            this.roomIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            this.roomNumberDataGridViewTextBoxColumn.DataPropertyName = "roomNumber";
            this.roomNumberDataGridViewTextBoxColumn.HeaderText = "Room No";
            this.roomNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            this.roomNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 150;
            // 
            // roomIdDataGridViewTextBoxColumn1
            // 
            this.roomIdDataGridViewTextBoxColumn1.DataPropertyName = "roomId";
            this.roomIdDataGridViewTextBoxColumn1.HeaderText = "roomId";
            this.roomIdDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.roomIdDataGridViewTextBoxColumn1.Name = "roomIdDataGridViewTextBoxColumn1";
            this.roomIdDataGridViewTextBoxColumn1.Width = 150;
            // 
            // roomNumberDataGridViewTextBoxColumn1
            // 
            this.roomNumberDataGridViewTextBoxColumn1.DataPropertyName = "roomNumber";
            this.roomNumberDataGridViewTextBoxColumn1.HeaderText = "roomNumber";
            this.roomNumberDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.roomNumberDataGridViewTextBoxColumn1.Name = "roomNumberDataGridViewTextBoxColumn1";
            this.roomNumberDataGridViewTextBoxColumn1.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn1.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            this.statusDataGridViewTextBoxColumn1.Width = 150;
            // 
            // roomIdDataGridViewTextBoxColumn2
            // 
            this.roomIdDataGridViewTextBoxColumn2.DataPropertyName = "roomId";
            this.roomIdDataGridViewTextBoxColumn2.HeaderText = "roomId";
            this.roomIdDataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.roomIdDataGridViewTextBoxColumn2.Name = "roomIdDataGridViewTextBoxColumn2";
            this.roomIdDataGridViewTextBoxColumn2.Width = 150;
            // 
            // roomNumberDataGridViewTextBoxColumn2
            // 
            this.roomNumberDataGridViewTextBoxColumn2.DataPropertyName = "roomNumber";
            this.roomNumberDataGridViewTextBoxColumn2.HeaderText = "roomNumber";
            this.roomNumberDataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.roomNumberDataGridViewTextBoxColumn2.Name = "roomNumberDataGridViewTextBoxColumn2";
            this.roomNumberDataGridViewTextBoxColumn2.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn2
            // 
            this.statusDataGridViewTextBoxColumn2.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn2.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.statusDataGridViewTextBoxColumn2.Name = "statusDataGridViewTextBoxColumn2";
            this.statusDataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewRooms
            // 
            this.dataGridViewRooms.AllowUserToAddRows = false;
            this.dataGridViewRooms.AutoGenerateColumns = false;
            this.dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomIdDataGridViewTextBoxColumn3,
            this.roomNumberDataGridViewTextBoxColumn3,
            this.statusDataGridViewTextBoxColumn3});
            this.dataGridViewRooms.DataSource = this.roomBindingSource;
            this.dataGridViewRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRooms.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRooms.Name = "dataGridViewRooms";
            this.dataGridViewRooms.ReadOnly = true;
            this.dataGridViewRooms.RowHeadersWidth = 62;
            this.dataGridViewRooms.RowTemplate.Height = 33;
            this.dataGridViewRooms.Size = new System.Drawing.Size(1520, 829);
            this.dataGridViewRooms.TabIndex = 0;
            this.dataGridViewRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRooms_CellContentClick);
            // 
            // roomIdDataGridViewTextBoxColumn3
            // 
            this.roomIdDataGridViewTextBoxColumn3.DataPropertyName = "roomId";
            this.roomIdDataGridViewTextBoxColumn3.HeaderText = "ID";
            this.roomIdDataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.roomIdDataGridViewTextBoxColumn3.Name = "roomIdDataGridViewTextBoxColumn3";
            this.roomIdDataGridViewTextBoxColumn3.ReadOnly = true;
            this.roomIdDataGridViewTextBoxColumn3.Width = 150;
            // 
            // roomNumberDataGridViewTextBoxColumn3
            // 
            this.roomNumberDataGridViewTextBoxColumn3.DataPropertyName = "roomNumber";
            this.roomNumberDataGridViewTextBoxColumn3.HeaderText = "Room No";
            this.roomNumberDataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.roomNumberDataGridViewTextBoxColumn3.Name = "roomNumberDataGridViewTextBoxColumn3";
            this.roomNumberDataGridViewTextBoxColumn3.ReadOnly = true;
            this.roomNumberDataGridViewTextBoxColumn3.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn3
            // 
            this.statusDataGridViewTextBoxColumn3.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn3.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.statusDataGridViewTextBoxColumn3.Name = "statusDataGridViewTextBoxColumn3";
            this.statusDataGridViewTextBoxColumn3.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn3.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnShowAvailable);
            this.panel1.Controls.Add(this.btnShowAll);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 759);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1520, 70);
            this.panel1.TabIndex = 1;
            // 
            // btnShowAvailable
            // 
            this.btnShowAvailable.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShowAvailable.Location = new System.Drawing.Point(1104, 0);
            this.btnShowAvailable.Name = "btnShowAvailable";
            this.btnShowAvailable.Size = new System.Drawing.Size(208, 70);
            this.btnShowAvailable.TabIndex = 1;
            this.btnShowAvailable.Text = "Show Available";
            this.btnShowAvailable.UseVisualStyleBackColor = true;
            this.btnShowAvailable.Click += new System.EventHandler(this.btnShowAvailable_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShowAll.Location = new System.Drawing.Point(1312, 0);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(208, 70);
            this.btnShowAll.TabIndex = 0;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // FrmBoutiqueHotelMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 829);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewRooms);
            this.Name = "FrmBoutiqueHotelMain";
            this.Text = "Welcome to Odyssey Botique Hotel";
            this.Load += new System.EventHandler(this.FrmBoutiqueHotelMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private BindingSource roomBindingSource;
        private DataGridViewTextBoxColumn roomIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roomIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn roomIdDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn2;
        private DataGridView dataGridViewRooms;
        private DataGridViewTextBoxColumn roomIdDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn3;
        private Panel panel1;
        private Button btnShowAvailable;
        private Button btnShowAll;
    }
}

