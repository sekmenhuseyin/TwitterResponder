using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TwitterResponder.Models
{
    public class mdlSearch
    {
        [Display(Name = "Aranacak Bilgi")]
        public string searchText { get; set; }

        [Display(Name = "Başlangıç Tarihi")]
        public DateTime searchStartDate { get; set; }

        [Display(Name = "Bitiş Tarihi")]
        public DateTime searchEndDate { get; set; }

        [Display(Name = "Arama Limiti")]
        public int searchLimit { get; set; }

        [Display(Name = "Cevap")]
        public string searchAnswer { get; set; }
    }
}