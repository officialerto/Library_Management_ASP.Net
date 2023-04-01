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
            [Required(ErrorMessage = "Please enter category")]
            public string catname { get; set; }

            [DisplayName("Status:")]
            [Required(ErrorMessage = "Please enter status")]
            public string status { get; set; }
        }

    }
}