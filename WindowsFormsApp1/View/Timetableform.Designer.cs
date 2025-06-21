namespace WindowsFormsApp1
{
    partial class TimetableForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblSubjectID;
        private System.Windows.Forms.Label lblTimeSlot;
        private System.Windows.Forms.Label lblRoomID;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtSubjectID;
        private System.Windows.Forms.TextBox txtTimeSlot;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvTimetables;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblId = new System.Windows.Forms.Label();
            this.lblSubjectID = new System.Windows.Forms.Label();
            this.lblTimeSlot = new System.Windows.Forms.Label();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtSubjectID = new System.Windows.Forms.TextBox();
            this.txtTimeSlot = new System.Windows.Forms.TextBox();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvTimetables = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetables)).BeginInit();
            this.SuspendLayout();

            // Label and TextBox for ID
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(30, 20);
            this.lblId.Text = "ID";
            this.txtId.Location = new System.Drawing.Point(130, 20);
            this.txtId.ReadOnly = true;

            // Label and TextBox for SubjectID
            this.lblSubjectID.AutoSize = true;
            this.lblSubjectID.Location = new System.Drawing.Point(30, 60);
            this.lblSubjectID.Text = "Subject ID";
            this.txtSubjectID.Location = new System.Drawing.Point(130, 60);

            // Label and TextBox for TimeSlot
            this.lblTimeSlot.AutoSize = true;
            this.lblTimeSlot.Location = new System.Drawing.Point(30, 100);
            this.lblTimeSlot.Text = "Time Slot";
            this.txtTimeSlot.Location = new System.Drawing.Point(130, 100);

            // Label and TextBox for RoomID
            this.lblRoomID.AutoSize = true;
            this.lblRoomID.Location = new System.Drawing.Point(30, 140);
            this.lblRoomID.Text = "Room ID";
            this.txtRoomID.Location = new System.Drawing.Point(130, 140);

            // Add button
            this.btnAdd.Text = "Add";
            this.btnAdd.Location = new System.Drawing.Point(30, 180);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // Update button
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Location = new System.Drawing.Point(110, 180);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // Delete button
            this.btnDelete.Text = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(200, 180);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // DataGridView
            this.dgvTimetables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimetables.Location = new System.Drawing.Point(30, 230);
            this.dgvTimetables.Size = new System.Drawing.Size(500, 200);
            this.dgvTimetables.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimetables_CellClick);

            // TimetableForm
            this.ClientSize = new System.Drawing.Size(580, 460);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblSubjectID);
            this.Controls.Add(this.txtSubjectID);
            this.Controls.Add(this.lblTimeSlot);
            this.Controls.Add(this.txtTimeSlot);
            this.Controls.Add(this.lblRoomID);
            this.Controls.Add(this.txtRoomID);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvTimetables);
            this.Text = "Timetable Form";

            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
