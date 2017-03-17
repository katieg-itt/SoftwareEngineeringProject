using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;

namespace PoolSYS
{
    class Registration
    {
        int Registration_No, Member_Id, Activity_No;
        String Registration_Date;
        double Account;

         public int getRegistration_No()
        {
            return Registration_No;
        }

        public Double getAccount()
        {
            return Account;
        }

        public double getMember_Id()
        {
            return Member_Id;
        }

        public int getActivity_No()
        {
            return Activity_No;
        }

        public String getRegistration_Date()
        {
            return Registration_Date;
        }
        public void setRegistration_No(int Registration_No)
        {
            this.Registration_No = Registration_No;
        }

        public void setMember_Id(int Member_Id)
        {
            this.Member_Id = Member_Id;
        }

        public void setActivity_No(int Activity_No)
        {
            this.Activity_No = Activity_No;
        }
        public void setAccount(double Account){
            this.Account = Account;
        }
        public void setRegistration_Date(String Registration_Date)
        { 
            this.Registration_Date = Registration_Date;
        }
        public Registration(int Registration_No, int Member_Id, double Account, int Activity_No, String Registration_Date)
        {
            this.Registration_No = Registration_No;
            this.Member_Id = Member_Id;
            this.Account = Account;
            this.Activity_No = Activity_No;
            this.Registration_Date = Registration_Date;
        }

        public Registration()
        {
            Registration_No = 0;
            Member_Id = 0;
            Account = 0.0;
            Activity_No = 0;
            Registration_Date = "";
        }

        public int getNextRegistration_No()
        {
            int intNextRegistration_No;

            //Create database connection string

            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);


            //Define SQL query
            String strSQL = "SELECT MAX(Registration_No) FROM Registration";

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
                intNextRegistration_No = 1;
            else
                intNextRegistration_No = (dr.GetInt32(0)) + 1;

            myConn.Close();
            return intNextRegistration_No;
        }
        public void insRegistration()
        {
            //create database connection string
            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);

            //Define SQL Query
            String strSQL = "INSERT INTO Registration VALUES ('" + this.Registration_No + "', '"+ String.Format("{0:dd-MMM-yy}", this.Registration_Date) + "','" + this.Member_Id + "', '" + this.Activity_No + "')";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //open DB connection
            myConn.Open();

            //execute
            cmd.ExecuteNonQuery();

            //Close DB connection
            myConn.Close();
        }
        public void getRegistration(int Registration)
        {

            //Create database connection string
            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);

            //Define Sql Query
            String strSQL = "Select * From Registration Where Registration_No=" + Registration;

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB connection
            myConn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //instantiate object variables
            this.setRegistration_No(dr.GetInt32(0));
            this.setRegistration_Date(dr.GetString(1));
            this.setAccount(dr.GetInt32(2));
            this.setMember_Id(dr.GetInt32(3));
            this.setActivity_No(dr.GetInt32(4));

            //close DB Connection
            myConn.Close();

        }

        public bool isRegistered(int ActNo, int MemId)
        {
            bool answer;

            //Create database connection string
            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);

            //Define Sql Query
            String strSQL = "Select * From Registration Where Member_Id=" + MemId + " AND Activity_No = " + ActNo;

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB connection
            myConn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            int count = 0;

            while (dr.Read())
            {
                count++;
            }

            if (count > 0) {
                answer = true;
            } else {
                answer = false;
            }

            //close DB Connection
            myConn.Close();

            return answer;
            

        }


        
    }
}
