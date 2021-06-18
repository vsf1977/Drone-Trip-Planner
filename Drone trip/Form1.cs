using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Drone_trip.Class;
using Drone_trip.Models;

namespace Drone_trip
{
    public partial class Form1 : Form
    {
        //Lists for save information aboit drones, sites and Trips
        List<Drone> Drones = new List<Drone>();
        List<Site> Sites = new List<Site>();
        List<Trip> Trips = new List<Trip>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            

            //a few drones and sites are saved in the lists and the controls for faster tests
            Drone d1 = new Drone();
            d1.Name = "Drone #1";
            d1.Weight = 100;
            Drones.Add(d1);


            Drone d2 = new Drone();
            d2.Name = "Drone #2";
            d2.Weight = 150;
            Drones.Add(d2);

            Drone d3 = new Drone();
            d3.Name = "Drone #3";
            d3.Weight = 80;
            Drones.Add(d3);

            Drone d4 = new Drone();
            d4.Name = "Drone #4";
            d4.Weight = 100.5;
            Drones.Add(d4);

            for (int i = 0; i < Drones.Count; i++)
                cmb_drone_list.Items.Add(Drones[i].Name + " | " + Drones[i].Weight + " Kg.");

            Site s1 = new Site();
            s1.Name = "Site #1";
            s1.Weight = 40.5;
            Sites.Add(s1);

            Site s2 = new Site();
            s2.Name = "Site #2";
            s2.Weight = 50;
            Sites.Add(s2);

            Site s3 = new Site();
            s3.Name = "Site #3";
            s3.Weight = 80.5;
            Sites.Add(s3);

            Site s4 = new Site();
            s4.Name = "Site #4";
            s4.Weight = 10;
            Sites.Add(s4);

            Site s5 = new Site();
            s5.Name = "Site #5";
            s5.Weight = 20;
            Sites.Add(s5);

            Site s6 = new Site();
            s6.Name = "Site #6";
            s6.Weight = 39.5;
            Sites.Add(s6);

            for (int i = 0; i < Sites.Count; i++)
                lb_site_list.Items.Add(Sites[i].Name + " | " + Sites[i].Weight + " Kg.");
        }

        //procedure to let only numbers and one decimal point
        private bool Validate_number(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                return true;
            else if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
                return true;
            else
                return false;
        }

        //the procedure above is called in the event Keypress
        private void txt_drone_max_weight_KeyPress(object sender, KeyPressEventArgs e)

        {
            e.Handled = Validate_number(sender,e);
        }

        private void txt_site_pack_weight_KeyPress(object sender, KeyPressEventArgs e)

        {
            e.Handled = Validate_number(sender, e);
        }

