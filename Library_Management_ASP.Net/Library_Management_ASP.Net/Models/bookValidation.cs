using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library_Management_ASP.Net.Models
{
    [MetadataType(typeof(bookMetaData))]

    public partial class book
    {
        public class bookMetaData
        {
            [DisplayName("Book Name:")]
            public string bname { get; set; }

            [DisplayName("Category ID:")]
            public int cat_id { get; set; }

            [DisplayName("Author ID:")]
            public int a_id { get; set; }

            [DisplayName("Publisher ID:")]
            public int p_id { get; set; }

            [DisplayName("Contents:")]
            public string contents { get; set; }

            [DisplayName("Pages:")]
            public int pages { get; set; }

            [DisplayName("Edition:")]
            public string edition { get; set; }

        }
    }
}