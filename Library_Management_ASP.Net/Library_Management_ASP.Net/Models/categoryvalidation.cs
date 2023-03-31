using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Library_Management_ASP.Net.Models
{
    [MetadataType(typeof(categoryMetaData))]
    public partial class category
    {
        public class categoryMetaData
        {
            [DisplayName("Category:")]
            public string catname { get; set; }
            [DisplayName("Status:")]
            public string status { get; set; }
        }

    }
}