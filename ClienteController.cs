using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto.Entities;
using Projeto.DAL.Persistence;
using Projeto.Web.Models;

namespace Projeto.Web.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastro(ClienteViewModelCadastro model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Cliente c = new Cliente();
                    c.Nome = model.Nome;
                    c.Email = model.Email;
                    c.DataCadastro = DateTime.Now;

                    ClienteDal d = new ClienteDal();
                    d.Insert(c);

                    ViewBag.Mensagem = "Cliente " + c.Nome + " cadastrado com sucesso!";
                    ModelState.Clear();
                }
                catch(Exception e)
                {
                    ViewBag.Mensagem = e.Message;
                }
            }

            return View();
        }


        public ActionResult Consulta()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Consulta(ClienteViewModelConsulta model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    ClienteDal d = new ClienteDal();
                    ViewBag.Dados = d.FindAllByNome(model.Nome);
                }
                catch(Exception e)
                {
                    ViewBag.Mensagem = e.Message;
                }
            }

            return View();
        }

        public ActionResult Exclusao(int id)
        {
            try
            {
                ClienteDal d = new ClienteDal();
                Cliente c = d.FindById(id);

                if(c != null){
                    d.Delete(id);
                    ViewBag.Mensagem = "Cliente " + c.Nome + " excluído com sucesso!";
                }
                else
                {
                    throw new Exception("Cliente não encontrado.");
                }

            }
            catch(Exception e)
            {
                ViewBag.Mensagem = e.Message;
            }

            return View();
        }

        public ActionResult Visualizacao(int id)
        {
            try
            {
                ClienteDal d = new ClienteDal();
                Cliente c = d.FindById(id);

                if (c != null)
                {
                    ViewBag.Cliente = c;
                }
                else
                {
                    throw new Exception("Erro. cliente não encontrado.");
                }
            }
            catch (Exception e)
            {
                ViewBag.Mensagem = e.Message;
            }

            return View();
        }



        public ActionResult Edicao(int id)
        {
            ClienteViewModelEdicao model = new ClienteViewModelEdicao();

            try
            {                
                ClienteDal d = new ClienteDal();
                Cliente c = d.FindById(id); 

                model.IdCliente = c.IdCliente;
                model.Nome = c.Nome;
                model.Email = c.Email;
            }
            catch (Exception e)
            {
                ViewBag.Mensagem = e.Message;
            }


            return View();
        }



    }
}