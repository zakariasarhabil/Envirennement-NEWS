﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnvironnementNewsApi.Models
{
    public class ViewArticleJournalistModel
    {
        public int ID { get; set; }
        public DateTime? Date { get; set; }
        public string Titre { get; set; }
        public string Body { get; set; }
        public string Img { get; set; }
        public string Video { get; set; }
        public string Journaliste { get; set; }
        public int Categorie { get; set; }

    }
}