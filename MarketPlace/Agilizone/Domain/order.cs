﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Agilizone.Domain
{
    public class order
    {
        public order_address address { get; set; }
        public order_client client { get; set; }
        public string details { get; set; }
        public string number { get; set; }
        public string paymentType { get; set; }
        public decimal deliveryFee { get; set; }
        public decimal deliverymanFee { get; set; }
        public decimal amount { get; set; }
        public bool isPrepaid { get; set; }


        public string _id { get; set; }
        public string storeId { get; set; }
        public string status { get; set; }
        public string orderTiming { get; set; }
        public string orderType { get; set; }
        public string createdAt { get; set; }
    }

    public class order_address
    {
        public string city { get; set; }
        public string complement { get; set; }
        public order_address_coordinates coordinates { get; set; }
        public string country { get; set; }
        public string number { get; set; }
        public string state { get; set; }
        public string street { get; set; }
    }

    public class order_address_coordinates
    {
        public decimal latitude { get; set; }
        public decimal longitude { get; set; }
    }

    public class order_client
    {
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
    }

    //"history": [
    //        {
    //            "timestamp": "2024-04-21T00:00:26.974Z",
    //            "status": "PREPARING",
    //            "user": {
    //                "id": "ff11f50b-b6d1-4bd4-9075-07783dc09b50",
    //                "name": "integration-user"
    //            },
    //            "deliveryman": null,
    //            "description": null
    //        }
    //    ],

}
