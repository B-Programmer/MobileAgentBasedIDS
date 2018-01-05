using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FloydWarshallShortestPathProject;
using System.Collections;

namespace MobileAgentBasedIDS
{
    public partial class FrmHostMASetUp : Form
    {
        DijkstraShortestPath dijkstraShortestPath;
        ArrayList MAServerNodes;
        ArrayList MAClientNodes;
        ArrayList MobileAgent;
        int noOfNodes;

        public FrmHostMASetUp()
        {
            InitializeComponent();
            MAClientNodes = new ArrayList();
            MAServerNodes = new ArrayList();
            MobileAgent = new ArrayList();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            noOfNodes = Convert.ToInt32(txtNoOfNodes.Text);
            if (noOfNodes <= 0 || noOfNodes > DijkstraShortestPath.MAXNODE)
            {
                MessageBox.Show("Wrong Input! Please, Read in correct digit from 1 to 100:", "MobileAgentBasedIDS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //txtNoOfNodes.
            }
            else
            {
                for (int i = 1; i <= noOfNodes; i++)
                {
                    lstNodes.Items.Add("Node " + i);
                }
                dijkstraShortestPath = new DijkstraShortestPath(noOfNodes);
                //int[,] Weight = dijkstraShortestPath.GenerateWeight();
                dijkstraShortestPath.GenerateWeight();
                Console.WriteLine("Nodes and Distance(Weight) Table");
                displayListOfNodesAndWeights(dijkstraShortestPath.Weight, 1);
            }


        }              

        private void FrmHostMASetUp_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            //Add Column Header for listView 1
            listView1.Columns.Add("Nodes", 130);
            listView1.Columns.Add("Neighbor Nodes", 130);
            listView1.Columns.Add("Distance(Weight)", 170);
            listView1.Items.Clear();

            listView2.View = View.Details;
            listView2.GridLines = true;
            listView2.FullRowSelect = true;
            //Add Column Header for listView 2
            listView2.Columns.Add("Nodes", 130);
            listView2.Columns.Add("Neighbor Nodes", 130);
            listView2.Columns.Add("Shortest Delay", 170);
            listView2.Items.Clear();

            listView3.View = View.Details;
            listView3.GridLines = true;
            listView3.FullRowSelect = true;
            //Add Column Header for listView 3
            listView3.Columns.Add("Mobile Agents", 130);
            listView3.Columns.Add("Server Nodes", 130);
            listView3.Columns.Add("Client Nodes", 130);
            listView3.Items.Clear();
        }

        private void displayListOfNodesAndWeights(int[,] W, int t)
        {
            int i, j;
            string[] arr = new string[4];
            ListViewItem itm;
            if(t == 1) listView1.Items.Clear();
            else if (t == 2) listView2.Items.Clear();
            //The weights/costs Table of all edges between 2 Vertices in the graph
            for (i = 0; i < W.GetLength(0); i++)
            {
                arr[0] = "Node "+ (i+1);
                for (j = 0; j < W.GetLength(1); j++)
                {
                    Console.Write("{0,6}", W[i, j]);
                    //add items to ListView

                    arr[1] = "Node " + (j+1);
                    arr[2] = W[i, j].ToString();

                    itm = new ListViewItem(arr);
                    if (t == 1) listView1.Items.Add(itm);
                    else if (t == 2) listView2.Items.Add(itm);
                }
                Console.WriteLine();
            }
        }

        private void btnGenerateShortestDelay_Click(object sender, EventArgs e)
        {
            dijkstraShortestPath.getShortestDelay();
            Console.WriteLine("Nodes and Shortest Delay(Weight) Table");
            displayListOfNodesAndShortestDelay(dijkstraShortestPath.Dist);
        }

        private void displayListOfNodesAndShortestDelay(int[,] dist)
        {
            displayListOfNodesAndWeights(updateDistForMA(dist), 2);
        }

        private int[,] updateDistForMA(int[,] dist)
        {
            int k;
            /* Update dist by set the diagonal elements to zeroes for Mobile Agent setting */
            for (k = 0; k < dist.GetLength(0); k++)
            {
                dist[k, k] = 0;
            }
            return dist;
        }

