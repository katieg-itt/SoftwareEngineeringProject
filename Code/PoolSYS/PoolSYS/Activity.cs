using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;

namespace PoolSYS
{
    class Activity
    {
        int Activity_No, No_Of_Spaces, Availability, Duration;
        double Rate;
        String Activity_Name, Description, Start_Date;

        public int getActivity_No()
        {
            return Activity_No;
        }

        public int getDuration()
        {
            return Duration;
        }

        public double getRate()
        {
            return Rate;
        }

        public int getNo_Of_Spaces()
        {
            return No_Of_Spaces;
        }

        public int getAvailability()
        {
            return Availability;
        }

        public String getStart_Date()
        {
            return Start_Date;
        }

        public String getActivity_Name()
        {
            return Activity_Name;
        }

        public String getDescription()
        {
            return Description;
        }
     
        public void setActivity_No(int Activity_No)
        {
            this.Activity_No = Activity_No;
        }

        public void setDuration(int Duration)
        {
            this.Duration = Duration;
        }

        public void setRate(double Rate)
        {
            this.Rate = Rate;
        }

        public void setNo_Of_Spaces(int No_Of_Spaces)
        {
            this.No_Of_Spaces = No_Of_Spaces;
        }

        public void setAvailability(int Availability)
        {
            this.Availability = Availability;
        }

        public void setStart_Date(String Start_Date)
        {
            this.Start_Date = Start_Date;
        }

        public void setActivity_Name(String Activity_Name)
        {
            this.Activity_Name = Activity_Name;
        }

        public void setdescription(String Description)
        {
            this.Description = Description;
        }

        public Activity (int Activity_No, int Duration, double Rate, int No_Of_Spaces, int Availability, String Start_Date, String Activity_Name, String Description)
        {
            this.Activity_No = Activity_No;
            this.Duration = Duration;
            this.Rate = Rate;
            this.No_Of_Spaces = No_Of_Spaces;
            this.Availability = Availability;
            this.Start_Date = Start_Date;
            this.Activity_Name = Activity_Name;
            this.Description = Description;
        }

        public Activity()
        {
            Activity_No = 0;
            Duration = 0;
            Rate = 0.0;
            No_Of_Spaces = 0;
            Availability = 0;
            Start_Date = "";
            Activity_Name = "";
            Description = "";
        }

        public int getNextActivity_No()
        {
            int intNextActivity_No;

            //Create database connection string

            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);


            //Define SQL query
            String strSQL = "SELECT MAX(Activity_No) FROM Activities";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB connection
            myConn.Open();

            //execute
            OracleDataReader dr = cmd.ExecuteReader();

            //Aggregate function will always return one record
            //If no Activity No exists, MAX value is NULL
            //If Activity No exists, value returned is an integer      

            //read the record in dr
            dr.Read();

            if (dr.IsDBNull(0))
                intNextActivity_No = 1;
            else
                intNextActivity_No = (dr.GetInt32(0)) + 1;

            myConn.Close();
            return intNextActivity_No;
        }

        public void insActivity()
        {
            //create database connection string
            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);

            //Define SQL Query
            String strSQL = "INSERT INTO Activities VALUES (" + this.Activity_No + ",'" + this.Activity_Name + "', '" + this.Description + "','" + String.Format("{0:dd-MMM-yyyy}", this.Start_Date) + "'," +
                this.Duration + "," + this.Rate + "," + this.No_Of_Spaces + "," + this.Availability +  ")";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //open DB connection
            myConn.Open();

            //execute
            cmd.ExecuteNonQuery();

            //Close DB connection
            myConn.Close();
        }
        public void getActivity(int activity)
        {

            //Create database connection string
            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);

            //Define Sql Query
            String strSQL = "Select * From Activities Where Activity_No=" + activity;

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB connection
            myConn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //instantiate object variables
            this.setActivity_No(dr.GetInt32(0));
            this.setActivity_Name(dr.GetString(1));
            this.setdescription(dr.GetString(2));
            this.setDuration(dr.GetInt32(4));
            this.setStart_Date(dr.GetDateTime(3).ToString("dd-MMM-yy"));
            this.setRate(dr.GetInt32(5));
            this.setNo_Of_Spaces(dr.GetInt32(6));
            this.setAvailability(dr.GetInt32(7));
            //close DB Connection
            myConn.Close();

        }
        public void updateActivity()
        {
            //create database connection string
            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);

            //Define SQL Query
            String strSQL = "UPDATE Activities SET Activity_Name = '" + this.Activity_Name + "', Description = '" + this.Description + "', Start_Date = '" + this.Start_Date + "',Duration = '" + this.Duration + "', Rate = '" + this.Rate + "', No_Of_Spaces = '" + this.No_Of_Spaces + "' WHERE Activity_No = " + this.getActivity_No();

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //open DB connection
            myConn.Open();

            //execute
            cmd.ExecuteNonQuery();

            //Close DB connection
            myConn.Close();
        }

        public DataSet findActivities(String actName)
        {
            
            //Create database connection string
            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);

            //Define Sql Query
            String strSQL = "Select Activity_No, Activity_Name, Start_Date, Start_Date + (duration*7) AS END FROM Activities WHERE " +
                "Activity_Name LIKE '" + actName + "%' AND ((Start_Date >=  Start_Date) OR (Start_Date + (Duration*7) >= Start_Date)) ";
                            
                          
            //SELECT StartDate, StartDate + (duration*7) AS END
            //FROM Activities
            //WHERE StartDate >= Sysdate OR
            //startDate + (duration*7) >= sysdate

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB connection
            myConn.Open();

            //Create OracleDataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds, "Act");
         
            myConn.Close();

            return ds;
        }

        public void getAct(int activity)
        {

            //Create database connection string
            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);

            //Define Sql Query
            String strSQL = "Select * From Activities Where Activity_No=" + activity;

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB connection
            myConn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //instantiate object variables
            this.setActivity_No(dr.GetInt32(0));
            this.setActivity_Name(dr.GetString(1));
           
            this.setDuration(dr.GetInt32(4));
            
          
            this.setNo_Of_Spaces(dr.GetInt32(6));
            this.setAvailability(dr.GetInt32(7));
            //close DB Connection
            myConn.Close();

        }
        public void reducePlaces(int actNo)
        {

            //create database connection string
            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);

            //Define SQL Query
            String strSQL = "UPDATE Activities SET Availability = Availability - 1 WHERE Activity_No = " + actNo;

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //open DB connection
            myConn.Open();

            //execute
            cmd.ExecuteNonQuery();

            //Close DB connection
            myConn.Close();

        }

    }
}
