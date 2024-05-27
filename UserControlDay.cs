﻿using DocumentFormat.OpenXml.Bibliography;
using iText.Kernel.Events;
using iText.Kernel.Pdf.Canvas.Parser.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NotesApp
{
    public partial class UserControlDay : UserControl
    {
        private List<Event> events = new List<Event>();
        private ContextMenuStrip eventContextMenu;
        private DateTime currentDate;
        private Event selectedEvent;

        public UserControlDay(DateTime date)
        {
            InitializeComponent();
            InitializeContextMenu();
            currentDate = date;
        }
        private void InitializeContextMenu()
        {
            eventContextMenu = new ContextMenuStrip();
            ToolStripMenuItem editMenuItem = new ToolStripMenuItem("Edit");
            ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Delete");

            editMenuItem.Click += (s, e) => OnEditEventClicked();
            deleteMenuItem.Click += (s, e) => OnDeleteEventClicked();

            eventContextMenu.Items.Add(editMenuItem);
            eventContextMenu.Items.Add(deleteMenuItem);
            // Hook up the ContextMenuStrip's Opening event
            eventContextMenu.Opening += (s, e) =>
            {
                selectedEvent = GetEventAtMousePosition();
            };
        }
        private Event GetEventAtMousePosition()
        {
            Point localMousePos = this.PointToClient(Control.MousePosition);
            foreach (Control control in this.Controls)
            {
                if (control is LinkLabel linkLabel && linkLabel.Bounds.Contains(localMousePos))
                {
                    return events.Find(eventItem => eventItem.Title == linkLabel.Text);
                }
            }
            return null;
        }

        private void OnEditEventClicked()
        {
            if (selectedEvent != null)
            {
                var parent = (CalendarForm)FindForm();
                parent.EditEvent(currentDate, selectedEvent, this);
            }
        }

        private void OnDeleteEventClicked()
        {
            if (selectedEvent != null)
            {
                var parent = (CalendarForm)FindForm();
                parent.DeleteEvent(currentDate, selectedEvent, this);
            }
        }

        public event EventHandler DayClicked;
        private void OnDayClicked()
        {
            DayClicked?.Invoke(this, EventArgs.Empty);
        }
        private void UserControlDay_Click(object sender, EventArgs e)
        {
            OnDayClicked();
        }


        public void SetDay(int day)
        {
            this.lblDays.Text = day.ToString();
        }

        public void HighlightToday()
        {
            this.ForeColor = Color.White;
            this.BackColor = Color.SeaGreen;
        }
        public void AddEvent(Event eventItem)
        {
            if (events.Count < 3)
            {
                events.Add(eventItem);
                DisplayEvents();
            }
            else
            {
                MessageBox.Show("You can only add up to 3 events for this day.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public int GetEventCount()
        {
            return events.Count;
        }

        public void UpdateEvent(Event eventItem)
        {
            DisplayEvents();
        }

        public void RemoveEvent(Event eventItem)
        {
            events.Remove(eventItem);
            DisplayEvents();
        }

        private Event SelectedEvent { get; set; }

        private void DisplayEvents()
        {
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                if (this.Controls[i] is LinkLabel)
                {
                    this.Controls.RemoveAt(i);
                }
            }

            int yOffset = lblDays.Bottom + 5;
            foreach (var eventItem in events)
            {
                LinkLabel eventLabel = new LinkLabel
                {
                    Text = eventItem.Title,
                    AutoSize = true,
                    Location = new Point(lblDays.Left, yOffset),
                    BackColor = eventItem.EventColor,
                    LinkColor = Color.White
                };

                eventLabel.MouseUp += (s, e) =>
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        ShowEventDetails(eventItem);
                    }
                    else if (e.Button == MouseButtons.Right)
                    {
                        selectedEvent = eventItem;
                        eventContextMenu.Show(eventLabel, e.Location);
                    }
                };

                this.Controls.Add(eventLabel);
                yOffset += eventLabel.Height + 2;
            }
        }
        private void ShowEventDetails(Event eventItem)
        {
            string startTime = eventItem.StartTime + " " + eventItem.StartTimePeriod;
            string endTime = eventItem.EndTime + " " + eventItem.EndTimePeriod;

            MessageBox.Show($"Title: {eventItem.Title}\n" +
                            $"Description: {eventItem.Description}\n" +
                            $"Type: {eventItem.EventType}\n" +
                            $"Start Time: {startTime}\n" +
                            $"End Time: {endTime}", "Event Details");
        }

        public class Event
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public Color EventColor { get; set; }
            public string EventType { get; set; }
            public string StartTime { get; set; }
            public string EndTime { get; set; }
            public string StartTimePeriod { get; set; }
            public string EndTimePeriod { get; set; }
        }

    }
}
