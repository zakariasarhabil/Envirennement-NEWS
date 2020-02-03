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
    public class JournalistController : ApiController
    {
        public IHttpActionResult GetJournalist(int id = 0)
        {

            JournalistViewModel vm;
            using (var context = new NEWSEntities())
            {
                var j = context.Journalistes.Where(jl => jl.ID == id).FirstOrDefault();
                if (j == null)
                {
                    return NotFound();
                }
                vm = new JournalistViewModel();
                vm.ID = id;
                vm.Nom = j.Nom;
                vm.Prenom = j.Prenom;
                vm.Image = j.Image;
                vm.NombrArticle = j.Article.Count();
                var al = new List<ArticleViewModel>();
                foreach (var a in j.Article)
                {
                    ArticleViewModel am = new ArticleViewModel();
                    am.ID = a.ID;
                    am.Titre = a.Titre;
                    am.Body = a.Body;
                    am.Img = a.Img;
                    am.Date = a.Date.ToString();
                    am.Video = a.video;

                    al.Add(am);
                }
                vm.articles = al;

            }
            return Ok(vm);
        }


        [ResponseType(typeof(Article))]
        public IHttpActionResult PostArticle(Article article)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            using (var context = new NEWSEntities())
            {
                context.Article.Add(article);
                context.SaveChanges();

            }



            return CreatedAtRoute("DefaultApi", new { id = article.ID }, article);
        }
    }
}
