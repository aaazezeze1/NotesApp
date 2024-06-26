﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class ToDoForm : Form
    {
        public ToDoForm()
        {
            InitializeComponent();
            comboBox1taskType.Items.AddRange(new string[] { "Personal Tasks", "School Tasks", "Work Tasks", "Other Tasks" });
        }

        private DateTimePicker DueDateTimePicker;
        private ComboBox TaskTypeComboBox;

        DataTable todoList = new DataTable();
        bool isEditing = false;

        private void Form3_Load(object sender, EventArgs e)
        {
            TaskTypeComboBox = comboBox1taskType;

            todoList.Columns.Add("Title");
            todoList.Columns.Add("Description");
            todoList.Columns.Add("Due Date", typeof(DateTime));
            todoList.Columns.Add("Task Type");

            ToDoListView.DataSource = todoList;
            ToDoListView.Rows[0].DefaultCellStyle.BackColor = Color.DarkSlateGray;
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            TitleTxtBox.Text = "";
            DescTxtBox.Text = "";
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            isEditing = true;
            TitleTxtBox.Text = todoList.Rows[ToDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
            DescTxtBox.Text = todoList.Rows[ToDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                todoList.Rows[ToDoListView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Unable to Delete");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                todoList.Rows[ToDoListView.CurrentCell.RowIndex]["Title"] = TitleTxtBox.Text;
                todoList.Rows[ToDoListView.CurrentCell.RowIndex]["Description"] = DescTxtBox.Text;
                todoList.Rows[ToDoListView.CurrentCell.RowIndex]["Due Date"] = dtpDueDate.Value; // Save due date
                todoList.Rows[ToDoListView.CurrentCell.RowIndex]["Task Type"] = TaskTypeComboBox.Text; // Save task type
            }
            else
            {
                todoList.Rows.Add(TitleTxtBox.Text, DescTxtBox.Text, dtpDueDate.Value, TaskTypeComboBox.Text);
            }

            TitleTxtBox.Text = "";
            DescTxtBox.Text = "";
            isEditing = false;
        }

        private void NewButton_MouseHover(object sender, EventArgs e)
        {
            NewButton.BackColor = Color.DarkSlateGray;
        }

        private void NewButton_MouseLeave(object sender, EventArgs e)
        {
            NewButton.ResetBackColor();
            NewButton.BackColor = Color.DimGray;
        }

        private void EditButton_MouseHover(object sender, EventArgs e)
        {
            EditButton.BackColor = Color.DarkSlateGray;
        }

        private void EditButton_MouseLeave(object sender, EventArgs e)
        {
            EditButton.ResetBackColor();
            EditButton.BackColor = Color.DimGray;
        }

        private void DeleteButton_MouseHover(object sender, EventArgs e)
        {
            DeleteButton.BackColor = Color.DarkSlateGray;
        }

        private void DeleteButton_MouseLeave(object sender, EventArgs e)
        {
            DeleteButton.ResetBackColor();
            DeleteButton.BackColor = Color.DimGray;
        }

        private void SaveButton_MouseHover(object sender, EventArgs e)
        {
            SaveButton.BackColor = Color.DarkSlateGray;
        }

        private void SaveButton_MouseLeave(object sender, EventArgs e)
        {
            SaveButton.ResetBackColor();
            SaveButton.BackColor = Color.DimGray;
        }

        private void btn1Schedule_Click(object sender, EventArgs e)
        {
            var SchedForm3 = new CalendarForm();
            SchedForm3.Show();
            this.Hide();
            SchedForm3.FormClosed += (s, args) => this.Show();
        }

        private void btn2ToDoList_Click(object sender, EventArgs e)
        {
            //var ToDoListForm5 = new Form5();
            //ToDoListForm5.Show();
            //ToDoListForm5.FormClosed += (s, args) => this.Show();
        }

        private void btn4Formula_Click(object sender, EventArgs e)
        {
            var FormulaForm4 = new FormulaForm();
            FormulaForm4.Show();
            this.Hide();
            FormulaForm4.FormClosed += (s, args) => this.Show();
        }

        private void btn3Converter_Click(object sender, EventArgs e)
        {
            var ConverterForm7 = new ConverterForm();
            ConverterForm7.Show();
            this.Hide();
            ConverterForm7.FormClosed += (s, args) => this.Show();
        }

        private void labl1BeSMART_Click(object sender, EventArgs e)
        {
            var NotesApp = new NotesApp();
            NotesApp.Show();
            this.Hide();
            NotesApp.FormClosed += (s, args) => this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var NotesApp = new NotesApp();
            NotesApp.Show();
            this.Hide();
            NotesApp.FormClosed += (s, args) => this.Show();
        }
    }
}
