using EnvironnementNewsApi.Data;
using EnvironnementNewsApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EnvironnementNewsApi.Controllers
{
    public class ChefRedactionController : ApiController
    {
        //public IHttpActionResult GetArticles(string status = "")
        //{
        //    var articles = new List<ViewArticleJournalistModel>();

        //    //ViewModelJournalist jr = new ViewModelJournalist();

        //    using (var context = new NEWSEntities())
        //    {
        //        //var article = context.Article.ToList();

        //        var article = context.Article.Where(f => f.Status == status).ToList();
        //        if (article == null)
        //        {
        //            return NotFound();
        //        }

        //        foreach (var n in article)
        //        {
        //             ViewArticleJournalistModel vm = new  ViewArticleJournalistModel();
        //            vm.Img = n.Img;
        //            vm.Titre = n.Titre;
        //            vm.Body = n.Body;
        //            vm.Date = n.Date;
        //            vm.Journaliste = n.Journalistes.Nom;
        //            articles.Add(vm);
        //        }
        //    }
        //    return Ok(articles);
        //}
        [Authorize(Roles = "ChefRedaction")]

        public IHttpActionResult GetArticles(string status = "")
        {
            var articles = new List<ViewArticleJournalistModel>();

            //ViewModelJournalist jr = new ViewModelJournalist();

            using (var context = new NEWSEntities())
            {
                //var article = context.Article.ToList();

                var article = context.Article.Where(f => f.Status == status).ToList();
                if (article == null)
                {
                    return NotFound();
                }

                foreach (var n in article)
                {
                    ViewArticleJournalistModel vm = new ViewArticleJournalistModel();
                    vm.Img = n.Img;
                    vm.Titre = n.Titre;
                    vm.Body = n.Body;
                    vm.Date = n.Date;
                    vm.Journaliste = n.Journalistes.Nom;
                    articles.Add(vm);
                }
            }
            return Ok(articles);
        }

    }
}
