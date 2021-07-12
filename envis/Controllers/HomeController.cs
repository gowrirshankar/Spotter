using Database.Model;
using envis.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Repositories.Repositories;

namespace envis.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISpotterRepository _repository;

        public HomeController(ISpotterRepository repository)
        {
            _repository = repository;
        }

        public async Task<ActionResult> GetAllItems()
        {
            try
            {
                var items = await _repository.GetAllItems();
                if (items == null)
                    return NotFound();
                return View(items);
            }
            catch(Exception)
            {
                return BadRequest();
            }
        }

        public async Task<ActionResult> GetIndividualItem(int id)
        {
            try
            {
                var item = await _repository.GetIndividualItem(id);
                if (item == null)
                    return NotFound();
                return View(item);
            }
            catch(Exception)
            {
                return BadRequest();
            }
        }

        public ActionResult create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> create(Spotter objSpot)
        {
            try
            {
                var id = await _repository.AddNewItem(objSpot);
                if (id > 0)
                    //return Ok(id);
                    return View();
                else
                    return NotFound();
            }
            catch(Exception)
            {
                return BadRequest();
            }
        }

        public async Task<ActionResult> Edit(int id)
        {
            var item = await _repository.GetIndividualItem(id);
            return View(item);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(Spotter objSpot)
        {
            try
            {
                await _repository.UpdateItem(objSpot);
                return RedirectToAction("GetAllItems", "Home");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await _repository.DeleteItem(id);
                return RedirectToAction("GetAllItems", "Home");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
