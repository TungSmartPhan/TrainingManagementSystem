using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrainingManagementSystem.Models;

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
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tungs/Create
        [HttpPost]
        public ActionResult Create(TraineeInfo trainee)
        {
            var traineeCreated = new TraineeInfo();
            traineeCreated.Age = trainee.Age;
            traineeCreated.IdStudent = trainee.IdStudent;
            traineeCreated.TraineeAccount = trainee.TraineeAccount;
            traineeCreated.TOEICScore = trainee.TOEICScore;
            traineeCreated.Location = trainee.Location;
            traineeCreated.Description = trainee.Description;
            traineeCreated.DateBorn = trainee.DateBorn;


            _context.TraineeDb.Add(traineeCreated);            
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}