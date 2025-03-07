using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;
using Microsoft.SqlServer.Server;
using SQL_Wimmer;

public partial class StoredProcedures
{
    [Microsoft.SqlServer.Server.SqlProcedure]
    public static void StoredProcedure_WaWi()
    {
        // Fügen Sie hier Ihren Code ein.
    }
    [Microsoft.SqlServer.Server.SqlProcedure]
    public static void SQLTestConnect(ref string err)
    {
        try
        {
            string connectionString = @"Data Source=LAPTOPPAUL\SQLEXPRESS; Initial Catalog=WAWI_BASIS; User Id=sa; Password=oppeneiger";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            con.Close();
        }
        catch (Exception ex)
        {
            err = ex.Message;
        }
    }
    [Microsoft.SqlServer.Server.SqlProcedure]
    public static void SqlStoredProcedure(ref string info, string path)
    {
        string connectionString = @"Data Source=LAPTOPPAUL\SQLEXPRESS; Initial Catalog=WAWI_BASIS; User Id=sa; Password=oppeneiger";
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            try
            {
                info = "Export abgeschlossen in " + path;
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string queryString = "Select PersNr, PersNachname, PersVorname, PersGeschlecht from tblPersonen";
                    using (SqlCommand command = new SqlCommand(queryString, con))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                List<Person> p = new List<Person>();
                                while (reader.Read())
                                {
                                    try
                                    {
                                        Person pers = new Person();
                                        pers.PersNr = (int)reader[0];
                                    }
                                    catch
                                    {

                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}