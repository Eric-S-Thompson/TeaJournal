﻿/**
 * Summary: Defines functionality of our main tea form
 *          All events relating to searching and modifying tea data and changing tabs
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeaJournal.Infrastructure;

namespace TeaJournal
{
    public partial class MainForm : Form
    {
        DatabaseManager<Tea> dataHandler; // Populate and hold our tea list
        Infrastructure.TeaList allTeas;
        List<Tea> currentTeas;      // Stores all teas of currently selected type
        Tea currentTea;             // Currently selected tea
        public MainForm()
        {
            InitializeComponent();

            // Create our tea database
            dataHandler = new DatabaseManager<Tea>("teas");

            // TEMP: Testing database search functionality
            //Func<Tea, bool> test = Tea => Tea.type == Tea.teaType.Black;
            currentTeas = dataHandler.FindAllData(Tea => Tea.type == Tea.teaType.Black);
            foreach (Tea t in currentTeas)
            {
                Debug.WriteLine("FOUND TEA USING DATABASE: " + t.name); 
            }
            Debug.WriteLine("SINGLE TEA: " + dataHandler.FindData(1).name);
            // END TEMP

            //allTeas = new TeaList();
            //currentTeas = allTeas.GetTeaOfType(Tea.teaType.Black);
            //currentTeas = initialize.teaList;

            // Clear out the forms (possibly unneeded)
            ClearTea();
        }
        // Adds each possible teatype to our TeaType dropdown in the form
        private void InitializeTeaTypes()
        {
            TeaTypes.Items.Add(Tea.teaType.Black);
            TeaTypes.Items.Add(Tea.teaType.Oolong);
            TeaTypes.Items.Add(Tea.teaType.Green);
            TeaTypes.Items.Add(Tea.teaType.White);
            TeaTypes.Items.Add(Tea.teaType.Herbal);
            TeaTypes.Items.Add(Tea.teaType.Other);
        }

        /*
         * Update tea info boxes with the current tea
         */
        private void UpdateTea(Tea tea)
        {
            Debug.WriteLine("UpdateTea: " + tea.name + " " + TeaList.SelectedItem.ToString());
            Debug.WriteLine(tea.brewTime);
            if (currentTea is null || tea.name != currentTea.name) // Already is selected, no update needed
            {
                TeaName.Text = tea.name;
                TeaBrewTime.Value = tea.brewTime; // DateTimePicker, uses Date type
                TeaBrewNotes.Text = tea.otherInstructions;
                TeaNotes.Text = tea.notes;
                currentTea = tea;
            }
        }
        /**
         * Updates the info of our currently selected tea
         */
        private void SaveCurrentTea(Tea tea)
        {
            Debug.WriteLine("Saving current tea");
            tea.name = TeaName.Text;
            tea.brewTime = TeaBrewTime.Value;
            tea.otherInstructions = TeaBrewNotes.Text;
            tea.notes = TeaNotes.Text;
            dataHandler.UpdateData(tea);
        }

        /**
         * Clears out the form text boxes to default values
         */
        private void ClearTea()
        {
            TeaName.Clear();
            TeaBrewTime.ResetText();
            TeaBrewNotes.Clear();
            TeaNotes.Clear();
            currentTea = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        /*
         * User clicks on the tab button of our main tea tab
         * TODO: Clear out current panel and replace it with our Tea panel
         */
        private void TeaTab_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Hello world!");
            if (currentTea is null)
            {
                Debug.WriteLine("Is null!");
            }
        }

        /**
         * Updates tea form when a new tea is selected from our Tea List
         */
        private void TeaList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("MainForm.cs : TeaList_SelectedIndexChanged");
            // User has selected a null space
            if (TeaList.SelectedItem is null)
            {
                ClearTea();
                return;
            }
            // Save our current tea (if selection is valid)
            if (currentTea is not null)
            {
                int previousTeaIndex = TeaList.Items.IndexOf(currentTea);
                SaveCurrentTea(currentTea);
                if(previousTeaIndex != -1) // If a different tea type was selected the index won't be valid
                {
                    TeaList.Items[previousTeaIndex] = currentTea;
                }
            }
            string item = TeaList.SelectedItem.ToString(); // Stores selected tea name
            bool foundItem = false;
            // Search for the selected tea within the current tea type
            foreach (Tea t in currentTeas)
            {
                if (t.name == item)
                {
                    foundItem = true;
                    UpdateTea(t);
                }
            }
            // Item not found
            if (!foundItem)
            {
                ClearTea();
            }
        }

        /**
         * Changes current tea type category to the newly selected one
         * Updates our current tea list with every tea of that type and adds it to the tea list
         */
        private void TeaType_Changed(object sender, EventArgs e)
        {
            String selected = TeaTypes.SelectedItem.ToString();
            Tea.teaType type = (Tea.teaType) Enum.Parse(typeof(Tea.teaType), selected, true);
            List<Tea> newTeas = dataHandler.FindAllData(Tea => Tea.type == type);

            TeaList.Items.Clear();
            foreach (Tea t in newTeas)
            {
                TeaList.Items.Add(t);
            }
            currentTeas = newTeas;
        }

        private void addTea_Click(object sender, EventArgs e)
        {
            //Debug.WriteLine(TeaTypes.SelectedItem.ToString());
            if (TeaTypes.SelectedItem is null)
            {
                TeaTypes.SelectedIndex = 0;
            }
            //Tea.teaType newType = Tea.stringToEnum(TeaTypes.SelectedIndex.ToString());
            Tea.teaType newType = Tea.stringToEnum(TeaTypes.SelectedItem.ToString());
            Debug.Write("Tea type: " + newType);
            Tea newTea = new Tea(newType, "New Tea", "Instructions", "Notes");
            dataHandler.AddData(newTea);
            //TeaList.Items.Add(newTea.name);
            //allTeas.AddTea(newTea);
            TeaList.Items.Add(newTea);
            currentTeas.Add(newTea);
        }

        private void ExtraNotes_TextChanged(object sender, EventArgs e)
        {

        }

        private void TeaName_TextChanged(object sender, EventArgs e)
        {

        }

        /**
         * Called when the form closes, saves our tea information for the next session
         * TODO: Saving needs to be implemented still
         */
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (currentTea is not null)
            {
                SaveCurrentTea(currentTea);
            }
            Debug.WriteLine("Form closing.");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
