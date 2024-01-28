using AutoMapper;
using ConcertBooking.UI.ViewModels.ConvertViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ConcertBooking.Entities;
using ConcertBooking.Repositories.Interfaces;
using System;

namespace ConcertBooking.UI.Controllers
{
    public class ConcertController : Controller
    {
        private IConcertRepo _concertRepo;
        private IVenueRepo _venueRepo;
        private IMapper _mapper;
        public ConcertController(IConcertRepo concertRepo, IVenueRepo venueRepo,IMapper mapper)
        {
            _concertRepo = concertRepo;
            _venueRepo = venueRepo;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {            
            var concerts = await _concertRepo.GetAll();
            var model = _mapper.Map<List<ConcertViewModel>>(concerts);           
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var venue = await _venueRepo.GetAll();
            ViewBag.venueList = new SelectList(venue, "ID", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateConcertViewModel vm)
        {
            var model = _mapper.Map<Concert>(vm);            
            await _concertRepo.SaveEntity(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var concert = await _concertRepo.GetById(id);
            var model = _mapper.Map<ConcertViewModel>(concert);            
            var venue = await _venueRepo.GetAll();
            ViewBag.venueList = new SelectList(venue, "ID", "Name");
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ConcertViewModel vm)
        {
            var model = _mapper.Map<Concert>(vm);
            await _concertRepo.UpdateEntity(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var venue = await _concertRepo.GetById(id);
            await _concertRepo.DeleteEntity(venue);
            return RedirectToAction("Index");
        }
    }
}
