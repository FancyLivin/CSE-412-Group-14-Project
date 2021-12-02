using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Npgsql;
using System.Data;

namespace CSE412_Group_Project_WebApp
{
    public partial class RentableHouse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string maxPrice = Session["MaxPrice"].ToString();
            string minPrice = Session["MinPrice"].ToString();
            string bedPref = Session["BedPref"].ToString();
            string bathPref = Session["BathPref"].ToString();
            string locPref = Session["locPref"].ToString();
            string yrToRent = Session["yrToRent"].ToString();

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


            if (yrToRent == "" && bathPref == "" && locPref == "" && bedPref == "")
            {
                if (ranch != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "house.\"propID\"=rentable.\"propID\" AND " +
                         "\"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", ranch));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (mcmansion != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "house.\"propID\"=rentable.\"propID\" AND " +
                         "\"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", mcmansion));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (colonial != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "house.\"propID\"=rentable.\"propID\" AND " +
                         "\"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", colonial));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (craftsman != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "house.\"propID\"=rentable.\"propID\" AND " +
                         "\"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", craftsman));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (farmhouse != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "house.\"propID\"=rentable.\"propID\" AND " +
                         "\"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", farmhouse));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (contemporary != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "house.\"propID\"=rentable.\"propID\" AND " +
                         "\"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", contemporary));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (ranch != "" && contemporary != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "house.\"propID\"=rentable.\"propID\" AND " +
                         "\"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice";
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));

                }
            }

            else if (bathPref == "" && locPref == "" && bedPref == "")
            {
                if (ranch != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "house.\"propID\"=rentable.\"propID\" AND " +
                         "\"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS AND \"yrsToRent\"=@yrToRent";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", ranch));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (mcmansion != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "house.\"propID\"=rentable.\"propID\" AND " +
                         "\"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS AND \"yrsToRent\"=@yrToRent";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", mcmansion));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (colonial != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "house.\"propID\"=rentable.\"propID\" AND " +
                         "\"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS AND \"yrsToRent\"=@yrToRent";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", colonial));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (craftsman != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "house.\"propID\"=rentable.\"propID\" AND " +
                         "\"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS AND \"yrsToRent\"=@yrToRent";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", craftsman));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (farmhouse != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "house.\"propID\"=rentable.\"propID\" AND " +
                         "\"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS AND \"yrsToRent\"=@yrToRent";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", farmhouse));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (contemporary != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "house.\"propID\"=rentable.\"propID\" AND " +
                         "\"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS AND \"yrsToRent\"=@yrToRent";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", contemporary));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (ranch != "" && contemporary != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                         "house.\"propID\"=rentable.\"propID\" AND " +
                          "\"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                         "\"yrsToRent\"=@yrToRent";
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));

                }

            }

            else if (yrToRent == "" && locPref == "" && bedPref == "")
            {
                if (ranch != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "baths=@bathPref AND house.\"propID\"=rentable.\"propID\" AND " +
                         "\"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", ranch));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (mcmansion != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "baths=@bathPref AND house.\"propID\"=rentable.\"propID\" AND " +
                         "\"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", mcmansion));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (colonial != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "baths=@bathPref AND house.\"propID\"=rentable.\"propID\" AND " +
                         "\"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", colonial));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (craftsman != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "baths=@bathPref AND house.\"propID\"=rentable.\"propID\" AND " +
                         "\"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", craftsman));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (farmhouse != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                         "baths=@bathPref AND house.\"propID\"=rentable.\"propID\" AND " +
                          "\"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                         "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", farmhouse));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (contemporary != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "baths=@bathPref AND house.\"propID\"=rentable.\"propID\" AND " +
                         "\"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", contemporary));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (ranch != "" && contemporary != "")
                {

                    comm.CommandText = "select * from house,rentable where " +
                        "baths=@bathPref AND house.\"propID\"=rentable.\"propID\" AND " +
                         "\"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice";

                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));

                }
            }

            else if (yrToRent == "" && bathPref == "" && bedPref == "")
            {
                if (ranch != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "city=@locPref AND house.\"propID\"=rentable.\"propID\" AND " +
                         "\"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", ranch));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (mcmansion != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                       "city=@locPref AND house.\"propID\"=rentable.\"propID\" AND " +
                        "\"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                       "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", mcmansion));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (colonial != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "city=@locPref AND house.\"propID\"=rentable.\"propID\" AND " +
                         "\"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", colonial));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (craftsman != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                       "city=@locPref AND house.\"propID\"=rentable.\"propID\" AND " +
                        "\"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                       "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", craftsman));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (farmhouse != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                       "city=@locPref AND house.\"propID\"=rentable.\"propID\" AND " +
                        "\"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                       "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", farmhouse));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (contemporary != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                       "city=@locPref AND house.\"propID\"=rentable.\"propID\" AND " +
                        "\"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                       "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", contemporary));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (ranch != "" && contemporary != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                       "city=@locPref AND house.\"propID\"=rentable.\"propID\" AND " +
                        "\"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice";
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));

                }
            }

            else if (yrToRent == "" && bathPref == "" && locPref == "")
            {
                if (ranch != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                          "beds=@bedPref AND house.\"propID\"=rentable.\"propID\" AND " +
                           "\"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                          "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", ranch));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (mcmansion != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                          "beds=@bedPref AND house.\"propID\"=rentable.\"propID\" AND " +
                           "\"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                          "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", mcmansion));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (colonial != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                          "beds=@bedPref AND house.\"propID\"=rentable.\"propID\" AND " +
                           "\"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                          "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", colonial));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (craftsman != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                           "beds=@bedPref AND house.\"propID\"=rentable.\"propID\" AND " +
                            "\"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                           "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", craftsman));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (farmhouse != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                          "beds=@bedPref AND house.\"propID\"=rentable.\"propID\" AND " +
                           "\"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                          "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", farmhouse));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (contemporary != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                          "beds=@bedPref AND house.\"propID\"=rentable.\"propID\" AND " +
                           "\"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                          "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", contemporary));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (ranch != "" && contemporary != "")
                {
                    comm.CommandText = "select * from house,rentable " +
                     "WHERE beds=@bedPref AND house.\"propID\"=rentable.\"propID\"" +
                     " AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice";
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));

                }
            }

            else if (yrToRent == "" && bathPref == "")
            {
                if (ranch != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "beds=@bedPref AND house.\"propID\"=rentable.\"propID\" AND " +
                         "city=@locPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", ranch));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (mcmansion != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                       "beds=@bedPref AND house.\"propID\"=rentable.\"propID\" AND " +
                        "city=@locPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                       "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", mcmansion));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (colonial != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                       "beds=@bedPref AND house.\"propID\"=rentable.\"propID\" AND " +
                        "city=@locPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                       "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", colonial));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (craftsman != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "beds=@bedPref AND house.\"propID\"=rentable.\"propID\" AND " +
                         "city=@locPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", craftsman));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (farmhouse != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "beds=@bedPref AND house.\"propID\"=rentable.\"propID\" AND " +
                         "city=@locPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", farmhouse));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (contemporary != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "beds=@bedPref AND house.\"propID\"=rentable.\"propID\" AND " +
                         "city=@locPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", contemporary));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (ranch != "" && contemporary != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "beds=@bedPref AND house.\"propID\"=rentable.\"propID\" AND " +
                         "city=@locPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice";

                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));

                }
            }

            else if (yrToRent == "" && locPref == "") 
            {
                if (ranch != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "beds=@bedPref AND house.\"propID\"=rentable.\"propID\" AND " +
                         "baths=@bathPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", ranch));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (mcmansion != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "beds=@bedPref AND house.\"propID\"=rentable.\"propID\" AND " +
                         "baths=@bathPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", mcmansion));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (colonial != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                         "beds=@bedPref AND house.\"propID\"=rentable.\"propID\" AND " +
                          "baths=@bathPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                         "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", colonial));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (craftsman != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "beds=@bedPref AND house.\"propID\"=rentable.\"propID\" AND " +
                         "baths=@bathPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", craftsman));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (farmhouse != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "beds=@bedPref AND house.\"propID\"=rentable.\"propID\" AND " +
                         "baths=@bathPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", farmhouse));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (contemporary != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "beds=@bedPref AND house.\"propID\"=rentable.\"propID\" AND " +
                         "baths=@bathPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", contemporary));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (ranch != "" && contemporary != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "beds=@bedPref AND house.\"propID\"=rentable.\"propID\" AND " +
                         "baths=@bathPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice";

                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));

                }
            }

            else if (yrToRent == "" && bedPref == "") 
            {
                if (ranch != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "city=@locPref AND house.\"propID\"=rentable.\"propID\" AND " +
                         "baths=@bathPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", ranch));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (mcmansion != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                         "city=@locPref AND house.\"propID\"=rentable.\"propID\" AND " +
                          "baths=@bathPref AND price>@minPrice AND price<@maxPrice AND " +
                         "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", mcmansion));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (colonial != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                         "city=@locPref AND house.\"propID\"=rentable.\"propID\" AND " +
                          "baths=@bathPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                         "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", colonial));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (craftsman != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                          "city=@locPref AND house.\"propID\"=rentable.\"propID\" AND " +
                           "baths=@bathPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                          "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", craftsman));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (farmhouse != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                         "city=@locPref AND house.\"propID\"=rentable.\"propID\" AND " +
                          "baths=@bathPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                         "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", farmhouse));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (contemporary != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                          "city=@locPref AND house.\"propID\"=rentable.\"propID\" AND " +
                           "baths=@bathPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                          "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", contemporary));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (ranch != "" && contemporary != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                         "city=@locPref AND house.\"propID\"=rentable.\"propID\" AND " +
                          "baths=@bathPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice";

                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));

                }
            }

            else if (bathPref == "" && locPref == "")
            {

                if (ranch != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                         "beds=@bedPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", ranch));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (mcmansion != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                         "beds=@bedPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", mcmansion));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (colonial != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                         "beds=@bedPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", colonial));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (craftsman != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                         "beds=@bedPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", craftsman));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (farmhouse != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                         "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                          "beds=@bedPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                         "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", farmhouse));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (contemporary != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                         "beds=@bedPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", contemporary));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (ranch != "" && contemporary != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                         "beds=@bedPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice"; 
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));

                }
                
            }

            else if (bedPref == "" && bathPref == "")
            {

                if (ranch != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                         "city=@locPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", ranch));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (mcmansion != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                         "city=@locPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", mcmansion));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (colonial != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                         "city=@locPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", colonial));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (craftsman != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                         "city=@locPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", craftsman));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (farmhouse != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                         "city=@locPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", farmhouse));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (contemporary != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                         "city=@locPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", contemporary));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (ranch != "" && contemporary != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                         "city=@locPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND";

                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));

                }


            }

            else if (bedPref == "" && locPref == "")
            {

                if (ranch != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                         "baths=@bathPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", ranch));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (mcmansion != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                         "baths=@bathPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", mcmansion));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (colonial != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                         "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                          "baths=@bathPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                         "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", colonial));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (craftsman != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                         "baths=@bathPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", craftsman));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (farmhouse != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                         "baths=@bathPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", farmhouse));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (contemporary != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                         "baths=@bathPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", contemporary));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (ranch != "" && contemporary != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                         "baths=@bathPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice";

                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));

                }
            }

            else if (bedPref == "")
            {

                if (ranch != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                         "city=@locPref AND baths=@bathPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", ranch));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (mcmansion != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                       "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                        "city=@locPref AND baths=@bathPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                       "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", mcmansion));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (colonial != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                       "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                        "city=@locPref AND baths=@bathPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                       "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", colonial));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (craftsman != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                       "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                        "city=@locPref AND baths=@bathPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                       "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", craftsman));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (farmhouse != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                       "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                        "city=@locPref AND baths=@bathPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                       "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", farmhouse));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (contemporary != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                         "city=@locPref AND baths=@bathPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", contemporary));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (ranch != "" && contemporary != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                       "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                        "city=@locPref AND baths=@bathPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND";

                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));

                }


            }

            else if (bathPref == "")
            {
                if (ranch != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                         "city=@locPref AND beds=@bedPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", ranch));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (mcmansion != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                         "city=@locPref AND beds=@bedPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", mcmansion));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (colonial != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                         "city=@locPref AND beds=@bedPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", colonial));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (craftsman != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                         "city=@locPref AND beds=@bedPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", craftsman));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (farmhouse != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                         "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                          "city=@locPref AND beds=@bedPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                         "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", farmhouse));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (contemporary != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                         "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                          "city=@locPref AND beds=@bedPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                         "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", contemporary));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (ranch != "" && contemporary != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                         "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                          "city=@locPref AND beds=@bedPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND";

                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));

                }
            }

            else if (locPref == "")
            {
                if (ranch != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                         "baths=@bathPref AND beds=@bedPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", ranch));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (mcmansion != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                         "baths=@bathPref AND beds=@bedPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", mcmansion));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (colonial != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                         "baths=@bathPref AND beds=@bedPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", colonial));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (craftsman != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                         "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                          "baths=@bathPref AND beds=@bedPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                         "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", craftsman));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (farmhouse != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                         "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                          "baths=@bathPref AND beds=@bedPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                         "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", farmhouse));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (contemporary != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                         "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                          "baths=@bathPref AND beds=@bedPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                         "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", contemporary));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (ranch != "" && contemporary != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                         "\"yrsToRent\"=@yrToRent AND house.\"propID\"=rentable.\"propID\" AND " +
                          "baths=@bathPref AND beds=@bedPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice";
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }

            }

            else if (yrToRent == "") 
            {
                if (ranch != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "city=@locPref AND house.\"propID\"=rentable.\"propID\" AND " +
                         "baths=@bathPref AND beds=@bedPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", ranch));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (mcmansion != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                         "city=@locPref AND house.\"propID\"=rentable.\"propID\" AND " +
                          "baths=@bathPref AND beds=@bedPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                         "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", mcmansion));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (colonial != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                          "city=@locPref AND house.\"propID\"=rentable.\"propID\" AND " +
                           "baths=@bathPref AND beds=@bedPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                          "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", colonial));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (craftsman != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                          "city=@locPref AND house.\"propID\"=rentable.\"propID\" AND " +
                           "baths=@bathPref AND beds=@bedPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                          "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", craftsman));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (farmhouse != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                         "city=@locPref AND house.\"propID\"=rentable.\"propID\" AND " +
                          "baths=@bathPref AND beds=@bedPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                         "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", farmhouse));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (contemporary != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                         "city=@locPref AND house.\"propID\"=rentable.\"propID\" AND " +
                          "baths=@bathPref AND beds=@bedPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                         "\"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", contemporary));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (ranch != "" && contemporary != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                         "city=@locPref AND house.\"propID\"=rentable.\"propID\" AND " +
                          "baths=@bathPref AND beds=@bedPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice";
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
            }

            else
            {
                if (ranch != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "city=@locPref AND house.\"propID\"=rentable.\"propID\" AND " +
                         "baths=@bathPref AND beds=@bedPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"yrsToRent\"=@yrToRent AND \"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", ranch));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (mcmansion != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "city=@locPref AND house.\"propID\"=rentable.\"propID\" AND " +
                         "baths=@bathPref AND beds=@bedPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"yrsToRent\"=@yrToRent AND \"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", mcmansion));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (colonial != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "city=@locPref AND house.\"propID\"=rentable.\"propID\" AND " +
                         "baths=@bathPref AND beds=@bedPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"yrsToRent\"=@yrToRent AND \"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", colonial));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (craftsman != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "city=@locPref AND house.\"propID\"=rentable.\"propID\" AND " +
                         "baths=@bathPref AND beds=@bedPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"yrsToRent\"=@yrToRent AND \"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", craftsman));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (farmhouse != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                         "city=@locPref AND house.\"propID\"=rentable.\"propID\" AND " +
                          "baths=@bathPref AND beds=@bedPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                         "\"yrsToRent\"=@yrToRent AND \"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", farmhouse));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (contemporary != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "city=@locPref AND house.\"propID\"=rentable.\"propID\" AND " +
                         "baths=@bathPref AND beds=@bedPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice AND " +
                        "\"yrsToRent\"=@yrToRent AND \"houseStyle\"=@hS";
                    comm.Parameters.Add(new NpgsqlParameter("@hS", contemporary));
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }
                if (ranch != "" && contemporary != "")
                {
                    comm.CommandText = "select * from house,rentable where " +
                        "city=@locPref AND house.\"propID\"=rentable.\"propID\" AND " +
                         "baths=@bathPref AND beds=@bedPref AND \"priceMonth\">@minPrice AND \"priceMonth\"<@maxPrice";
                    comm.Parameters.Add(new NpgsqlParameter("@yrToRent", int.Parse(yrToRent)));
                    comm.Parameters.Add(new NpgsqlParameter("@bathPref", int.Parse(bathPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@locPref", locPref));
                    comm.Parameters.Add(new NpgsqlParameter("@bedPref", int.Parse(bedPref)));
                    comm.Parameters.Add(new NpgsqlParameter("@minPrice", int.Parse(minPrice)));
                    comm.Parameters.Add(new NpgsqlParameter("@maxPrice", int.Parse(maxPrice)));
                }

            }

            NpgsqlDataAdapter nda = new NpgsqlDataAdapter(comm);
            DataTable dt = new DataTable();
            nda.Fill(dt);

            comm.Dispose();
            conn.Close();

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=password;Database=TEAM14");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;

            comm.CommandText = "INSERT INTO renting VALUES(@pI, @cI, @rentTime)";
            comm.Parameters.Add(new NpgsqlParameter("@cI", int.Parse(Session["clientID"].ToString())));
            comm.Parameters.Add(new NpgsqlParameter("@pI", int.Parse(TextBox1.Text)));
            comm.Parameters.Add(new NpgsqlParameter("@rentTime", int.Parse(TextBox2.Text)));
            comm.ExecuteNonQuery();
            comm.Dispose();
            conn.Close();

            Label2.Text = "Your rental is successfully recorded.";
        }
    }
}