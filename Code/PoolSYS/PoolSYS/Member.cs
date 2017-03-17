using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;

namespace PoolSYS
{
    class Member
    {
        int memId, houseNo;
        String surname, forename, street, town, county,email, phone, status;

        public int getMemId (){
            return memId;
        }

        public String getPhone (){
            return phone;
        }

        public String getSurname()
        {
            return surname;
        }

        public String getForename()
        {
            return forename;
        }

        public int getHouseNo()
        {
            return houseNo;
        }

        public String getStreet()
        {
            return street;
        }

        public String getTown()
        {
            return town;
        }

        public String getCounty()
        {
            return county;
        }

        public String getEmail()
        {
            return email;
        }

        public String getStatus()
        {
            return status;
        }

        public void setMemId(int memId)
        {
            this.memId = memId;
        }

        public void setSurname(String surname)
        {
            this.surname = surname;
        }

        public void setForename(String forename)
        {
            this.forename = forename;
        }
        
        public void setHouseNo(int houseNo)
        {
            this.houseNo = houseNo;
        }

        public void setStreet(String street)
        {
            this.street = street;
        }

        public void setTown(String town)
        {
            this.town = town;
        }

        public void setCounty(String county)
        {
            this.county = county;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }

        public void setPhone(String phone)
        {
            this.phone = phone;
        }

        public void setStatus(String status)
        {
            this.status = status;
        }


        public Member(int memId, String surname, String forename, int houseNo, String street, String town, String county, String email, String phone, String status)
        {
            this.memId = memId;
            this.surname = surname;
            this.forename = forename;
            this.houseNo = houseNo;
            this.street = street;
            this.town = town;
            this.county = county;
            this.phone = phone;
            this.email = email;
            this.status = status;
        }

        public Member()
        {
            memId= 0;
            surname="";
            forename="";
            houseNo= 0;
            street="";
            town = "";
            county="";
            phone = "";
            email="";
            status = "";
        }

      public int getNextMemId()
       {
           int intNextMemId;

           //Create database connection string

           OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);
           //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);


           //Define SQL query
           String strSQL = "SELECT MAX(Member_Id) FROM Members";

           //Define Oracle command
           OracleCommand cmd = new OracleCommand(strSQL, myConn);

           //Open DB connection
           myConn.Open();

           //execute
           OracleDataReader dr = cmd.ExecuteReader();

           //Aggregate function will always return one record
           //If no MemberId exists, MAX value is NULL
           //If MemberId exists, value returned is an integer      

           //read the record in dr
           dr.Read();

           if (dr.IsDBNull(0))
               intNextMemId = 1;
           else
               intNextMemId = Convert.ToInt16(dr.GetValue(0)) + 1;

           myConn.Close();
           return intNextMemId;
       }



      public void insMember()
      {
          //create database connection string
          OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);

          //Define SQL Query
          String strSQL = "INSERT INTO Members VALUES (" + this.memId + ",'" + this.surname + "','" + this.forename + "','" + this.houseNo + "','" + this.street + "','" + this.town + "','" + this.county + "','" + this.phone + "','" + this.email + "','A')";

          //Define Oracle command
          OracleCommand cmd = new OracleCommand(strSQL, myConn);

          //open DB connection
          myConn.Open();

          //execute
          cmd.ExecuteNonQuery();

          //Close DB connection
          myConn.Close();
      }

      public void getMember(int mem)
      {

          //Create database connection string
          OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);

          //Define Sql Query
          String strSQL = "Select * From Members Where Member_Id=" + mem;

          //Define Oracle command
          OracleCommand cmd = new OracleCommand(strSQL, myConn);

          //Open DB connection
          myConn.Open();

          OracleDataReader dr = cmd.ExecuteReader();
          dr.Read();

          //instantiate object variables
          this.setMemId(dr.GetInt32(0));
          this.setSurname(dr.GetString(1));
          this.setForename(dr.GetString(2));
          this.setHouseNo(dr.GetInt32(3));
          this.setStreet(dr.GetString(4));
          this.setTown(dr.GetString(5));
          this.setCounty(dr.GetString(6));
          this.setPhone(dr.GetString(7));
          this.setEmail(dr.GetString(8));
          this.setStatus(dr.GetString(9));


          //close DB Connection
          myConn.Close();

      }

      public void updateMember()
      {
          //create database connection string
          OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);

          //Define SQL Query
          String strSQL = "UPDATE Members SET Surname = '" + this.surname + "', Forename = '" + this.forename + "', House_No = " + this.houseNo + ",Street = '" + this.street + "', Town = '" + this.town + "', County = '" + this.county + "', Phone = '" + this.phone + "', Email = '" + this.email + "', Status = 'A'  WHERE Member_Id = "+ this.getMemId();

          //Define Oracle command
          OracleCommand cmd = new OracleCommand(strSQL, myConn);

          //open DB connection
          myConn.Open();

          //execute
          cmd.ExecuteNonQuery();

          //Close DB connection
          myConn.Close();
      }

    public void blockMember()
      {
        OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);

        String strSQL = "UPDATE Members SET Surname = '" + this.surname + "', Forename = '" + this.forename + "', House_No = " + this.houseNo + ",Street = '" + this.street + "', Town = '" + this.town + "', County = '" + this.county + "', Phone = '" + this.phone + "', Email = '" + this.email + "', Status = 'B'  WHERE Member_Id = " + this.getMemId();

        OracleCommand cmd = new OracleCommand(strSQL, myConn);

        myConn.Open();

        cmd.ExecuteNonQuery();

        myConn.Close();
      }

    }
}
