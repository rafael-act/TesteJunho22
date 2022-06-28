using Microsoft.AspNetCore.Mvc;
using RevendaVeiculos.Dominio.Contratos;
using RevendaVeiculos.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RevendaVeiculos.Controllers
{
    public class MarcaController : Controller
    {
        private readonly IMarcaRepositorio _marcaRepositorio;
        public MarcaController(IMarcaRepositorio marcaRepositorio)
        {
            _marcaRepositorio = marcaRepositorio;
        }

        public IActionResult Index()
        {
            var m = _marcaRepositorio.ObterTodos();
            return View(m);
        }

        public IActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Novo(Marca marca)
        {
            marca.Validate();
            if (marca.EhValido && _marcaRepositorio.ValidaDuplicacao(marca))
            {
                _marcaRepositorio.Adicionar(marca);
                ViewBag.Confirma = "Salvo com sucesso!";
                return RedirectToAction("Index");
            }
            ViewBag.Mensagem = marca.ObterMensagensValidacao();
            return View();
        }

        public IActionResult Editar(int id)
        {
            Marca marca = _marcaRepositorio.ObterPorId(id);
            if (marca == null)
            { 
                return RedirectToAction("Index");
            }
            return View(marca);
        }

        [HttpPost]
        public IActionResult Editar(Marca marca)
        {
            marca.Validate();
            if (marca.EhValido)
            {
                _marcaRepositorio.Atualizar(marca);
                ViewBag.Confirma = "Salvo com sucesso!";
                return RedirectToAction("Index");
            }
            ViewBag.Mensagem = marca.ObterMensagensValidacao();
            return View();
        }
    }
}
