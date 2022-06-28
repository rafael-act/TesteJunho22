using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RevendaVeiculos.Dominio.Contratos;
using RevendaVeiculos.Dominio.Entidades;
using RevendaVeiculos.Services.Rabbit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RevendaVeiculos.Controllers
{
    public class VeiculoController : Controller
    {
        private readonly IVeiculoRepositorio _veiculoRepositorio;
        private readonly IProprietarioRepositorio _proprietarioRepositorio;
        private readonly IMarcaRepositorio _marcaRepositorio;
        public List<SelectListItem> Opcoes { get; set; }

        public void OnGet()
        {
            Opcoes = _proprietarioRepositorio.ObterTodos().Select(a =>
                                          new SelectListItem
                                          {
                                              Value = a.Id.ToString(),
                                              Text = a.Nome
                                          }).ToList();
        }

        public VeiculoController(IVeiculoRepositorio veiculoRepositorio, IProprietarioRepositorio proprietarioRepositorio)
        {
            _veiculoRepositorio = veiculoRepositorio;
            _proprietarioRepositorio = proprietarioRepositorio;
        }
        public IActionResult Index()
        {
            var v = _veiculoRepositorio.ObterTodos();
            return View(v);
        }

        public IActionResult Novo()
        {
            PreencherSelect();
            return View();
        }

        [HttpPost]
        public IActionResult Novo(Veiculo veiculo, IFormCollection collection)
        {

            var proprietario = _proprietarioRepositorio.ObterPorId(int.Parse(collection["proprietario"]));
            
            if (proprietario != null)
            {
                veiculo.Proprietario = proprietario;
            }
            veiculo.Validate();
            if (veiculo.EhValido && _veiculoRepositorio.ValidaDuplicacao(veiculo))
            {
                _veiculoRepositorio.Adicionar(veiculo);
                ViewBag.Confirma = "Salvo com sucesso!";
                Emissor fila = new Emissor();
                fila.EnviaVeiculoFila(veiculo);
                Receptor receptor = new Receptor();
                receptor.RecebeVeiculoFila();
                return RedirectToAction("Index");
            }
            ViewBag.Mensagem = veiculo.ObterMensagensValidacao();
            return View();
        }

        public IActionResult Editar(int id)
        {
            PreencherSelect();
            Veiculo veiculo = _veiculoRepositorio.ObterPorId(id);
            if (veiculo == null)
            {
                return RedirectToAction("Index");
            }
            return View(veiculo);
        }

        [HttpPost]
        public IActionResult Editar(Veiculo veiculo, IFormCollection collection)
        {
            var proprietario = _proprietarioRepositorio.ObterPorId(int.Parse(collection["proprietario"]));
            if (proprietario != null)
            {
                veiculo.Proprietario = proprietario;
            }
            veiculo.Validate();
            if (veiculo.EhValido)
            {
                _veiculoRepositorio.Atualizar(veiculo);
                ViewBag.Confirma = "Salvo com sucesso!";
                Emissor fila = new Emissor();
                fila.EnviaVeiculoFila(veiculo);
                Receptor receptor = new Receptor();
                receptor.RecebeVeiculoFila();
                return RedirectToAction("Index");
            }
            ViewBag.Mensagem = veiculo.ObterMensagensValidacao();
            return View();
        }

        public void PreencherSelect()
        {
            IEnumerable<Proprietario> proprietario = new List<Proprietario>();
            IEnumerable<Marca> marca = new List<Marca>();
            try
            {
                proprietario = _proprietarioRepositorio.ObterTodos();
                ViewBag.Proprietario = proprietario;
            }
            catch { }

            try
            {
                marca = _marcaRepositorio.ObterTodos();
                ViewBag.Marca = marca;
            }
            catch { }
        }
    }
}