        private void btn_new_drone_Click(object sender, EventArgs e)
        {
            //the name of the drone is checked
            if (txt_drone_name.Text.Trim().Length == 0)
            {
                MessageBox.Show("You haven´t specified the drone name", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_drone_name.Focus();
            }
            //the max weight of the drone is checked
            else if (txt_drone_max_weight.Text.Trim().Length == 0)
            {
                MessageBox.Show("You haven´t specified the max weight supported by the drone", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_drone_max_weight.Focus();
            }
            else
            {
                double val = Convert.ToDouble(txt_drone_max_weight.Text);
                //the weight is validated to be greater than 1
                if (val < 1)
                {
                    MessageBox.Show("The max weight supported by the drone can´t be so small", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_drone_max_weight.Focus();
                }
                else
                {
                    Drone d1 = new Drone();
                    d1.Name = txt_drone_name.Text.Trim();
                    d1.Weight = val;
                    bool exists = false;
                    //the name of the drone is checked in order to there weren´t two drones with the same name
                    for (int i = 0; i < Drones.Count; i++)
                        if (d1.Name == Drones[i].Name)
                            exists = true;
                    if (exists)
                    {
                        MessageBox.Show("The name you have specified already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_drone_name.Focus();
                    }
                    else
                    {
                        //the drone is saved in the list and added to the combobox
                        Drones.Add(d1);
                        MessageBox.Show("The drone has been added successfully", "Drone site planner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_drone_name.Clear();
                        txt_drone_max_weight.Clear();
                        cmb_drone_list.Items.Clear();
                        for (int i = 0; i < Drones.Count; i++)
                            cmb_drone_list.Items.Add(Drones[i].Name + " | " + Drones[i].Weight + " Kg.");
                    }                       
                }
            }
        }

        private void txt_new_site_Click(object sender, EventArgs e)
        {
            //the name of the site is checked
            if (txt_site_name.Text.Trim().Length == 0)
            {
                MessageBox.Show("You haven´t specified the site name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_site_name.Focus();
            }
            //the weight of the package is checked
            else if (txt_site_pack_weight.Text.Trim().Length == 0)
            {
                MessageBox.Show("You haven´t specified the weight of the package", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_site_pack_weight.Focus();
            }
            else
            {
                double val = Convert.ToDouble(txt_site_pack_weight.Text);
                //the weight of the package is validated to be greater than 1
                if (val < 1)
                {
                    MessageBox.Show("The weight of the package can´t be so small", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_site_pack_weight.Focus();
                }
                else
                {
                    Site s1 = new Site();
                    s1.Name = txt_site_name.Text.Trim();
                    s1.Weight = val;
                    bool exists = false;
                    //the name of the site is checked in order to there weren´t two sites with the same name
                    for (int i = 0; i < Sites.Count; i++)
                        if (s1.Name == Sites[i].Name)
                            exists = true;
                    if (exists)
                    {
                        MessageBox.Show("The name you have specified already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_site_name.Focus();
                    }
                    else
                    {
                        //the site is saved in the list and added to the listbox
                        Sites.Add(s1);
                        MessageBox.Show("The site has been added successfully", "Drone site planner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_site_name.Clear();
                        txt_site_pack_weight.Clear();
                        lb_site_list.Items.Clear();
                        for (int i = 0; i < Sites.Count; i++)
                            lb_site_list.Items.Add(Sites[i].Name + " | " + Sites[i].Weight + " Kg.");
                    }
                }
            }
        }

        //procedure for call the recursive procedure that does all the combinations of the sites, in order to get the best trip
        private void Comb(string[,] temp , int n)
        {
            string[,] temp_new = new string[n, 2];
            Comb_rec(temp, temp_new, 0, 0);
        }

        //recursive procedure to iterate throught all the posibles combinations
        private void Comb_rec(string[,] temp, string[,] temp_new, int posOriginal, int posCombinacion)
        {
            if (posCombinacion == temp_new.Length/2)
            {
                string Sites_names="";
                int Sites_count = 0;
                double Total_weight = 0;
                for (int x=0;x< temp_new.Length/2;x++)
                {
                    if (Sites_names == "")
                        Sites_names = temp_new[x, 0];
                    else
                        Sites_names = Sites_names + ", " + temp_new[x, 0];
                    Sites_count++;
                    Total_weight += Convert.ToDouble(temp_new[x, 1]);
                }
                //the trip is saved into the list
                Trip t1 = new Trip();
                t1.Sites_name = Sites_names;
                t1.Sites_count = Sites_count;
                t1.Total_weight = Total_weight;
                Trips.Add(t1);
            }
            else if (posOriginal == temp.Length/2)
                return;
            else
            {
                temp_new[posCombinacion, 0] = temp[posOriginal, 0];
                temp_new[posCombinacion, 1] = temp[posOriginal, 1];
                Comb_rec(temp, temp_new, posOriginal + 1, posCombinacion + 1);
                Comb_rec(temp, temp_new, posOriginal + 1, posCombinacion);
            }
        }

        //procedure called by the event SelectedIndexChanged to make all the combinations of the trip list and check them to get best trip
        private void cmb_drone_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            double Max_weight = Drones[cmb_drone_list.SelectedIndex].Weight;
            int size = Sites.Count;
            string[,] temp = new string[size, 2];
            Trips.Clear();
            for (int i = 0; i < size; i++)
            {
                temp[i, 0] = Sites[i].Name;
                temp[i, 1] = Sites[i].Weight.ToString();
            }
            for (int j = 0; j < size; j++)
            {
                Comb(temp, j + 1);
            }
            int Trip_index = 0;
            int Alt_trip_index = 0;
            int Sites_count = 1000;
            double Total_weight = 0;
            for (int i = 0; i < Trips.Count; i++)
            {
                if (Trips[i].Total_weight >= Total_weight && Trips[i].Total_weight <= Max_weight)
                {
                    if ((Trips[i].Total_weight > Total_weight) || (Trips[i].Total_weight == Total_weight && Trips[i].Sites_count < Sites_count))
                    {
                        Trip_index = i;
                        Total_weight = Trips[i].Total_weight;
                        Sites_count = Trips[i].Sites_count;
                        
                    }
                    //if there is a trip with the same weight is saved as alternative
                    if (Trips[i].Total_weight == Total_weight)
                    {
                        Alt_trip_index = i;
                    }

                }
            }
            //the message is written depends on whether there is one or two better trips
            string message = "";
            if (Alt_trip_index == Trip_index)
                message = "The best trip for this drone is :\n" 
                        + Trips[Trip_index].Sites_name + "  \nwith " 
                        + Trips[Trip_index].Sites_count.ToString() 
                        + " stops \r\nand a total weight of " 
                        + Trips[Trip_index].Total_weight.ToString() + " Kg.";
            else
                message = "The best trips for this drone are :\n"
                        + Trips[Trip_index].Sites_name + "  \nwith "
                        + Trips[Trip_index].Sites_count.ToString()
                        + " stops \r\nand a total weight of "
                        + Trips[Trip_index].Total_weight.ToString() + " Kg.\nand\n"
                        + Trips[Alt_trip_index].Sites_name + "  \nwith "
                        + Trips[Alt_trip_index].Sites_count.ToString()
                        + " stops \nand a total weight of "
                        + Trips[Alt_trip_index].Total_weight.ToString() + " Kg.";

            MessageBox.Show(message, "Drone site planner", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
