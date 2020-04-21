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

    public partial class AddDesetance : Form
    {
        private DbAcess db = new DbAcess();
        public AddDesetance()
        {
            InitializeComponent();
            loadComboData();
        }
        public void loadComboData()
        {
           // db ab = new db();

            var mlist = db.stations.ToList();

            loc1.DisplayMember = "StationName";
            loc1.ValueMember = "StationsId";
            loc1.DataSource = mlist;
            Loc2.DisplayMember = "StationName";
            Loc2.ValueMember = "StationsId";
            Loc2.DataSource = mlist;
        }
        Queue<AddDistance> addDes = new Queue<AddDistance>();
    
        private void updateStatus()
        {
            commitView.Clear();
            foreach (AddDistance value in addDes)
            {
                commitView.Items.Add(value.stationtwo+"<-"+value.distance+"->"+value.stationtwo);
            }
            NoOfCommitsHint.Text = "Items to be commited  " + addDes.Count;
        }
    private void Add_Click(object sender, EventArgs e)
        {
            AddDistance a = new AddDistance();
            a.stationone = Convert.ToInt32(loc1.SelectedValue);
            a.stationtwo = Convert.ToInt32(Loc2.SelectedValue);
            a.distance = Convert.ToDouble(Text_distance.Text);
            addDes.Enqueue(a);
            Text_distance.Text = "";
            updateStatus();
        }

        private void Add_All_Click(object sender, EventArgs e)
        {
            while (addDes.Count > 0)
            {
                AddDistance a = new AddDistance();
                a = addDes.Dequeue();
                StationDistance stationDistance = new StationDistance();
                stationDistance.Distance1 = a.stationone;
                stationDistance.Distance2 = a.stationtwo;
                stationDistance.Distance = a.distance;
               
                db.stationDistances.Add(stationDistance);
                db.SaveChanges();
                
            }
            updateStatus();
        }
        
        private void btn_search_Click(object sender, EventArgs e)
        {
            LinkedList<int[]> graph = new LinkedList<int[]>();

            //db ab = new db();
            int c = 0;

            var list = db.stations.ToList();

            
            for(int yy=0;yy<list.Count;yy++)
            {

                int[] xdata = new int[list.Count];
                int stationy = list[yy].StationsId;
                for (int xx=0;xx<list.Count;xx++)
                {
                    int stationx = list[xx].StationsId;
                    var ss = db.stationDistances.Where(a=>a.Distance1== stationy && a.Distance2== stationx).FirstOrDefault();
                    if (ss !=null)
                    {
                        xdata[xx] = Convert.ToInt32(ss.Distance);
                    }
                    else {
                        xdata[xx] = 0;
                    }
                }
                graph.AddFirst(xdata);
                
            }

 
            int[] getdata = Dijkstra.DijkstraAlgo(graph, 0, 5);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MinimumConnectors a = new MinimumConnectors(db);
            a.Visible = true;
            this.Hide();
            
        }
    }
}
