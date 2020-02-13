using Microsoft.AspNetCore.Mvc;
using SalesWebMvcEst.Models;
using SalesWebMvcEst.Models.ViewModel;
using SalesWebMvcEst.Services;
using SalesWebMvcEst.Services.Exceptions;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace SalesWebMvcEst.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;
        private readonly DepartmentService _departmentService;
        public SellersController(SellerService sellerService, DepartmentService departmentService) //Setando a dependência do objeto
        {
            _sellerService = sellerService;
            _departmentService = departmentService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _sellerService.FindAllAsync());
        }

        public async Task<IActionResult> Create()
        {
            var deparments = await _departmentService.FindAllAsync();
            var viewModel = new SellerFormViewModel { Departments = deparments };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
       public async Task<IActionResult> Create(Seller seller)
        {

            if (!ModelState.IsValid)
            {
                var departments = await _departmentService.FindAllAsync();
                var viewModel = new SellerFormViewModel { Seller = seller, Departments = departments };
                return View(viewModel);
            }
            
            await _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }

        //Método GET
        public async Task<IActionResult> Delete(int? id)
        {
            
            if(id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            }

            var obj = await _sellerService.FindByiDAsync(id.Value);

            if(obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }

            return View(obj);

            //_sellerService.RemoveSeller(seller.Id);
            //return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _sellerService.RemoveSellerAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch(IntegrityException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
            
        }

        //Método GET
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            }

            var obj = await _sellerService.FindByiDAsync(id.Value);

            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }

            return View(obj);
        }

        //Método GET
        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            }

            var obj = await _sellerService.FindByiDAsync(id.Value);

            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }

            List<Department> departments = await _departmentService.FindAllAsync(); //Busca a lista de departamentos no DB

            //Chama a tela de edição com os campos já preenchidos, instanciando a ViewModel com o Depatamento do Obj encontrado;
            SellerFormViewModel viewModel = new SellerFormViewModel { Seller = obj, Departments = departments };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Seller seller)
        {

            if (!ModelState.IsValid)
            {
                var departments = await _departmentService.FindAllAsync();
                var viewModel = new SellerFormViewModel { Seller = seller, Departments = departments };
                return View(viewModel);
            }
            //Verifica se o ID informado na requisição é igual ao do Seller do DB
            if (id != seller.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id mismatch" });
            }

            //Se o ID for igual, chama o serviço de alteração;
            try 
            {
                await _sellerService.Update(seller);
                return RedirectToAction(nameof(Index));
            }
            catch(NotFoundException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
            catch(DbConcurrencyException e )
            {
                return RedirectToAction(nameof(Error), new { message = e.Message});
            }
            
        }

        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };

            return View(viewModel);
        }
    }
}