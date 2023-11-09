using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ModulControlWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int snakeCount = Convert.ToInt32(textBox1.Text);
            int turtleCount = Convert.ToInt32(textBox2.Text);
            int chameleonCount = Convert.ToInt32(textBox3.Text);

            // Створити зоопарк
            ZooPlanner zooPlanner = new ZooPlanner();

            // Додати вольєри для змій
            for (int i = 0; i < snakeCount; i++)
            {
                zooPlanner.AddEnclosure(new SnakeZoo());
            }

            // Додати вольєри для черепах
            for (int i = 0; i < turtleCount; i++)
            {
                zooPlanner.AddEnclosure(new TurtleZoo());
            }

            // Додати вольєри для хамелеонів
            for (int i = 0; i < chameleonCount; i++)
            {
                zooPlanner.AddEnclosure(new ChameleonZoo());
            }

            // Отримати результати та вивести їх у DataGridView
            DisplayResults(zooPlanner);
        }

        private void DisplayResults(ZooPlanner zooPlanner)
        {
            // Отримуємо список вольєрів
            List<IZoo> enclosures = zooPlanner.GetEnclosures();

            // Створюємо таблицю для DataGridView
            DataTable table = new DataTable();
            table.Columns.Add("Animal", typeof(string));
            table.Columns.Add("Area", typeof(double));
            table.Columns.Add("Volume", typeof(double));
            //table.Columns.Add("Dimensions", typeof(string));
            table.Columns.Add("Temperature", typeof(double));

            // Додаємо дані до таблиці
            foreach (var enclosure in enclosures)
            {
                double temperature = enclosure.GetTemperature();

                table.Rows.Add(enclosure.GetType().Name, enclosure.CalculateArea(), enclosure.CalculateVolume(), temperature);
            }

            // Виводимо дані в DataGridView
            dataGridView1.DataSource = table;

            // Виводимо сумарну площу та об'єм
            label1.Text = $"Total Area: {zooPlanner.CalculateTotalArea()} square meters";
            label2.Text = $"Total Volume: {zooPlanner.CalculateTotalVolume()} cubic meters";
        }
    }
}
