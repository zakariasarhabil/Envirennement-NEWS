using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnvironnementNewsApi.Models
{
    public class JournalistViewModel
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Image { get; set; }
        public int NombrArticle { get; set; }
        public List<ArticleViewModel> articles
        {
            get; set;
        }
    }
}