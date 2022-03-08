using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data.SqlClient;

namespace dsaproject
{
    class Worker
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=LAPTOP-T6CFC8HU\SQLEXPRESS01;Initial Catalog=SMHTravelData;User ID=admin;Password=admin;");
        public bool[] destinations;
        public bool meals, photos, souvenirs;
        public string fname, lname, phone, email, tour;
        public int tourists;
        public double distance, total;
        public double[,] adjmatrix = {
                { 0, 1, 5, 2, 18, 17.3, 20, 4, 13.3, 26.4, 10, 33.1, 13 },
                { 1, 0, 3, 5, 3, 5, 7, 2, 3, 4, 9, 6, 9 },
                { 5, 3, 0, 2, 2, 6, 3, 2, 5, 4, 3, 2, 1 },
                { 2, 5, 2, 0, 6, 6, 4.2, 1, 1, 1, 17, 1, 1 },
                { 18, 3, 2, 6, 0, 6, 6.9, 4, 5, 6, 7, 8, 9 },
                { 17.3, 5, 6, 6, 6, 0, 2, 4, 6, 8, 1, 3, 5 },
                { 20, 7, 3, 4.2, 6.9, 2, 0, 3, 2, 3, 3, 2, 2 },
                { 4, 2, 2, 1, 4, 4, 3, 0, 5, 6, 2.3, 7, 1.5 },
                { 13.3, 3, 5, 1, 5, 6, 2, 5, 0, 0.7, 5, 1.2, 3 },
                { 26.4, 4, 4, 1, 6, 8, 3, 6, 0.7, 0, 4, 3, 2 },
                { 10, 9, 3, 17, 7, 1, 3, 2.3, 5, 4, 0, 1, 2 },
                { 33.1, 6, 2, 1, 8, 3, 2, 7, 1.2, 3, 1, 0, 7 },
                {  13, 9, 1, 1, 9, 5, 2, 1.5, 3, 2, 2, 7, 0}};
        public Worker() { }
        public Worker(bool[] destinations, bool[] addons,string tourists, string fname, string lname, string phone, string email)
        {
            this.distance = 0;
            this.total = 0;
            this.fname = fname;
            this.lname = lname;
            this.phone = phone;
            this.email = email;
            this.destinations = destinations;
            if (addons[0] == true) meals = true;
            if (addons[1] == true) photos = true;
            if (addons[2] == true) souvenirs = true;
            tour = tourists;
            if (tourists.Equals("Individual(single person)", StringComparison.OrdinalIgnoreCase)) this.tourists = 1;
            if (tourists.Equals("Small Group(5-9 people)", StringComparison.OrdinalIgnoreCase)) this.tourists = 2;
            if (tourists.Equals("Large Group(15-20 people", StringComparison.OrdinalIgnoreCase)) this.tourists = 3;

        }
        public void delNode(int dest)
        {
            for (int i = 0; i < 12; i++)
            {
                adjmatrix[dest + 1, i] = 0;
                adjmatrix[i, dest + 1] = 0;
            }
        }
        public void setTotal(double t)
        {
            this.total = Math.Round(t, 2);
        }
        public double travellingSalesmanProblem()
        {
            int n = 13;
            // If the node is not selected by the user remove
            // from the adjacency matrix
            for (int i = 0; i < 12; i++)
                if (destinations[i] == false) delNode(i);
            // Boolean array to check if a node
            // has been visited or not
            bool[] v = new bool[n];
            // Mark 0th node as visited
            v[0] = true;
            double ans = double.MaxValue;
            // Find the minimum weight Hamiltonian Cycle
            ans = tspRecursion(adjmatrix, v, 0, n, 1, 0, ans);
            return ans + 5;
        }
        public double tspRecursion(double[,] graph, bool[] v, int currPos, int n, int count, double cost, double ans)
        {
            // If last node is reached and it has a link
            // to the starting node i.e the source then
            // keep the minimum value out of the total cost
            // of traversal and "ans"
            // Finally return to check for more possible values
            if (count == n && graph[currPos, 0] > 0)
            {
                ans = Math.Min(ans, cost + graph[currPos, 0]);
                return ans;
            }
            // BACKTRACKING STEP
            // Loop to traverse the adjacency list
            // of currPos node and increasing the count
            // by 1 and cost by graph[currPos,i] value
            for (int i = 0; i < n; i++)
            {
                if (v[i] == false && graph[currPos, i] > 0)
                {

                    // Mark as visited
                    v[i] = true;
                    ans = tspRecursion(graph, v, i, n, count++,
                        cost + graph[currPos, i], ans);

                    // Mark ith node as unvisited
                    v[i] = false;
                }
            }
            return ans;
        }
        public double grandTotal()
        {
            double gTotal = 0;
            if (meals == true) gTotal += 55;
            if (photos == true) gTotal += 20;
            if (souvenirs == true) gTotal += 70;
            double ans = (travellingSalesmanProblem() * 25.53);
            if (tourists == 1) gTotal += 50;
            if (tourists == 2) gTotal += 150;
            if (tourists == 3) gTotal += 200;
            
            double zero = 0;
            double inf = 1 / zero;
            double T = 0;
            if (ans != inf)
                T = Math.Round(gTotal + ans, 2);
            else
                T = gTotal + 485.94;
            
            setTotal(T);
            return total;
        }
        public bool getBool(int x)
        {
            if (x == 1) return true;
            return false;
        }
        public bool addSql(string fName, string lName, string phone, string email, bool[] destination, bool[] addons, string tourists, double total)
        {
            bool status = false;
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO TableRecords VALUES (@FirstName,@LastName,@Phone,@Email,@Khalifa,@Garden,@Frame,@Skydive,@Jbr,@Alarab,@Aquarium,@Legoland,@Aquaventure,@Coffee,@Bollywood,@Ski,@Meals,@Photos,@Souvenirs,@Tourists,@Total,@Status)", sqlCon); ;
                cmd.Parameters.AddWithValue("@FirstName", fName);
                cmd.Parameters.AddWithValue("@LastName", lName);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Khalifa", destination[0].ToString());
                cmd.Parameters.AddWithValue("@Garden", destination[1].ToString());
                cmd.Parameters.AddWithValue("@Frame", destination[2].ToString());
                cmd.Parameters.AddWithValue("@Skydive", destination[3].ToString());
                cmd.Parameters.AddWithValue("@Jbr", destination[4].ToString());
                cmd.Parameters.AddWithValue("@Alarab", destination[5].ToString());
                cmd.Parameters.AddWithValue("@Aquarium", destination[6].ToString());
                cmd.Parameters.AddWithValue("@Legoland", destination[7].ToString());
                cmd.Parameters.AddWithValue("@Aquaventure", destination[8].ToString());
                cmd.Parameters.AddWithValue("@Coffee", destination[9].ToString());
                cmd.Parameters.AddWithValue("@Bollywood", destination[10].ToString());
                cmd.Parameters.AddWithValue("@Ski", destination[11].ToString());
                cmd.Parameters.AddWithValue("@Meals", addons[0].ToString());
                cmd.Parameters.AddWithValue("@Photos", addons[1].ToString());
                cmd.Parameters.AddWithValue("@Souvenirs", addons[2].ToString());
                cmd.Parameters.AddWithValue("@Tourists", tourists);
                cmd.Parameters.AddWithValue("@Total", total.ToString());
                cmd.Parameters.AddWithValue("@Status", status.ToString());
                sqlCon.Open();
                int i = cmd.ExecuteNonQuery();
                sqlCon.Close();
                if (i < 0) return false;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool updateSql(int id, string fName, string lName, string phone, string email, bool[] destination, bool[] addons, string tourists, double total, bool status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE TableRecords SET FirstName = @a1,LastName = @a2,Phone = @a3,Email = @a4,Khalifa = @a5,Garden = @a6,Frame = @a7,Skydive = @a8,Jbr = @a9,Alarab = @a10,Aquarium = @a11,Legoland = @a12,Aquaventure = @a13,Coffee = @a14,Bollywood = @a15,Ski = @a16,Meals = @a17,Photos = @a18,Souvenirs = @a19,Tourists = @a20,Total = @a21,Status = @a22 WHERE ID=@a23", sqlCon);
                cmd.Parameters.AddWithValue("@a1", fName.ToLower());
                cmd.Parameters.AddWithValue("@a2", lName.ToLower());
                cmd.Parameters.AddWithValue("@a3", phone);
                cmd.Parameters.AddWithValue("@a4", email.ToLower());
                cmd.Parameters.AddWithValue("@a5", destination[0].ToString());
                cmd.Parameters.AddWithValue("@a6", destination[1].ToString());
                cmd.Parameters.AddWithValue("@a7", destination[2].ToString());
                cmd.Parameters.AddWithValue("@a8", destination[3].ToString());
                cmd.Parameters.AddWithValue("@a9", destination[4].ToString());
                cmd.Parameters.AddWithValue("@a10", destination[5].ToString());
                cmd.Parameters.AddWithValue("@a11", destination[6].ToString());
                cmd.Parameters.AddWithValue("@a12", destination[7].ToString());
                cmd.Parameters.AddWithValue("@a13", destination[8].ToString());
                cmd.Parameters.AddWithValue("@a14", destination[9].ToString());
                cmd.Parameters.AddWithValue("@a15", destination[10].ToString());
                cmd.Parameters.AddWithValue("@a16", destination[11].ToString());
                cmd.Parameters.AddWithValue("@a17", addons[0].ToString());
                cmd.Parameters.AddWithValue("@a18", addons[1].ToString());
                cmd.Parameters.AddWithValue("@a19", addons[2].ToString());
                cmd.Parameters.AddWithValue("@a20", tourists);
                cmd.Parameters.AddWithValue("@a21", total.ToString());
                cmd.Parameters.AddWithValue("@a22", status.ToString());
                cmd.Parameters.AddWithValue("@a23", id);
                sqlCon.Open();
                cmd.ExecuteNonQuery();
                sqlCon.Close();          
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool generateBill(double total)
        {
            #region bill_string
            string bill = "\n--------------------------------------------------------------------------------\n\n                              SMH Tour Agency                                   \n\n--------------------------------------------------------------------------------\n---phone: 03-8684296-----------------------------------email: smh@agency.com----\n--------------------------------------------------------------------------------\n\nName: "+fname+" " + lname +"\nPhone: "+phone+"\nEmail: "+email+"\n\n\t\tTourists                      "+tour+ "\n\t\tMeals                         " + meals+ "\n\t\tPhotos                        "+photos+ "\n\t\tSoveniers                     "+souvenirs+ "\n\t\tDestinations:                   \n\t\t\tBurj Khalifa          "+destinations[0]+ "\n\t\t\tMiracle Garden        " + destinations[1] + "\n\t\t\tThe Frame             " + destinations[2] + "\n\t\t\tSkyDive Dubai         " + destinations[3] + "\n\t\t\tJBR Beach             " + destinations[4] + "\n\t\t\tBurj Al Arab          " + destinations[5] + "\n\t\t\tDubai Aquarium        " + destinations[6] + "\n\t\t\tLegoLand              " + destinations[7] + "\n\t\t\tAquaventure           " + destinations[8] + "\n\t\t\tCoffee Museum         " + destinations[9] + "\n\t\t\tBollywood Park        " + destinations[10] + "\n\t\t\tSkiDubai              " + destinations[11] + "\n\n\n\t\tGrand Total + GST:            UAD " + total +"\n--------------------------------------------------------------------------------\n";
            #endregion
            try
            {
                string date = DateTime.Now.ToString("MMddyyyyHmm") + ".txt"; //to avoid getting files of the same name
                string filepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                StreamWriter writer = new StreamWriter(Path.Combine(filepath, date));
                writer.WriteLine(bill);
                writer.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
