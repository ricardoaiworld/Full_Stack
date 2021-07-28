using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApplicationCore.Models;
using ApplicationCore.ServiceInterfaces;

namespace ClientSystemMVC.Controllers
{
    public class InteractionController : Controller
    {
        private readonly IInteractionService _interactionservice;
        public InteractionController(IInteractionService interactionservice)
        {
            _interactionservice = interactionservice;
        }

        [HttpGet]
        public IActionResult NewInteraction()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NewInteractionAsync(InteractionAddRequestModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var clientCard = await _interactionservice.AddNewInteraction(model);
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> InteractionDetails(int id)
        {
            var interactionDetails = await _interactionservice.GetInteractionDetails(id);
            return View(interactionDetails);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateInteraction(InteractionDetailsModel model)
        {
            var updatedInteraction = await _interactionservice.UpdateInteraction(model);
            return RedirectToAction("Employee", "Employee");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteInteraction(InteractionDetailsModel model)
        {
            await _interactionservice.DeleteInteraction(model.Id);
            return RedirectToAction("Employee", "Employee");
        }
    }
}