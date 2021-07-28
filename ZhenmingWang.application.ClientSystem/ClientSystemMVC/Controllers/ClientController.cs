using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApplicationCore.Models;
using ApplicationCore.ServiceInterfaces;

namespace ClientSystemMVC.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        public IActionResult NewClient()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateClient(ClientDetailsModel model)
        {
            var updatedClientCard = await _clientService.UpdateClient(model);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteClient(ClientDetailsModel model)
        {
            await _clientService.DeleteClient(model.Id);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> NewClientAsync(ClientAddRequestModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var clientCard = await _clientService.AddNewClient(model);
            return RedirectToAction("Index", "Home");
        }

        
        public async Task<IActionResult> ClientDetails(int id)
        {
            var clientDetails = await _clientService.GetClientDetails(id);
            return View(clientDetails);
        }
    }
}