using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrainingManagementSystem.Models;
using TrainingManagementSystem.ViewModels;

namespace TrainingManagementSystem.Controllers
{
    public class TrainingStaffController : Controller
    {
        private readonly ApplicationDbContext _context;
        // GET: TrainingStaff
        public TrainingStaffController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index(string searchString)
        {
            var trainee = _context.TraineeDb.ToList();

            if (!String.IsNullOrWhiteSpace(searchString))
            {
                trainee = _context.TraineeDb.Where(t => t.Name.Contains(searchString)).ToList();
            }

            return View(trainee);
        }


        // GET: Tungs/Create
        [HttpGet]
        public ActionResult Create()
        {
            var viewModel = new TraineeCourseViewModel()
            {
                COURSE = _context.CourseDb.ToList()
            };
            return View(viewModel);
        }

        // POST: Tungs/Create
        [HttpPost]
        public ActionResult Create(TraineeInfo trainee)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var traineeCreated = new TraineeInfo
            {
                Age = trainee.Age,
                IdStudent = trainee.IdStudent,
                TraineeAccount = trainee.TraineeAccount,
                TOEICScore = trainee.TOEICScore,
                Location = trainee.Location,
                Description = trainee.Description,
                DateBorn = trainee.DateBorn,
                CourseId = trainee.CourseId,
            };
            
            _context.TraineeDb.Add(traineeCreated);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}