        private int[] generateMaxDelay(int[,] dist)
        {
            int[] maxDelay = new int[dist.GetLength(0)];
            int i, j;
            /* Generating the maximum delay for each row in the Dist(Delay) table */
            for (i = 0; i < dist.GetLength(1); i++)
            {
                maxDelay[i] = dist[i, 0]; //set the first element in the table as the maximum delay
                    for (j = 0; j < dist.GetLength(0); j++)
                    {
                        if (dist[i, j] > maxDelay[i])
                        {
                            maxDelay[i] = dist[i, j]; //set maxDelay has the new large value
                        }
                    }

            }
            displayTable(maxDelay);
            return maxDelay;
        }

        private ArrayList getMAIndex(int[] maxDelay, int noOfMAgent)
        {
            ArrayList MAIndex = new ArrayList();
            int i, k, lowest, index;
            /* Generating the index position of each mobile agent from the MaxDelay table by getting the min(max(delay)) nodes */
            for (k = 0; k < noOfMAgent; k++)
            {
                lowest = maxDelay[0]; index = 0; //set the first element in the table as the minimum delay and initialize the index position
                for (i = 1; i < maxDelay.GetLength(0); i++)
                {
                    
                    {
                        if (lowest > maxDelay[i])
                        {
                            lowest = maxDelay[i]; //set maxDelay has the new lowest value
                            index = i;  //get the index position
                        }
                    }

                }
                MAIndex.Add(index); //Add the index to MAIndex table
                maxDelay[index] = 99999; //reset the element at the current index position of the lowest item as Big Number for the next MAIndex 
            }
            return MAIndex;
        }

        private void generateMA(int[,] dist, ArrayList MAIndex)
        {
            int i, j, k, lowest, index;
            //object[] arrMAIndex = MAIndex.ToArray();
            /* Generating the index position for the mobile agents' servers and clients */
            for (j = 0; j < dist.GetLength(1); j++)  //loop through distance table column-wise
            {
                lowest = dist[(int)MAIndex[0], j]; index = (int)MAIndex[0]; k = 0; //set the first element in the table as the minimum delay and initialize the index position
                for (i = 1; i < MAIndex.Count; i++)
                {

                    {
                        if (lowest > dist[(int)MAIndex[i],j])
                        {
                            lowest = dist[(int)MAIndex[i], j]; //set Dist[Delay] has the new lowest value
                            index = (int)MAIndex[i];  //get the index position for the serving server
                            k = i;  //get the Mobile Agent index
                        }
                    }

                }
                MAClientNodes.Add(j); //Add the index for the client nodes to MAClient Nodes table
                MAServerNodes.Add(index);  //Add the index for the server nodes to MAServer Nodes table
                MobileAgent.Add(k);  //Add the index for the MA to Mobile Agent table
            }
        }

        private void btnCreateMA_Click(object sender, EventArgs e)
        {
            int noOfMAgent = Convert.ToInt32(txtNoOfMobileAgents.Text);
            if (noOfMAgent <= 0 || noOfMAgent > noOfNodes)
            {
                MessageBox.Show("Wrong Input! Please, Read in correct digit from 1 to 10:", "MobileAgentBasedIDS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                generateMA(updateDistForMA(dijkstraShortestPath.Dist), getMAIndex(generateMaxDelay(updateDistForMA(dijkstraShortestPath.Dist)), noOfMAgent));
                displayMA();
            }
        }

        private void displayMA()
        {
            int i, j;
            string[] arr = new string[4];
            ListViewItem itm;
            listView3.Items.Clear();
            //To display the MobileAgents, Server Nodes(Host), and Client Nodes
            for (i = 0; i < MAServerNodes.Count; i++)
            {
                arr[0] = "Mobile Agent " + ((int)MobileAgent[i] + 1);
                arr[1] = "Node " + ((int)MAServerNodes[i] + 1);
                arr[2] = "Node " + ((int)MAClientNodes[i] + 1); 

                    itm = new ListViewItem(arr);
                    listView3.Items.Add(itm);
            }
        }

        private void displayTable(int[] m)
        {
            int j;
            Console.WriteLine("MAX-MIN Table");
            for (j = 0; j < m.GetLength(0); j++)
            {
                Console.Write("{0,6}", m[j]);
                //add items to ListView                
            }
            Console.WriteLine();
        }
    }
}
