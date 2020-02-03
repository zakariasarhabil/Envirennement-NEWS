using EnvironnementNewsApi.Data;
using EnvironnementNewsApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace EnvironnementNewsApi.Controllers
{
    public class ArticlesController : ApiController
    {
        public IHttpActionResult GetArticle()
        {
            var articles = new List<ViewArticleJournalistModel>();

          // ViewModelJournalist jr = new ViewModelJournalist();

            using (var context = new NEWSEntities())
            {
                //var article = context.Article.ToList();
                var status = "posted";
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
    





public IHttpActionResult GetArticle(int id)
{
    ViewArticleJournalistModel article;
    using (var context = new NEWSEntities())
    {
        var A = context.Article.Where(f => f.ID == id).FirstOrDefault();
        if (A == null)
        {
            return NotFound();
        }
        article = new ViewArticleJournalistModel();
        article.ID = id;
        article.Titre = A.Titre;
        article.Body = A.Body;
        article.Img = A.Img;
        article.Video = A.video;
        article.Date = A.Date;
        article.Journaliste = A.Journalistes.Nom;
    }
    return Ok(article);
}
[ResponseType(typeof(Commentaire))]
public IHttpActionResult PostCommentaire(Commentaire commentaire)
{
    if (!ModelState.IsValid)
    {
        return BadRequest(ModelState);
    }
    using (var context = new NEWSEntities())
    {
        context.Commentaire.Add(commentaire);
        context.SaveChanges();

    }



    return CreatedAtRoute("DefaultApi", new { id = commentaire.ID }, commentaire);
}
    }
}
