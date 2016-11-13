﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EconomyResearcher.Data_Layer
{
    public class Dataset
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("dataset_code")]
        public string DatasetCode { get; set; }

        [JsonProperty("database_code")]
        public string DatabaseCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("refreshed_at")]
        public DateTime RefreshedAt { get; set; }

        [JsonProperty("newest_available_date")]
        public string NewestAvailableDate { get; set; }

        [JsonProperty("oldest_available_date")]
        public string OldestAvailableDate { get; set; }

        [JsonProperty("column_names")]
        public IList<string> ColumnNames { get; set; }

        [JsonProperty("frequency")]
        public string Frequency { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("premium")]
        public bool Premium { get; set; }

        [JsonProperty("limit")]
        public object Limit { get; set; }

        [JsonProperty("transform")]
        public object Transform { get; set; }

        [JsonProperty("column_index")]
        public object ColumnIndex { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("data")]
        public IList<IList<string>> Data { get; set; }

        [JsonProperty("collapse")]
        public object Collapse { get; set; }

        [JsonProperty("order")]
        public object Order { get; set; }

        [JsonProperty("database_id")]
        public int DatabaseId { get; set; }
    }

    public class RootObject_Quandl
    {
        [JsonProperty("dataset")]
        public Dataset Dataset { get; set; }
    }
}
