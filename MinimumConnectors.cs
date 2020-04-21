using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainStations.Models;

namespace TrainStation
{
    public partial class MinimumConnectors : Form
    {
        Prim prim;
        public MinimumConnectors(TrainStations.DAL.DbAcess db)
        {
            prim = new Prim(db.stations.ToList());
          //  insertDummyData(db);
            InitializeComponent();
            selectStationComboBox.DisplayMember = "StationName";
            selectStationComboBox.ValueMember = "StationsId";
            selectStationComboBox.DataSource=db.stations.ToList();
        }
        /*
        private void addEdge(Queue<AddDistance> queue,int src,int dst,int weight)
        {
            AddDistance a=new AddDistance(), b=new AddDistance();
            
            a.stationone = b.stationtwo= (src+3);
            a.stationtwo = b.stationone = (dst+3);
            a.distance = b.distance = weight;
            queue.Enqueue(a);
            queue.Enqueue(b);
        }
        public void insertDummyData(TrainStations.DAL.DbAcess db)
        {
            Queue<AddDistance> queue = new Queue<AddDistance>();
            StationDistance stationDistance;
            AddDistance addDistance;
            addEdge(queue, 1, 2, 3);
            addEdge(queue, 2, 3, 5);
            addEdge(queue, 3, 4, 4);
            addEdge(queue, 4, 5, 2);
            addEdge(queue, 5, 0, 4);

            addEdge(queue, 1, 6, 7);
            addEdge(queue, 2, 6, 8);
            addEdge(queue, 3, 6, 6);
            addEdge(queue, 4, 6, 8);
            addEdge(queue, 5, 6, 5);
            while (queue.Count > 0)
            {
                addDistance = queue.Dequeue();
                stationDistance = new StationDistance();
                stationDistance.Distance = addDistance.distance;
                stationDistance.Distance1 = addDistance.stationone;
                stationDistance.Distance2 = addDistance.stationtwo;
                db.stationDistances.Add(stationDistance);
            }
            db.SaveChanges();
        }*/
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!prim.checkIfValid(Convert.ToInt32(selectStationComboBox.SelectedValue)))
            {
                popSelectionError();
                return;
            }
            selectedStationContainer.Items.Add(selectStationComboBox.SelectedValue.ToString());
        }
        private void popSelectionError()
        {
            string title = "Invalid Station selected";
            string message = "the selected station must be connected to previously selected stations";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            output.Text = prim.primAlgo();
        }
    }
}
