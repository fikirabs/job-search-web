using System;
using System.Data.SqlClient;

namespace practicingJason
{
    class program
    {
        public static void Create(string TName, string ConString)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("CREATE TABLE [dbo].['" + TName + "']("
                                + "[ID] [int] IDENTITY(1,1) NOT NULL,"
                                + "[DateTime] [date] NOT NULL,"
                                + "[BarCode] [nvarchar](max) NOT NULL,"
                                + "[ArtNumber] [nvarchar](max) NOT NULL,"
                                + "[ProductName] [nvarchar](50) NOT NULL,"
                                + "[Quantity] [int] NOT NULL,"
                                + "[SelfPrice] [decimal](18, 2) NOT NULL,"
                                + "[Price] [decimal](18, 2) NOT NULL,"
                                + "[Disccount] [int] NULL,"
                                + "[Comment] [nvarchar](max) NULL,"
                                + "CONSTRAINT ['" + TName + "'] PRIMARY KEY CLUSTERED "
                                + "("
                                + "[ID] ASC"
                                + ")WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]"
                                + ") ON [PRIMARY]", new SqlConnection(ConString)))
                {
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}