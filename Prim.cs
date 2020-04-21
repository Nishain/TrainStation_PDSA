using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStations.Models;

namespace TrainStation
{
    class Prim
    {
        LinkedList<Stations> selectedStations;
        private LinkedList<Stations> data;
        public Prim(List<Stations> input)
        {
            data = new LinkedList<Stations>();
            foreach (Stations s in input)
            {
                data.AddFirst(s);
            }
        }
        public bool checkIfValid(int selectedStation)
        {
            if (selectedStations == null)
            {
                selectedStations = new LinkedList<Stations>();
                selectedStations.AddFirst(data.Single(d => d.StationsId == selectedStation));
                return true;
            }
            if (selectedStations.SingleOrDefault(s => s.StationsId == selectedStation) != null)
                return false;
        
            foreach(Stations s in selectedStations)
            {
               foreach(StationDistance d in s.StationDistances1)
                {
                    if (d.Stations2.StationsId == selectedStation)
                    {
                        selectedStations.AddFirst(d.Stations2);
                        return true;
                    }
                }
            }
            return false;
        }
        public String primAlgo()
        {
            String output = "";
            double totalWeight = 0;
            LinkedList<int> selectedStationIDs = new LinkedList<int>();
            foreach(Stations s in selectedStations)
            {
                selectedStationIDs.AddFirst(s.StationsId);
            }
           
            LinkedList<Stations> markedStations = new LinkedList<Stations>();
            LinkedList<StationDistance> comparingEdges = new LinkedList<StationDistance>();
            markedStations.AddFirst(data.First.Value);
            while(markedStations.Count < selectedStations.Count)
            {
                foreach(Stations s in markedStations)
                {
                    foreach(StationDistance d in s.StationDistances1)
                    {
                        if (selectedStationIDs.Contains(d.Stations2.StationsId) && !markedStations.Contains(d.Stations2))
                            comparingEdges.AddFirst(d);
                    }
                }
                double minWeight = int.MaxValue;
                StationDistance minWeightEdge = null;
                foreach (StationDistance d in comparingEdges)
                {
                    if (d.Distance < minWeight)
                    {
                        minWeight = d.Distance;
                        minWeightEdge = d;
                    }
                }
                comparingEdges.Clear();
                output+=minWeight.ToString() + " " + minWeightEdge.Stations1.StationName + "->" + minWeightEdge.Stations2.StationName+Environment.NewLine;
                totalWeight += minWeight;
                markedStations.AddFirst(minWeightEdge.Stations2);
                
            }
            output += "Total weight " + totalWeight;
            return output;
        }
        
       /* public void PrimAlgo(String[] userSelectedStations,LinkedList<String> data)
        {
            LinkedList<String> markedNodeNames = new LinkedList<string>();
            LinkedList<Node> markedNodes = new LinkedList<Node>();
            int totalWeight = 0;
            Node firstNode = getFirstNode(stations[0]);
            markedNodes.AddFirst(firstNode);
            markedNodeNames.AddFirst(stations[0]);
            LinkedList<Direction> stagedData = new LinkedList<Direction>();
            while (markedNodes.Count < stations.Length)
            {
                foreach (Node x in markedNodes)
                {
                    foreach (Direction d in x.paths)
                    {
                        if (!markedNodeNames.Contains(d.target.name)
                            && stations.Contains(d.target.name))
                        {
                            stagedData.AddFirst(d.setSource(x));
                        }
                    }
                }
                int minWeight = int.MaxValue;
                Direction minWeightEdge = null;
                foreach (Direction d in stagedData)
                {
                    if (d.weight < minWeight)
                    {
                        minWeight = d.weight;
                        minWeightEdge = d;
                    }
                }
                stagedData.Clear();
                print(minWeight.ToString() + " " + minWeightEdge.source.name + "->" + minWeightEdge.target.name);
                totalWeight += minWeight;
                markedNodes.AddFirst(minWeightEdge.target);
                markedNodeNames.AddFirst(minWeightEdge.target.name);
            }
            return totalWeight;
        }*/
    }
}
