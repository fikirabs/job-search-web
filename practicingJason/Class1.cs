using System;

public class Class1
{
	public Class1()
	{
        protected void CreateTable(object sender, EventArgs e)
    {
        string query = "IF OBJECT_ID('dbo.CustomersTest', 'U') IS NULL ";
        query += "BEGIN ";
        query += "CREATE TABLE [dbo].[CustomersTest](";
        query += "[CustomerId] INT IDENTITY(1,1) NOT NULL CONSTRAINT pkCustomerId PRIMARY KEY,";
        query += "[Name] VARCHAR(100) NOT NULL,";
        query += "[Country] VARCHAR(50) NOT NULL";
        query += ")";
        query += " END";
        string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand(query))
            {
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
    }
}

