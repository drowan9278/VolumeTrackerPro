﻿using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.IdentityModel.Protocols;

namespace VolumeTrackerPro.Helpers
{
    public class Helpers
    {
        public static string GetRDSConnectionString()
        {
            return null;
            //var appConfig = ConfigurationManager.AppSettings;

            //string dbname = appConfig["RDS_DB_NAME"];

            //if (string.IsNullOrEmpty(dbname)) return null;

            //string username = appConfig["RDS_USERNAME"];
            //string password = appConfig["RDS_PASSWORD"];
            //string hostname = appConfig["RDS_HOSTNAME"];
            //string port = appConfig["RDS_PORT"];

            //return "Data Source=" + hostname + ";Initial Catalog=" + dbname + ";User ID=" + username + ";Password=" + password + ";";
        }

    }
}
