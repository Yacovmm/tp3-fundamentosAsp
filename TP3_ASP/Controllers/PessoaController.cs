using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP3_ASP.Models;

namespace TP3_ASP.Controllers
{
    public class PessoaController : Controller
    {
        static List<PessoaModel> lst_pessoa;
        static int id = 0;
        // GET: Pessoa
        public ActionResult Index()
        {
            if (lst_pessoa == null)
            {
                lst_pessoa = new List<PessoaModel>();
            }
            return View(lst_pessoa);
        }

        // GET: Pessoa/Details/5
        public ActionResult Details(int id)
        {
            PessoaModel aux = null;
            for (int i = 0; i < lst_pessoa.Count; i++)
            {
                if (lst_pessoa[i].id == id)
                {
                    aux = lst_pessoa[i];
                }

            }

            if(aux == null)
            {
                return RedirectToAction("Index");
            }

            return View(aux);
        }

        // GET: Pessoa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pessoa/Create
        [HttpPost]
        public ActionResult Create(PessoaModel _pessoa)
        {
            try
            {
                _pessoa.id = id;
                lst_pessoa.Add(_pessoa);
                id++;

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pessoa/Edit/5
        public ActionResult Edit(int id)
        {
            PessoaModel aux = null;
            for (int i = 0; i < lst_pessoa.Count; i++)
            {
                if (lst_pessoa[i].id == id)
                {
                    aux = lst_pessoa[i];
                }

            }

            if (aux == null)
            {
                return RedirectToAction("Index");
            }

            return View(aux);
        }

        // POST: Pessoa/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, PessoaModel _pessoa)
        {
            try
            {
                PessoaModel aux = null;
                for (int i = 0; i < lst_pessoa.Count; i++)
                {
                    if (lst_pessoa[i].id == id)
                    {
                        aux = lst_pessoa[i];
                    }

                }

                UpdateModel(aux);
               
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pessoa/Delete/5
        public ActionResult Delete(int id)
        {
            PessoaModel aux = null;
            for (int i = 0; i < lst_pessoa.Count; i++)
            {
                if (lst_pessoa[i].id == id)
                {
                    aux = lst_pessoa[i];
                }

            }

            if (aux == null)
            {
                return RedirectToAction("Index");
            }

            return View(aux);
        }
    

        // POST: Pessoa/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, PessoaModel _pessoa)
        {
            try
            {
                PessoaModel aux = null;
                for (int i = 0; i < lst_pessoa.Count; i++)
                {
                    if (lst_pessoa[i].id == id)
                    {
                        aux = lst_pessoa[i];
                    }

                }

             
                lst_pessoa.Remove(aux);
       
            
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
    }
}
