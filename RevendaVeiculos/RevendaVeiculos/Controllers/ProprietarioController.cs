using Microsoft.AspNetCore.Mvc;
using RevendaVeiculos.Dominio.Contratos;
using RevendaVeiculos.Dominio.Entidades;
using RevendaVeiculos.Services;
using RevendaVeiculos.Services.APIExterna;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace RevendaVeiculos.Controllers
{
    public class ProprietarioController : Controller
    {
        private readonly IProprietarioRepositorio _proprietarioRepositorio;
        public ProprietarioController(IProprietarioRepositorio proprietarioRepositorio)
        {
            _proprietarioRepositorio = proprietarioRepositorio;
        }

        public IActionResult Index()
        {
            var p = _proprietarioRepositorio.ObterTodos();
            return View(p);
        }

        public IActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Novo(Proprietario proprietario)
        {
            proprietario.Validate();
            if (proprietario.EhValido && _proprietarioRepositorio.ValidaDuplicacao(proprietario))
            {
                _proprietarioRepositorio.Adicionar(proprietario);
                ViewBag.Confirma = "Salvo com sucesso!";
                return RedirectToAction("Index");
            }
            ViewBag.Mensagem = proprietario.ObterMensagensValidacao();
            return View();
        }

        public IActionResult Editar(int id)
        {
            Proprietario proprietario = _proprietarioRepositorio.ObterPorId(id);
            if (proprietario == null)
            {
                return RedirectToAction("Index");
            }
            return View(proprietario);
        }

        [HttpPost]
        public IActionResult Editar(Proprietario proprietario)
        {
            proprietario.Validate();
            if (proprietario.EhValido)
            {
                _proprietarioRepositorio.Atualizar(proprietario);
                ViewBag.Confirma = "Salvo com sucesso!";
                return RedirectToAction("Index");
            }
            ViewBag.Mensagem = proprietario.ObterMensagensValidacao();
            return View();
        }

        public JsonResult ConsultaEndereco(string cep)
        {
            var result = BrasilAPI.ProcessarEndereco(cep);
            if (result.Status != TaskStatus.Faulted)
            {
                return Json(result);
            }
            return Json(new Endereco());
        }
    }
}
