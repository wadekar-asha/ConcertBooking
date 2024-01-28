using AutoMapper;
using ConcertBooking.UI.ViewModels.VenueViewModel;
using Microsoft.AspNetCore.Mvc;
using ConcertBooking.Entities;
using ConcertBooking.Repositories.Interfaces;

namespace ConcertBooking.UI.Controllers
{
    public class VenueController : Controller
    {
        private IVenueRepo _venueRepo;
        private IMapper _mapper;

        public VenueController(IVenueRepo venueRepo, IMapper mapper)
        {
            _venueRepo = venueRepo;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var venues = await _venueRepo.GetAll();
            var vm = _mapper.Map<List<VenueViewModel>>(venues);
            return View(vm);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateVenueViewModel vm)
        {
            var model = _mapper.Map<Venue>(vm);
            await _venueRepo.SaveEntity(model);  // Task.CompletedTask
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var venue = await _venueRepo.GetById(id);
            var vm = _mapper.Map<VenueViewModel>(venue);
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(VenueViewModel vm)
        {
            var model = _mapper.Map<Venue>(vm);
            await _venueRepo.UpdateEntity(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var venue = await _venueRepo.GetById(id);
            await _venueRepo.DeleteEntity(venue);
            return RedirectToAction("Index");
        }
    }
}
