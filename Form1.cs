using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainStations.DAL;
using TrainStations.Models;

namespace TrainStation
{
    public partial class Form1 : Form
    {
        private DbAcess db = new DbAcess();

        public Form1()
        {
            var list = db.stationDistances.ToList();
            InitializeComponent();
        }
        Queue<string> Names = new Queue<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            Names.Enqueue(textBox1.Text);
            textBox1.Text = "";
            updateStatus();
        }
        private void updateStatus()
        {
            commitView.Clear();
            foreach (String value in Names)
            {
                commitView.Items.Add(value);
            }
            NoOfCommitsHint.Text = "Items to be commited  " + Names.Count;
        }
        private void addall_Click(object sender, EventArgs e)
        {
            while (Names.Count > 0)
            {
                Stations addstations = new Stations();
                addstations.StationName = Names.Dequeue();
                db.stations.Add(addstations);
                db.SaveChanges();
               
              
            }
            updateStatus();

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            AddDesetance a = new AddDesetance();
            a.Visible = true;
            this.Hide();
        }
    }
}
