﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;

namespace Models {
    public class BatchEditRepository {
        public static List<GridDataItem> GridData {
            get {
                var key = "34FAA431-CF79-4869-9488-93F6AAE81263";
                var Session = HttpContext.Current.Session;
                if(Session[key] == null)
                    Session[key] = Enumerable.Range(0, 100).Select(i => new GridDataItem {
                        ID = i,
                        C1 = i % 2,
                        C2 = i * 0.5 % 3,
                        C3 = "C3 " + i,
                        C4 = i % 2 == 0,
                        C5 = DateTime.Now.AddDays(i*3).AddMonths(i/5)
                    }).ToList();
                return (List<GridDataItem>)Session[key];
            }
        }
    }

    public class GridDataItem {
        public int ID { get; set; }
        public int C1 { get; set; }
        public double C2 { get; set; }
        public string C3 { get; set; }
        public bool C4 { get; set; }
        public DateTime C5 { get; set; }
    }
}