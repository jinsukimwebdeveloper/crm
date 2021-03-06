﻿using crm.DAL.DTO;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace crm.DAL
{
    public class WebService
    {
        public List<LoginHistoryModel> GetLoginHistory(int? userID)
        {
            List<LoginHistoryModel> data;

            using (StreamReader jsonReader = new StreamReader(System.Web.HttpContext.Current.Server.MapPath(@"~/App_Data/LoginHistoryData.json")))
            {
                string json = jsonReader.ReadToEnd();
                data = JsonConvert.DeserializeObject<List<LoginHistoryModel>>(json);
            }

            return data;
        }
    }
}