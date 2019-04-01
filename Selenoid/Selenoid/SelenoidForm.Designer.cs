
using Selenoid.SelenoidClasses;
using System.Windows.Forms;

namespace Selenoid
{
    partial class SelenoidForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView_Screens = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView_Objects = new System.Windows.Forms.DataGridView();
            this.lbl_Screens = new System.Windows.Forms.Label();
            this.lbl_Objects = new System.Windows.Forms.Label();
            this.btnObjDelete = new System.Windows.Forms.Button();
            this.btnObjCancel = new System.Windows.Forms.Button();
            this.btnObjAdd = new System.Windows.Forms.Button();
            this.btnObjUpdate = new System.Windows.Forms.Button();
            this.tab_ObjScreens = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_UpdateKeyTsk = new System.Windows.Forms.Button();
            this.btn_AddKeytsk = new System.Windows.Forms.Button();
            this.btn_CancelKeyTsk = new System.Windows.Forms.Button();
            this.btn_DeleteKeytsk = new System.Windows.Forms.Button();
            this.lbl_KeyTask = new System.Windows.Forms.Label();
            this.dataGridView_KeyTask = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Screens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Objects)).BeginInit();
            this.tab_ObjScreens.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KeyTask)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Selenoid.Properties.Resources.Selenoid;
            this.pictureBox1.Location = new System.Drawing.Point(644, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(407, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // dataGridView_Screens
            // 
            this.dataGridView_Screens.AllowUserToDeleteRows = false;
            this.dataGridView_Screens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Screens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView_Screens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Screens.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView_Screens.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView_Screens.Location = new System.Drawing.Point(25, 64);
            this.dataGridView_Screens.Name = "dataGridView_Screens";
            this.dataGridView_Screens.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Screens.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView_Screens.RowTemplate.Height = 28;
            this.dataGridView_Screens.Size = new System.Drawing.Size(1043, 322);
            this.dataGridView_Screens.TabIndex = 14;
            this.dataGridView_Screens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Screens_CellClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSalmon;
            this.btnUpdate.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(1218, 102);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 43);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSalmon;
            this.btnAdd.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1218, 167);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 40);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(1218, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 36);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1218, 292);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 37);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // dataGridView_Objects
            // 
            this.dataGridView_Objects.AllowUserToDeleteRows = false;
            this.dataGridView_Objects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Objects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView_Objects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Objects.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView_Objects.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView_Objects.Location = new System.Drawing.Point(26, 451);
            this.dataGridView_Objects.Name = "dataGridView_Objects";
            this.dataGridView_Objects.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Objects.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView_Objects.RowTemplate.Height = 28;
            this.dataGridView_Objects.Size = new System.Drawing.Size(1043, 337);
            this.dataGridView_Objects.TabIndex = 19;
            this.dataGridView_Objects.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Objects_CellValChanged);
            // 
            // lbl_Screens
            // 
            this.lbl_Screens.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Screens.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Screens.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Screens.Location = new System.Drawing.Point(20, 24);
            this.lbl_Screens.Name = "lbl_Screens";
            this.lbl_Screens.Size = new System.Drawing.Size(1048, 37);
            this.lbl_Screens.TabIndex = 21;
            this.lbl_Screens.Text = "SCREENS";
            // 
            // lbl_Objects
            // 
            this.lbl_Objects.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Objects.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Objects.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Objects.Location = new System.Drawing.Point(21, 409);
            this.lbl_Objects.Name = "lbl_Objects";
            this.lbl_Objects.Size = new System.Drawing.Size(1048, 37);
            this.lbl_Objects.TabIndex = 22;
            this.lbl_Objects.Text = "OBJECTS";
            // 
            // btnObjDelete
            // 
            this.btnObjDelete.BackColor = System.Drawing.Color.Gainsboro;
            this.btnObjDelete.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObjDelete.Location = new System.Drawing.Point(1216, 668);
            this.btnObjDelete.Name = "btnObjDelete";
            this.btnObjDelete.Size = new System.Drawing.Size(93, 37);
            this.btnObjDelete.TabIndex = 26;
            this.btnObjDelete.Text = "Delete";
            this.btnObjDelete.UseVisualStyleBackColor = false;
            this.btnObjDelete.Click += new System.EventHandler(this.BtnObjDelete_Click);
            // 
            // btnObjCancel
            // 
            this.btnObjCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnObjCancel.Enabled = false;
            this.btnObjCancel.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObjCancel.Location = new System.Drawing.Point(1216, 608);
            this.btnObjCancel.Name = "btnObjCancel";
            this.btnObjCancel.Size = new System.Drawing.Size(93, 36);
            this.btnObjCancel.TabIndex = 25;
            this.btnObjCancel.Text = "Cancel";
            this.btnObjCancel.UseVisualStyleBackColor = false;
            this.btnObjCancel.Click += new System.EventHandler(this.BtnObjCancel_Click);
            // 
            // btnObjAdd
            // 
            this.btnObjAdd.BackColor = System.Drawing.Color.LightSalmon;
            this.btnObjAdd.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObjAdd.Location = new System.Drawing.Point(1216, 543);
            this.btnObjAdd.Name = "btnObjAdd";
            this.btnObjAdd.Size = new System.Drawing.Size(93, 40);
            this.btnObjAdd.TabIndex = 24;
            this.btnObjAdd.Text = "Add";
            this.btnObjAdd.UseVisualStyleBackColor = false;
            this.btnObjAdd.Click += new System.EventHandler(this.BtnObjAdd_Click);
            // 
            // btnObjUpdate
            // 
            this.btnObjUpdate.BackColor = System.Drawing.Color.LightSalmon;
            this.btnObjUpdate.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObjUpdate.Location = new System.Drawing.Point(1216, 478);
            this.btnObjUpdate.Name = "btnObjUpdate";
            this.btnObjUpdate.Size = new System.Drawing.Size(93, 43);
            this.btnObjUpdate.TabIndex = 23;
            this.btnObjUpdate.Text = "Update";
            this.btnObjUpdate.UseVisualStyleBackColor = false;
            this.btnObjUpdate.Click += new System.EventHandler(this.BtnObjUpdate_Click);
            // 
            // tab_ObjScreens
            // 
            this.tab_ObjScreens.Controls.Add(this.tabPage1);
            this.tab_ObjScreens.Controls.Add(this.tabPage2);
            this.tab_ObjScreens.Location = new System.Drawing.Point(18, 147);
            this.tab_ObjScreens.Name = "tab_ObjScreens";
            this.tab_ObjScreens.SelectedIndex = 0;
            this.tab_ObjScreens.Size = new System.Drawing.Size(1556, 881);
            this.tab_ObjScreens.TabIndex = 27;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView_Screens);
            this.tabPage1.Controls.Add(this.btnObjDelete);
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Controls.Add(this.btnObjCancel);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.btnObjAdd);
            this.tabPage1.Controls.Add(this.btnCancel);
            this.tabPage1.Controls.Add(this.btnObjUpdate);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.lbl_Objects);
            this.tabPage1.Controls.Add(this.lbl_Screens);
            this.tabPage1.Controls.Add(this.dataGridView_Objects);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1548, 848);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Screens and Objects";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1548, 848);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Keytasks";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_UpdateKeyTsk);
            this.groupBox1.Controls.Add(this.btn_AddKeytsk);
            this.groupBox1.Controls.Add(this.btn_CancelKeyTsk);
            this.groupBox1.Controls.Add(this.btn_DeleteKeytsk);
            this.groupBox1.Controls.Add(this.lbl_KeyTask);
            this.groupBox1.Controls.Add(this.dataGridView_KeyTask);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1463, 836);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btn_UpdateKeyTsk
            // 
            this.btn_UpdateKeyTsk.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_UpdateKeyTsk.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateKeyTsk.Location = new System.Drawing.Point(1052, 100);
            this.btn_UpdateKeyTsk.Name = "btn_UpdateKeyTsk";
            this.btn_UpdateKeyTsk.Size = new System.Drawing.Size(93, 43);
            this.btn_UpdateKeyTsk.TabIndex = 23;
            this.btn_UpdateKeyTsk.Text = "Update";
            this.btn_UpdateKeyTsk.UseVisualStyleBackColor = false;
            this.btn_UpdateKeyTsk.Click += new System.EventHandler(this.Btn_UpdateKeyTsk_Click);
            // 
            // btn_AddKeytsk
            // 
            this.btn_AddKeytsk.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_AddKeytsk.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddKeytsk.Location = new System.Drawing.Point(1052, 165);
            this.btn_AddKeytsk.Name = "btn_AddKeytsk";
            this.btn_AddKeytsk.Size = new System.Drawing.Size(93, 40);
            this.btn_AddKeytsk.TabIndex = 24;
            this.btn_AddKeytsk.Text = "Add";
            this.btn_AddKeytsk.UseVisualStyleBackColor = false;
            this.btn_AddKeytsk.Click += new System.EventHandler(this.Btn_AddKeytsk_Click);
            // 
            // btn_CancelKeyTsk
            // 
            this.btn_CancelKeyTsk.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_CancelKeyTsk.Enabled = false;
            this.btn_CancelKeyTsk.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelKeyTsk.Location = new System.Drawing.Point(1052, 228);
            this.btn_CancelKeyTsk.Name = "btn_CancelKeyTsk";
            this.btn_CancelKeyTsk.Size = new System.Drawing.Size(93, 36);
            this.btn_CancelKeyTsk.TabIndex = 25;
            this.btn_CancelKeyTsk.Text = "Cancel";
            this.btn_CancelKeyTsk.UseVisualStyleBackColor = false;
            this.btn_CancelKeyTsk.Click += new System.EventHandler(this.Btn_CancelKeyTsk_Click);
            // 
            // btn_DeleteKeytsk
            // 
            this.btn_DeleteKeytsk.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_DeleteKeytsk.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteKeytsk.Location = new System.Drawing.Point(1052, 290);
            this.btn_DeleteKeytsk.Name = "btn_DeleteKeytsk";
            this.btn_DeleteKeytsk.Size = new System.Drawing.Size(93, 37);
            this.btn_DeleteKeytsk.TabIndex = 26;
            this.btn_DeleteKeytsk.Text = "Delete";
            this.btn_DeleteKeytsk.UseVisualStyleBackColor = false;
            this.btn_DeleteKeytsk.Click += new System.EventHandler(this.Btn_DeleteKeytsk_Click);
            // 
            // lbl_KeyTask
            // 
            this.lbl_KeyTask.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_KeyTask.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KeyTask.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_KeyTask.Location = new System.Drawing.Point(26, 36);
            this.lbl_KeyTask.Name = "lbl_KeyTask";
            this.lbl_KeyTask.Size = new System.Drawing.Size(935, 37);
            this.lbl_KeyTask.TabIndex = 22;
            this.lbl_KeyTask.Text = "KEYTASKS";
            // 
            // dataGridView_KeyTask
            // 
            this.dataGridView_KeyTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_KeyTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_KeyTask.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView_KeyTask.Location = new System.Drawing.Point(31, 76);
            this.dataGridView_KeyTask.Name = "dataGridView_KeyTask";
            this.dataGridView_KeyTask.ReadOnly = true;
            this.dataGridView_KeyTask.RowTemplate.Height = 28;
            this.dataGridView_KeyTask.Size = new System.Drawing.Size(930, 287);
            this.dataGridView_KeyTask.TabIndex = 0;
            // 
            // SelenoidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1665, 1040);
            this.Controls.Add(this.tab_ObjScreens);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SelenoidForm";
            this.Text = "Selenoid Automtion";
            this.Load += new System.EventHandler(this.SelenoidForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Screens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Objects)).EndInit();
            this.tab_ObjScreens.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KeyTask)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView_Screens;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnCancel;
        private Button btnDelete;
        private DataGridView dataGridView_Objects;
        private Label lbl_Screens;
        private Label lbl_Objects;
        private Button btnObjDelete;
        private Button btnObjCancel;
        private Button btnObjAdd;
        private Button btnObjUpdate;
        private TabControl tab_ObjScreens;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private DataGridView dataGridView_KeyTask;
        private Label lbl_KeyTask;
        private Button btn_UpdateKeyTsk;
        private Button btn_AddKeytsk;
        private Button btn_CancelKeyTsk;
        private Button btn_DeleteKeytsk;
    }
}