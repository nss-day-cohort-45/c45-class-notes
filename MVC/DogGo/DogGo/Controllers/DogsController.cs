using DogGo.Models;
using DogGo.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DogGo.Controllers
{
    [Authorize]
    public class DogsController : Controller
    {

        private readonly IOwnerRepository _ownerRepository;
        private readonly IDogRepository _dogRepository;

        public DogsController(
            IOwnerRepository ownerRepository,
            IDogRepository dogRepository)
        {
            _ownerRepository = ownerRepository;
            _dogRepository = dogRepository;
        }

        private int GetCurrentUserId()
        {
            string id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return int.Parse(id);
        }

        // GET: DogsController
        public ActionResult Index()
        {
            int ownerId = GetCurrentUserId();
            return View(_dogRepository.GetDogsByOwnerId(ownerId));
        }

        // GET: DogsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DogsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Dog dog)
        {
            try
            {
                dog.OwnerId = GetCurrentUserId();
                _dogRepository.AddDog(dog);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DogsController/Edit/id
        public ActionResult Edit(int id)
        {
            int ownerId = GetCurrentUserId();
            Dog dog = _dogRepository.GetDogById(id, ownerId);

            if (dog == null)
            {
                return NotFound();
            }

            return View(dog);
        }

        // POST: DogsController/Edit/id
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Dog dog)
        {
            try
            {
                dog.OwnerId = GetCurrentUserId();
                _dogRepository.UpdateDog(dog);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DogsController/Delete/id
        public ActionResult Delete(int id)
        {
            int ownerId = GetCurrentUserId();
            Dog dog = _dogRepository.GetDogById(id, ownerId);

            if (dog == null)
            {
                return NotFound();
            }

            return View(dog);
        }

        // POST: DogsController/Delete/id
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Dog dog)
        {
            try
            {
                int ownerId = GetCurrentUserId();
                _dogRepository.DeleteDog(dog.Id, ownerId);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
      }
}
