using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using Npgsql;
using System.Globalization;

namespace project
{
    public partial class BuyableHouse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                 string maxPrice = Session["MaxPrice"].ToString();
                 string minPrice = Session["MinPrice"].ToString();
                 string bedPref = Session["BedPref"].ToString();
                 string bathPref = Session["BathPref"].ToString();
                 string locPref = Session["locPref"].ToString();

            string ranch = Session["ranch"].ToString();
            string contemporary = Session["contemporary"].ToString();
            string mcmansion = Session["mcmansion"].ToString();
            string craftsman = Session["craftsman"].ToString();
            string colonial = Session["colonial"].ToString();
            string farmhouse = Session["farmhouse"].ToString();

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=TEAM14;User Id=postgres;Password=password");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;


            if (bathPref == "" && locPref == "" && bedPref == "")
            {
                if (ranch != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                        "house.\"propID\"=buyable.\"propID\" AND " +
                         "price>@minPrice AND price<@maxPrice AND "+
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", ranch));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (mcmansion != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                        "house.\"propID\"=buyable.\"propID\" AND " +
                         "price>@minPrice AND price<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", mcmansion));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (colonial != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                        "house.\"propID\"=buyable.\"propID\" AND " +
                         "price>@minPrice AND price<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", colonial));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (craftsman != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                        "house.\"propID\"=buyable.\"propID\" AND " +
                         "price>@minPrice AND price<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", craftsman));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (farmhouse != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                        "house.\"propID\"=buyable.\"propID\" AND " +
                         "price>@minPrice AND price<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", farmhouse));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (contemporary != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                        "house.\"propID\"=buyable.\"propID\" AND " +
                         "price>@minPrice AND price<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", contemporary));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (ranch != "" && contemporary != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                        "house.\"propID\"=buyable.\"propID\" AND " +
                         "price>@minPrice AND price<@maxPrice";
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));

                }
              
            }

            else if (bathPref == "" && locPref == "")
            {

                if (ranch != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                        "beds=@bedPref AND house.\"propID\"=buyable.\"propID\" AND " +
                         "price>@minPrice AND price<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", ranch));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (mcmansion != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                        "beds=@bedPref AND house.\"propID\"=buyable.\"propID\" AND " +
                         "price>@minPrice AND price<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", mcmansion));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (colonial != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                        "beds=@bedPref AND house.\"propID\"=buyable.\"propID\" AND " +
                         "price>@minPrice AND price<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", colonial));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (craftsman != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                        "beds=@bedPref AND house.\"propID\"=buyable.\"propID\" AND " +
                         "price>@minPrice AND price<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", craftsman));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (farmhouse != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                        "beds=@bedPref AND house.\"propID\"=buyable.\"propID\" AND " +
                         "price>@minPrice AND price<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", farmhouse));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (contemporary != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                          "beds=@bedPref AND house.\"propID\"=buyable.\"propID\" AND " +
                           "price>@minPrice AND price<@maxPrice AND " +
                          "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", contemporary));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (ranch != "" && contemporary != "")
                {
                    comm.CommandText = "select * from house,buyable " +
                     "WHERE beds=@bedPref AND house.\"propID\"=buyable.\"propID\"" +
                     " AND price>@minPrice AND price<@maxPrice";
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));

                }


       
            }

            else if (bedPref == "" && bathPref == "")
            {

                if (ranch != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                        "city=@locPref AND house.\"propID\"=buyable.\"propID\" AND " +
                         "price>@minPrice AND price<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", ranch));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (mcmansion != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                        "city=@locPref AND house.\"propID\"=buyable.\"propID\" AND " +
                         "price>@minPrice AND price<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", mcmansion));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (colonial != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                        "city=@locPref AND house.\"propID\"=buyable.\"propID\" AND " +
                         "price>@minPrice AND price<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", colonial));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (craftsman != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                        "city=@locPref AND house.\"propID\"=buyable.\"propID\" AND " +
                         "price>@minPrice AND price<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", craftsman));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (farmhouse != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                        "city=@locPref AND house.\"propID\"=buyable.\"propID\" AND " +
                         "price>@minPrice AND price<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", farmhouse));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (contemporary != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                          "city=@locPref AND house.\"propID\"=buyable.\"propID\" AND " +
                           "price>@minPrice AND price<@maxPrice AND " +
                          "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", contemporary));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (ranch != "" && contemporary != "")
                {
                    comm.CommandText = "select * from house,buyable " +
                     "WHERE city=@locPref AND house.\"propID\"=buyable.\"propID\"" +
                     " AND price>@minPrice AND price<@maxPrice";
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));

                }

            
            }

            else if (bedPref == "" && locPref == "")
            {

                if (ranch != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                        "baths=@bathPref AND house.\"propID\"=buyable.\"propID\" AND " +
                         "price>@minPrice AND price<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", ranch));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (mcmansion != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                        "baths=@bathPref AND house.\"propID\"=buyable.\"propID\" AND " +
                         "price>@minPrice AND price<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", mcmansion));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (colonial != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                        "baths=@bathPref AND house.\"propID\"=buyable.\"propID\" AND " +
                         "price>@minPrice AND price<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", colonial));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (craftsman != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                        "baths=@bathPref AND house.\"propID\"=buyable.\"propID\" AND " +
                         "price>@minPrice AND price<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", craftsman));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (farmhouse != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                        "baths=@bathPref AND house.\"propID\"=buyable.\"propID\" AND " +
                         "price>@minPrice AND price<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", farmhouse));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (contemporary != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                          "baths=@bathPref AND house.\"propID\"=buyable.\"propID\" AND " +
                           "price>@minPrice AND price<@maxPrice AND " +
                          "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", contemporary));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (ranch != "" && contemporary != "")
                {
                    comm.CommandText = "select * from house,buyable " +
                     "WHERE baths=@bathPref AND house.\"propID\"=buyable.\"propID\"" +
                     " AND price>@minPrice AND price<@maxPrice";
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));

                }
            }

            else if (bedPref == "")
            {


                if (ranch != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                        "baths=@bathPref AND city=@locPref AND house.\"propID\"=buyable.\"propID\" AND " +
                         "price>@minPrice AND price<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", ranch));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (mcmansion != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                        "baths=@bathPref AND city=@locPref AND house.\"propID\"=buyable.\"propID\" AND " +
                         "price>@minPrice AND price<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", mcmansion));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (colonial != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                        "baths=@bathPref AND city=@locPref AND house.\"propID\"=buyable.\"propID\" AND " +
                         "price>@minPrice AND price<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", colonial));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (craftsman != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                        "baths=@bathPref AND city=@locPref AND house.\"propID\"=buyable.\"propID\" AND " +
                         "price>@minPrice AND price<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", craftsman));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (farmhouse != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                        "baths=@bathPref AND city=@locPref AND house.\"propID\"=buyable.\"propID\" AND " +
                         "price>@minPrice AND price<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", farmhouse));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (contemporary != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                          "baths=@bathPref AND city=@locPref AND house.\"propID\"=buyable.\"propID\" AND " +
                           "price>@minPrice AND price<@maxPrice AND " +
                          "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", contemporary));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (ranch != "" && contemporary != "")
                {
                    comm.CommandText = "select * from house,buyable " +
                     "WHERE baths=@bathPref AND city=@locPref AND house.\"propID\"=buyable.\"propID\"" +
                     " AND price>@minPrice AND price<@maxPrice";
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));

                }

           
            }

            else if(bathPref == "")
            {

                if (ranch != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                          "beds=@bedPref AND city=@locPref AND house.\"propID\"=buyable.\"propID\" AND " +
                           "price>@minPrice AND price<@maxPrice AND " +
                          "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", ranch));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (mcmansion != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                          "beds=@bedPref AND city=@locPref AND house.\"propID\"=buyable.\"propID\" AND " +
                           "price>@minPrice AND price<@maxPrice AND " +
                          "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", mcmansion));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (colonial != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                           "beds=@bedPref AND city=@locPref AND house.\"propID\"=buyable.\"propID\" AND " +
                            "price>@minPrice AND price<@maxPrice AND " +
                           "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", colonial));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (craftsman != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                          "beds=@bedPref AND city=@locPref AND house.\"propID\"=buyable.\"propID\" AND " +
                           "price>@minPrice AND price<@maxPrice AND " +
                          "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", craftsman));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (farmhouse != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                          "beds=@bedPref AND city=@locPref AND house.\"propID\"=buyable.\"propID\" AND " +
                           "price>@minPrice AND price<@maxPrice AND " +
                          "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", farmhouse));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (contemporary != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                          "beds=@bedPref AND city=@locPref AND house.\"propID\"=buyable.\"propID\" AND " +
                           "price>@minPrice AND price<@maxPrice AND " +
                          "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", contemporary));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (ranch != "" && contemporary != "")
                {
                    comm.CommandText = "select * from house,buyable " +
                     "WHERE beds=@bedPref AND city=@locPref AND house.\"propID\"=buyable.\"propID\"" +
                     " AND price>@minPrice AND price<@maxPrice";
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));

                }
            }

            else if(locPref == "")
            {
                if (ranch != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                          "beds=@bedPref AND baths=@bathPref AND house.\"propID\"=buyable.\"propID\" AND " +
                           "price>@minPrice AND price<@maxPrice AND " +
                          "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", ranch));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (mcmansion != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                           "beds=@bedPref AND baths=@bathPref AND house.\"propID\"=buyable.\"propID\" AND " +
                            "price>@minPrice AND price<@maxPrice AND " +
                           "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", mcmansion));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (colonial != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                          "beds=@bedPref AND baths=@bathPref AND house.\"propID\"=buyable.\"propID\" AND " +
                           "price>@minPrice AND price<@maxPrice AND " +
                          "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", colonial));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (craftsman != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                          "beds=@bedPref AND baths=@bathPref AND house.\"propID\"=buyable.\"propID\" AND " +
                           "price>@minPrice AND price<@maxPrice AND " +
                          "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", craftsman));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (farmhouse != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                          "beds=@bedPref AND baths=@bathPref AND house.\"propID\"=buyable.\"propID\" AND " +
                           "price>@minPrice AND price<@maxPrice AND " +
                          "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", farmhouse));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (contemporary != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                          "beds=@bedPref AND baths=@bathPref AND house.\"propID\"=buyable.\"propID\" AND " +
                           "price>@minPrice AND price<@maxPrice AND " +
                          "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", contemporary));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (ranch != "" && contemporary != "")
                {
                    comm.CommandText = "select * from house,buyable " +
                     "WHERE beds=@bedPref AND baths=@bathPref AND house.\"propID\"=buyable.\"propID\"" +
                     " AND price>@minPrice AND price<@maxPrice";
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));

                }

            }

            else
            {
                if (ranch != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                          "beds=@bedPref AND baths=@bathPref AND house.\"propID\"=buyable.\"propID\" AND " +
                           "price>@minPrice AND price<@maxPrice AND " +
                          "city=@locPref AND \"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", ranch));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (mcmansion != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                           "beds=@bedPref AND baths=@bathPref AND house.\"propID\"=buyable.\"propID\" AND " +
                            "price>@minPrice AND price<@maxPrice AND " +
                           "city=@locPref AND \"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", mcmansion));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (colonial != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                          "beds=@bedPref AND baths=@bathPref AND house.\"propID\"=buyable.\"propID\" AND " +
                           "price>@minPrice AND price<@maxPrice AND " +
                          "city=@locPref AND \"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", colonial));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (craftsman != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                          "beds=@bedPref AND baths=@bathPref AND house.\"propID\"=buyable.\"propID\" AND " +
                           "city=@locPref AND price>@minPrice AND price<@maxPrice AND " +
                          "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", craftsman));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (farmhouse != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                          "beds=@bedPref AND baths=@bathPref AND house.\"propID\"=buyable.\"propID\" AND " +
                           "price>@minPrice AND price<@maxPrice AND " +
                          "city=@locPref AND \"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", farmhouse));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (contemporary != "")
                {
                    comm.CommandText = "select * from house,buyable where " +
                          "beds=@bedPref AND baths=@bathPref AND house.\"propID\"=buyable.\"propID\" AND " +
                           "price>@minPrice AND price<@maxPrice AND " +
                          "city=@locPref AND \"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", contemporary));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (ranch != "" && contemporary != "")
                {
                    comm.CommandText = "select * from house,buyable " +
                     "WHERE beds=@bedPref AND baths=@bathPref AND house.\"propID\"=buyable.\"propID\"" +
                     " AND city=@locPref AND price>@minPrice AND price<@maxPrice";
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));

                }
                
            }
            //  comm.CommandText = "select * from buyable";
            
            //   comm.Parameters.Add(new NpgsqlParameter("@fn", "Lingge"));
            //    NpgsqlDataReader dr = comm.ExecuteReader();

            NpgsqlDataAdapter nda = new NpgsqlDataAdapter(comm);
            DataTable dt = new DataTable();
            nda.Fill(dt);

            comm.Dispose();
            conn.Close();

            GridView1.DataSource = dt;
            GridView1.DataBind();

        }

    }
}