﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library_Management_ASP.Net.Models
{
    [MetadataType(typeof(publisherMetaData))]

    public partial class publisher
    {
        public class publisherMetaData
        {
            [DisplayName("Name:")]
            [Required(ErrorMessage = "Please enter name")]
            public string name { get; set; }

            [DisplayName("Address:")]
            [Required(ErrorMessage = "Please enter address")]
            public string address { get; set; }

            [DisplayName("Phone:")]
            [Required(ErrorMessage = "Please enter phone")]
            [StringLength(11, ErrorMessage = "Phone cannot be longer than 11 characters.")]
            public string phone { get; set; }
        }

    }
}