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
            table.Columns.Add("Тварина", typeof(string));
            table.Columns.Add("Площа", typeof(double));
            table.Columns.Add("Об'єм", typeof(double));
            table.Columns.Add("Розмірність", typeof(string));
            table.Columns.Add("Температура", typeof(double));

            // Додаємо дані до таблиці
            foreach (var enclosure in enclosures)
            {
                string dimensions = enclosure.GetDimensions();
                double temperature = enclosure.GetTemperature();

                table.Rows.Add(enclosure.GetType().Name, enclosure.CalculateArea(), enclosure.CalculateVolume(), dimensions, temperature);
            }

            // Виводимо дані в DataGridView
            dataGridView1.DataSource = table;

            dataGridView1.Columns["Розмірність"].Width = 150;

            // Виводимо сумарну площу та об'єм
            label5.Text = $"Загальна площа: {zooPlanner.CalculateTotalArea()}";
            label6.Text = $"Загальний об'єм : {zooPlanner.CalculateTotalVolume()}";
        }
    }
}
