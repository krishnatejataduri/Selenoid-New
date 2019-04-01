using Selenoid.SelenoidClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selenoid
{
    public partial class SelenoidForm : Form
    {
        public SelenoidForm()
        {
            InitializeComponent();
            om = new ObjectManager();
            km = new KeyTaskManager();
            this.dataGridView_Screens.DataSource = om.getScreenData();
            this.dataGridView_Screens.MultiSelect = false;
            this.dataGridView_Screens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Screens.Rows[0].Selected = true;
            this.dataGridView_Objects.DataSource = om.getObjectData(this.dataGridView_Screens.SelectedRows[0].Cells[0].Value.ToString());
            this.dataGridView_Objects.MultiSelect = false;
            this.dataGridView_Objects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_KeyTask.DataSource = km.getKeyTaskData();
            this.dataGridView_KeyTask.MultiSelect = false;
            this.dataGridView_KeyTask.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_KeyTask.Rows[0].Selected = true;
        }

        //Creating an object of ObjectManager class
        ObjectManager om;
        //Declaring a variable to store KeyTaskManager Object
        KeyTaskManager km;
        //int selectedRow;
        string selectedScrName = string.Empty;
        string selectedScrDesc = string.Empty;
        string newSelectedScrName = string.Empty;
        string newSelectedScrDesc = string.Empty;
        string selectedObjName = string.Empty;
        string selectedObjType = string.Empty;
        string selectedObjDesc = string.Empty;
        string selectedObjLocType = string.Empty;
        string selectedObjLocVal = string.Empty;
        string newSelectedObjName = string.Empty;
        string newSelectedObjType = string.Empty;
        string newSelectedObjDesc = string.Empty;
        string newSelectedObjLocType = string.Empty;
        string newSelectedObjLocVal = string.Empty;
        int selectedObjectRow = -1;
        string selectedKeyTaskName = string.Empty;
        string selectedKeyTaskDesc = string.Empty;
        string newSelectedKeyTaskName = string.Empty;
        string newSelectedKeyTaskDesc = string.Empty;

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SelenoidForm_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {            
            
            if (this.btnUpdate.Text.Equals("Update"))
            {
                
                //Retrieving the data
                selectedScrName = this.dataGridView_Screens.SelectedRows[0].Cells[0].Value.ToString();
                selectedScrDesc = this.dataGridView_Screens.SelectedRows[0].Cells[1].Value.ToString();
                //MessageBox.Show(initialVal1 + initialVal2); 
                this.btnUpdate.Text = "Save";
                //Enabling the Cancel button on the click of Update button and changing the background color
                DisableAllButtonControls(this);
                EnableSpecificControl(this.btnUpdate);
                EnableSpecificControl(this.btnCancel);
                //Disabling the Object Grid when ObjectUpdate button is clicked so that user cannot select row from the screen grid
                this.dataGridView_Objects.Enabled = false;
                
                //this.dataGridView_Objects.Enabled = false;
                //this.btnCancel.Enabled = true;


                //Disabling the Update button after it's click
                //this.btnUpdate.Enabled = false;
                //this.btnUpdate.BackColor = Color.Gainsboro;
                //Disabling sort of datagrid
                int selectedRow = this.dataGridView_Screens.SelectedRows[0].Index;
                foreach (DataGridViewColumn col in this.dataGridView_Screens.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                
                this.dataGridView_Screens.ReadOnly = false;
                //Making the datagrid rows as read only (except the one that has been selected)
                foreach (DataGridViewRow row in this.dataGridView_Screens.Rows)
                {
                    if (row.Index != selectedRow)
                    {
                        row.ReadOnly = true;
                       
                        
                        
                    }
                }
            }
            else if (this.btnUpdate.Text.Equals("Save"))
            {
                //Retrieving the new data
                newSelectedScrName = this.dataGridView_Screens.SelectedRows[0].Cells[0].Value.ToString();
                newSelectedScrDesc = this.dataGridView_Screens.SelectedRows[0].Cells[1].Value.ToString();
                //MessageBox.Show(newSelectedScrName + newSelectedScrDesc); 
                //Comparing old values with new values to check if whether user has made any changes
                if (!(newSelectedScrName.Equals(selectedScrName)) || !(newSelectedScrDesc.Equals(selectedScrDesc))) 
                {
                    //Executing the Update SQL Query
                    om.updateScreenTable(newSelectedScrName, newSelectedScrDesc, om.getScreenID(selectedScrName));
                    //Toggling back to the default view after the new values are saved.
                    MessageBox.Show("Object updated successfully!");
                    //Changing the button text back to update
                    this.btnUpdate.Text = "Update";
                    //Calling the custom method to go back to default state
                    DefaultState();
                    
                }
                else
                {
                    //Toggling back to the default view as no changes are made.
                    MessageBox.Show("No changes have been made!");
                    //Changing the button text back to update
                    this.btnUpdate.Text = "Update";
                    //Calling the custom method to go back to default state
                    DefaultState();
                    
                }
            }
        }

        private void DataGridView_Screens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectedScreen = this.dataGridView_Screens.CurrentRow.Cells[0].Value.ToString();
            this.dataGridView_Objects.DataSource = om.getObjectData(selectedScreen);
            this.dataGridView_Objects.Refresh();
        }

        private void DataGridView_Objects_CellValChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView_Objects.Rows[this.dataGridView_Objects.RowCount - 1].ReadOnly = true;
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {

            DefaultState();
            this.btnAdd.Text = "Add";
            this.btnUpdate.Text = "Update";

            //Executing the SQL Query and retrieving the value from database
            this.dataGridView_Screens.DataSource = om.getScreenData();            
            this.dataGridView_Screens.Refresh();       
        }

        private void DisableAllButtonControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c.GetType().ToString().Contains("Windows.Forms.Button"))
                {
                    DisableAllButtonControls(c);                   
                }
                
            }
            con.Enabled = false;
        }

        private void EnableSpecificControl(Control con)
        {
           if (con != null)            
            {                
                con.Enabled = true;
                EnableSpecificControl(con.Parent);
               
            }
        }

        private void EnableAllButtonControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c.GetType().ToString().Contains("Windows.Forms.Button"))
                {
                    EnableAllButtonControls(c);                   
                }

            }
            con.Enabled = true;
        }

        private void DisableSpecificControl(Control con)
        {
            if (con != null)
            {
                con.Enabled = false;
                //DisableSpecificControl(con.Parent);

            }
        }

        //Default state of Objects and Screens
        private void DefaultState()
        {
            this.dataGridView_Screens.ReadOnly = true;
            this.dataGridView_Objects.ReadOnly = true;
            this.dataGridView_Screens.Enabled = true;
            this.dataGridView_Objects.Enabled = true;
            EnableAllButtonControls(this);
            DisableSpecificControl(this.btnCancel);
            DisableSpecificControl(this.btnObjCancel);
            newSelectedScrName = string.Empty;
            newSelectedScrDesc = string.Empty;
            selectedScrName = string.Empty;
            selectedScrDesc = string.Empty;
            selectedObjName = string.Empty;
            selectedObjType = string.Empty;
            selectedScrDesc = string.Empty;
            selectedObjLocType = string.Empty;
            selectedObjLocVal = string.Empty;
            newSelectedObjName = string.Empty;
            newSelectedObjType = string.Empty;
            newSelectedScrDesc = string.Empty;
            newSelectedObjLocType = string.Empty;
            newSelectedObjLocVal = string.Empty;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (this.btnAdd.Text.Equals("Add"))
            {

                
                //MessageBox.Show(initialVal1 + initialVal2); 
                this.btnAdd.Text = "Save";
                //Enabling the Cancel button on the click of Update button and changing the background color
                DisableAllButtonControls(this);
                EnableSpecificControl(this.btnAdd);
                EnableSpecificControl(this.btnCancel);

                //Moving the focus to last row and scrolling to it                
                int selectedRow = this.dataGridView_Screens.Rows[this.dataGridView_Screens.RowCount-1].Index;
                this.dataGridView_Screens.Rows[selectedRow].Selected = true;
                this.dataGridView_Screens.FirstDisplayedScrollingRowIndex = selectedRow;
                //Disabling sort of datagrid
                foreach (DataGridViewColumn col in this.dataGridView_Screens.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                this.dataGridView_Screens.ReadOnly = false;
                //Making the datagrid rows as read only (except the one that has been selected)
                foreach (DataGridViewRow row in this.dataGridView_Screens.Rows)
                {
                    if (row.Index != selectedRow)
                    {
                        row.ReadOnly = true;
                    }
                }
            }
            else if (this.btnAdd.Text.Equals("Save"))
            {
                //Retrieving the new screen name and description
                newSelectedScrName = this.dataGridView_Screens.Rows[this.dataGridView_Screens.RowCount-2].Cells[0].Value.ToString();
                newSelectedScrDesc = this.dataGridView_Screens.Rows[this.dataGridView_Screens.RowCount-2].Cells[1].Value.ToString();

                //Comparing old values with new values to check if whether user has made any changes
                if (!(newSelectedScrName.Equals(string.Empty) && !(newSelectedScrDesc.Equals(string.Empty))))
                {
                    //Executing the Update SQL Query
                    om.addScreenTable(newSelectedScrName, newSelectedScrDesc);
                    //Toggling back to the default view after the new values are saved.
                    MessageBox.Show("Object added successfully!");
                    //Changing the button text back to Add
                    this.btnAdd.Text = "Add";
                    //Calling the custom method to go back to default state
                    DefaultState();
                }
                else
                {
                    //Toggling back to the default view as no changes are made.
                    MessageBox.Show("Please enter a screen name & description and try again.");
                    //Changing the button text back to Add
                    this.btnAdd.Text = "Add";
                    //Calling the custom method to go back to default state
                    DefaultState();
                    //Executing the SQL Query and retrieving the value from database
                    this.dataGridView_Screens.DataSource = om.getScreenData();
                    this.dataGridView_Screens.Refresh();
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            selectedScrName = this.dataGridView_Screens.SelectedRows[0].Cells[0].Value.ToString();
            om.deleteRowInScreenTable(om.getScreenID(selectedScrName));
            //Executing the SQL Query and retrieving the value from database
            this.dataGridView_Screens.DataSource = om.getScreenData();
            this.dataGridView_Screens.Refresh();
            MessageBox.Show(selectedScrName + " has been successfully deleted.");
            DefaultState();
        }



        private void BtnObjUpdate_Click(object sender, EventArgs e)
        {
            if (this.btnObjUpdate.Text.Equals("Update"))
            {

                //Retrieving the data
                selectedScrName = this.dataGridView_Screens.SelectedRows[0].Cells[0].Value.ToString();
                selectedObjName = this.dataGridView_Objects.SelectedRows[0].Cells[0].Value.ToString();
                selectedObjType = this.dataGridView_Objects.SelectedRows[0].Cells[1].Value.ToString();
                selectedObjDesc = this.dataGridView_Objects.SelectedRows[0].Cells[2].Value.ToString();
                selectedObjLocType = this.dataGridView_Objects.SelectedRows[0].Cells[3].Value.ToString();
                selectedObjLocVal = this.dataGridView_Objects.SelectedRows[0].Cells[4].Value.ToString();


                //MessageBox.Show(initialVal1 + initialVal2); 
                this.btnObjUpdate.Text = "Save";
                //Enabling the Cancel button on the click of Update button and changing the background color
                DisableAllButtonControls(this);
                EnableSpecificControl(this.btnObjUpdate);
                EnableSpecificControl(this.btnObjCancel);
                
                //Disabling the Screen Grid when ObjectUpdate button is clicked so that user cannot select row from the screen grid                
                this.dataGridView_Screens.Enabled = false;


                int selectedRow = this.dataGridView_Objects.SelectedRows[0].Index;
                foreach (DataGridViewColumn col in this.dataGridView_Objects.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                this.dataGridView_Objects.ReadOnly = false;
                //Making the datagrid rows as read only (except the one that has been selected)
                foreach (DataGridViewRow row in this.dataGridView_Objects.Rows)
                {
                    if (row.Index != selectedRow)
                    {
                        row.ReadOnly = true;                        
                    }
                }
            }
            else if (this.btnObjUpdate.Text.Equals("Save"))
            {
                //Retrieving the new data
                
                string screenID = om.getScreenID(selectedScrName);
                newSelectedObjName = this.dataGridView_Objects.SelectedRows[0].Cells[0].Value.ToString();
                newSelectedObjType = this.dataGridView_Objects.SelectedRows[0].Cells[1].Value.ToString();
                newSelectedObjDesc = this.dataGridView_Objects.SelectedRows[0].Cells[2].Value.ToString();
                newSelectedObjLocType = this.dataGridView_Objects.SelectedRows[0].Cells[3].Value.ToString();
                newSelectedObjLocVal = this.dataGridView_Objects.SelectedRows[0].Cells[4].Value.ToString();
                //MessageBox.Show(newSelectedScrName + newSelectedScrDesc); 
                //Comparing old values with new values to check if whether user has made any changes
                if (!(newSelectedObjName.Equals(selectedObjName)) || !(newSelectedObjType.Equals(selectedObjType)) || !(newSelectedObjDesc.Equals(selectedObjDesc)) || !(newSelectedObjLocType.Equals(selectedObjLocType)) || !(newSelectedObjLocVal.Equals(selectedObjLocVal)))                   
                {
                    //Before updating the value of xpath in database, replacing single quotes with double so that the xpath frmat can be saved in database
                    newSelectedObjLocVal =newSelectedObjLocVal.Replace("'", "''");
                    //Executing the Update SQL Query                    
                    om.updateObjectTable(screenID, selectedObjName, newSelectedObjName, newSelectedObjType, newSelectedObjDesc, newSelectedObjLocType, newSelectedObjLocVal);
                    
                    //Toggling back to the default view after the new values are saved.
                    MessageBox.Show("Object updated successfully!");
                    //Changing the button text back to update
                    this.btnObjUpdate.Text = "Update";
                    //Calling the custom method to go back to default state
                    DefaultState();
                    
                }
                else
                {
                    //Toggling back to the default view as no changes are made.
                    MessageBox.Show("No changes have been made!");
                    //Changing the button text back to update
                    this.btnObjUpdate.Text = "Update";
                    //Calling the custom method to go back to default state
                    DefaultState();
                    
                }
            }

        }
        
        //Below Function will be called when ObjectCancel button is clicked 
        private void BtnObjCancel_Click(object sender, EventArgs e)
        {
            DefaultState();
            this.btnObjAdd.Text = "Add";
            this.btnObjUpdate.Text = "Update";

            selectedScrName = this.dataGridView_Screens.SelectedRows[0].Cells[0].Value.ToString();
            //Executing the SQL Query and retrieving the value from database
            this.dataGridView_Objects.DataSource = om.getObjectData(selectedScrName);
            this.dataGridView_Objects.Refresh();

        }

        private void BtnObjAdd_Click(object sender, EventArgs e)
        {
            if (this.btnObjAdd.Text.Equals("Add"))
            {
                selectedScrName = this.dataGridView_Screens.SelectedRows[0].Cells[0].Value.ToString();
                //MessageBox.Show(initialVal1 + initialVal2); 
                this.btnObjAdd.Text = "Save";
                //Enabling the Cancel button on the click of Update button and changing the background color
                DisableAllButtonControls(this);
                EnableSpecificControl(this.btnObjAdd);
                EnableSpecificControl(this.btnObjCancel);
                //this.btnCancel.Enabled = true;

                //Disabling the Update button after it's click
                //this.btnUpdate.Enabled = false;
                //this.btnUpdate.BackColor = Color.Gainsboro;
                //Disabling sort of datagrid
                selectedObjectRow = this.dataGridView_Objects.Rows[this.dataGridView_Objects.RowCount - 1].Index;
                this.dataGridView_Objects.Rows[selectedObjectRow].Selected = true;
                this.dataGridView_Objects.FirstDisplayedScrollingRowIndex = selectedObjectRow;
                foreach (DataGridViewColumn col in this.dataGridView_Objects.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                this.dataGridView_Objects.ReadOnly = false;
                //Making the datagrid rows as read only (except the one that has been selected)
                foreach (DataGridViewRow row in this.dataGridView_Objects.Rows)
                {
                    if (row.Index != selectedObjectRow)
                    {
                        row.ReadOnly = true;
                    }
                }
            }
            else if (this.btnObjAdd.Text.Equals("Save"))
            {
                //Retrieving the new screen name and description
                try
                {
                    newSelectedObjName = this.dataGridView_Objects.Rows[selectedObjectRow].Cells[0].Value.ToString();
                    newSelectedObjType = this.dataGridView_Objects.Rows[selectedObjectRow].Cells[1].Value.ToString();
                    newSelectedObjDesc = this.dataGridView_Objects.Rows[selectedObjectRow].Cells[2].Value.ToString();
                    newSelectedObjLocType = this.dataGridView_Objects.Rows[selectedObjectRow].Cells[3].Value.ToString();
                    newSelectedObjLocVal = this.dataGridView_Objects.Rows[selectedObjectRow].Cells[4].Value.ToString();
                    //Comparing old values with new values to check if whether user has made any changes
                    if (!newSelectedObjName.Equals(string.Empty) && !newSelectedObjType.Equals(string.Empty) && !newSelectedObjDesc.Equals(string.Empty) && !newSelectedObjLocType.Equals(string.Empty) && !newSelectedObjLocVal.Equals(string.Empty))
                    {
                        newSelectedObjLocVal = newSelectedObjLocVal.Replace("'", "''");
                        //Executing the Update SQL Query
                        om.addRowInObjectTable(om.getScreenID(selectedScrName), newSelectedObjName, newSelectedObjType, newSelectedObjDesc, newSelectedObjLocType, newSelectedObjLocVal);
                        //Toggling back to the default view after the new values are saved.
                        MessageBox.Show("Object added successfully!");
                        //Changing the button text back to Add
                        this.btnObjAdd.Text = "Add";
                        //Calling the custom method to go back to default state
                        DefaultState();
                    }
                    else
                    {
                        //Toggling back to the default view as no changes are made.
                        //MessageBox.Show("Cannot contain blanks. Please enter valid values and try again.");
                        //Changing the button text back to Add
                        //this.btnObjAdd.Text = "Add";
                        //Calling the custom method to go back to default state
                        //DefaultState();
                        MessageBox.Show("Cannot contain blanks. Please enter valid values and try again.");
                        //this.dataGridView_Objects.DataSource = om.getObjectData(selectedScrName);
                        //this.dataGridView_Objects.Refresh();
                    }
                }
                catch (NullReferenceException nullRefException)
                {
                    MessageBox.Show("Cannot contain blanks. Please enter valid values and try again.");
                    
                }


            }
        }

        private void BtnObjDelete_Click(object sender, EventArgs e)
        {
            //Retrieving the data
            selectedScrName = this.dataGridView_Screens.SelectedRows[0].Cells[0].Value.ToString();
            selectedObjName = this.dataGridView_Objects.SelectedRows[0].Cells[0].Value.ToString();
            om.deleteRowInObjectTable(om.getScreenID(selectedScrName), selectedObjName);
            //Executing the SQL Query and retrieving the value from database
            this.dataGridView_Objects.DataSource = om.getObjectData(selectedScrName);
            this.dataGridView_Objects.Refresh();
            MessageBox.Show(selectedObjName + " has been successfully deleted.");
            DefaultState();
        }

        //*****************************************************************************************************
        //**************************************KEYTASK MODULE*************************************************
        //*****************************************************************************************************

        //Default state of keytask page
        private void DefaultKeyTaskState()
        {
            this.dataGridView_KeyTask.ReadOnly = true;
            this.dataGridView_KeyTask.ReadOnly = true;
 //Update this   this.dataGridView_Screens.Enabled = true;
            //this.dataGridView_Objects.Enabled = true;
            EnableAllButtonControls(this);
            DisableSpecificControl(this.btn_CancelKeyTsk);
 //Update this           DisableSpecificControl(this.btnObjCancel);
            newSelectedKeyTaskName = string.Empty;
            newSelectedKeyTaskDesc = string.Empty;
            selectedKeyTaskName = string.Empty;
            selectedKeyTaskDesc = string.Empty;
            
        }

        //Method to update KeyTasks
        private void Btn_UpdateKeyTsk_Click(object sender, EventArgs e)
        {
            if (this.btn_UpdateKeyTsk.Text.Equals("Update"))
            {

                //Retrieving the data
                selectedKeyTaskName = this.dataGridView_KeyTask.SelectedRows[0].Cells[0].Value.ToString();
                selectedKeyTaskDesc = this.dataGridView_KeyTask.SelectedRows[0].Cells[1].Value.ToString();
                //MessageBox.Show(initialVal1 + initialVal2); 
                this.btn_UpdateKeyTsk.Text = "Save";
                //Enabling the Cancel button on the click of Update button and changing the background color
                DisableAllButtonControls(this);
                EnableSpecificControl(this.btn_UpdateKeyTsk);
                EnableSpecificControl(this.btn_CancelKeyTsk);
                //Disabling the Object Grid when ObjectUpdate button is clicked so that user cannot select row from the screen grid
//Update this****        //****this.dataGridView_Objects.Enabled = false;

                
                int selectedRow = this.dataGridView_KeyTask.SelectedRows[0].Index;
                foreach (DataGridViewColumn col in this.dataGridView_KeyTask.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                this.dataGridView_KeyTask.ReadOnly = false;
                //Making the datagrid rows as read only (except the one that has been selected)
                foreach (DataGridViewRow row in this.dataGridView_KeyTask.Rows)
                {
                    if (row.Index != selectedRow)
                    {
                        row.ReadOnly = true;
                    }
                }
            }
            else if (this.btn_UpdateKeyTsk.Text.Equals("Save"))
            {
                //Retrieving the new data
                newSelectedKeyTaskName = this.dataGridView_KeyTask.SelectedRows[0].Cells[0].Value.ToString();
                newSelectedKeyTaskDesc = this.dataGridView_KeyTask.SelectedRows[0].Cells[1].Value.ToString();
                //MessageBox.Show(newSelectedScrName + newSelectedScrDesc); 
                //Comparing old values with new values to check if whether user has made any changes
                if (!(newSelectedKeyTaskName.Equals(selectedKeyTaskName)) || !(newSelectedKeyTaskDesc.Equals(selectedKeyTaskDesc)))
                {
                    //Executing the Update SQL Query
                    km.updateKeyTaskTable(newSelectedKeyTaskName, newSelectedKeyTaskDesc, km.getKeyTaskID(selectedKeyTaskName));
                    //Toggling back to the default view after the new values are saved.
                    MessageBox.Show("Keytask updated successfully!");
                    //Changing the button text back to update
                    this.btn_UpdateKeyTsk.Text = "Update";
                    //Calling the custom method to go back to default state
                    DefaultKeyTaskState();

                }
                else
                {
                    //Toggling back to the default view as no changes are made.
                    MessageBox.Show("No changes have been made!");
                    //Changing the button text back to update
                    this.btn_UpdateKeyTsk.Text = "Update";
                    //Calling the custom method to go back to default state
                    DefaultKeyTaskState();

                }
            }
        
    }

        private void Btn_CancelKeyTsk_Click(object sender, EventArgs e)
        {
            DefaultKeyTaskState();
            this.btn_AddKeytsk.Text = "Add";
            this.btn_UpdateKeyTsk.Text = "Update";

            //Executing the SQL Query and retrieving the value from database
            this.dataGridView_KeyTask.DataSource = km.getKeyTaskData();
            this.dataGridView_KeyTask.Refresh();
        }

        private void Btn_AddKeytsk_Click(object sender, EventArgs e)
        {
            if (this.btn_AddKeytsk.Text.Equals("Add"))
            {


                //MessageBox.Show(initialVal1 + initialVal2); 
                this.btn_AddKeytsk.Text = "Save";
                //Enabling the Cancel button on the click of Update button and changing the background color
                DisableAllButtonControls(this);
                EnableSpecificControl(this.btn_AddKeytsk);
                EnableSpecificControl(this.btn_CancelKeyTsk);
                //this.btnCancel.Enabled = true;

                
               //Moving the focus to last row and scrolling to it
                int selectedRow = this.dataGridView_KeyTask.Rows[this.dataGridView_KeyTask.RowCount - 1].Index;
                this.dataGridView_KeyTask.Rows[selectedRow].Selected = true;
                this.dataGridView_KeyTask.FirstDisplayedScrollingRowIndex = selectedRow;
                //Disabling sort of datagrid
                foreach (DataGridViewColumn col in this.dataGridView_KeyTask.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                this.dataGridView_KeyTask.ReadOnly = false;
                //Making the datagrid rows as read only (except the one that has been selected)
                foreach (DataGridViewRow row in this.dataGridView_KeyTask.Rows)
                {
                    if (row.Index != selectedRow)
                    {
                        row.ReadOnly = true;
                    }
                }
            }
            else if (this.btn_AddKeytsk.Text.Equals("Save"))
            {
                //Retrieving the new screen name and description
                newSelectedKeyTaskName = this.dataGridView_KeyTask.Rows[this.dataGridView_KeyTask.RowCount - 2].Cells[0].Value.ToString();
                newSelectedKeyTaskDesc = this.dataGridView_KeyTask.Rows[this.dataGridView_KeyTask.RowCount - 2].Cells[1].Value.ToString();

                //Comparing old values with new values to check if whether user has made any changes
                if (!(newSelectedKeyTaskName.Equals(string.Empty) && !(newSelectedKeyTaskDesc.Equals(string.Empty))))
                {
                    //Executing the Update SQL Query
                    km.addKeyTask(newSelectedKeyTaskName, newSelectedKeyTaskDesc);
                    //Toggling back to the default view after the new values are saved.
                    MessageBox.Show("KeyTask added successfully!");
                    //Changing the button text back to Add
                    this.btn_AddKeytsk.Text = "Add";
                    //Calling the custom method to go back to default state
                    DefaultKeyTaskState();
                }
                else
                {
                    //Toggling back to the default view as no changes are made.
                    MessageBox.Show("Please enter a Keytask name & description and try again.");
                    //Changing the button text back to Add
                    this.btn_AddKeytsk.Text = "Add";
                    //Calling the custom method to go back to default state
                    DefaultKeyTaskState();
                    //Executing the SQL Query and retrieving the value from database
                    this.dataGridView_KeyTask.DataSource = km.getKeyTaskData();
                    this.dataGridView_KeyTask.Refresh();
                }
            }
        }

        private void Btn_DeleteKeytsk_Click(object sender, EventArgs e)
        {
            selectedKeyTaskName = this.dataGridView_KeyTask.SelectedRows[0].Cells[0].Value.ToString();
            km.deleteKeyTask(km.getKeyTaskID(selectedKeyTaskName));
            //Executing the SQL Query and retrieving the value from database
            this.dataGridView_KeyTask.DataSource = km.getKeyTaskData();
            this.dataGridView_KeyTask.Refresh();
            MessageBox.Show(selectedKeyTaskName + " has been successfully deleted.");
            DefaultKeyTaskState();
        }
    }
}
