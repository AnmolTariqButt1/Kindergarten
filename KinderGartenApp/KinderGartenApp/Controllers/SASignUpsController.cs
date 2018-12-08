using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace KinderGartenApp.Controllers
{
    public class SASignUpsController : Controller
    {
        private KindergartenEntities4 db = new KindergartenEntities4();

        // GET: SASignUps
        public ActionResult Index()
        {
            return View(db.SignUpTables.ToList());
        }

        // GET: SASignUps/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SignUpTable sASignUp = db.SignUpTables.Find(id);
            if (sASignUp == null)
            {
                return HttpNotFound();
            }
            return View(sASignUp);
        }

        // GET: SASignUps/Create
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult SignUp()
        {


            return View();
        }
        public ActionResult Sections()
        {
            return View();
        }
        public ActionResult dashboardTeacher()
        {
            return View();
        }
        public ActionResult SignIn([Bind(Include = "UserID,Name,Email,Password")] SignUpTable sASignIn)
        {
            return View(sASignIn);
        }
        public ActionResult dashboardStudent()
        {
            return View();
        }
        public ActionResult dashboardAdmin()
        {
            return View();
        }

        public ActionResult tableA()
        {
            return View();
        }
        public ActionResult tableT()
        {
            return View();
        }
        public ActionResult userT()
        {
            return View();
        }
        public ActionResult userS()
        {
            return View();
        }
        public ActionResult MessagesS()
        {
            return View();
        }
        public ActionResult MessagesT()
        {
            return View();
        }
        public ActionResult notificationsT()
        {
            return View();
        }
        public ActionResult notificationsS()
        {
            return View();
        }

        public ActionResult AnnouncementsS()
        {
            return View();
        }
        public ActionResult AssignmentsS()
        {
            return View();
        }
        public ActionResult AnnouncementsT()
        {
            return View();
        }
        public ActionResult AssignmentsT()
        {
            return View();
        }
        // POST: SASignUps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp([Bind(Include = "UserID,Name,Email,Password,ConfirmPassword")] SignUpTable sASignUp)
        {
            
               return View(sASignUp);

              }

        // GET: SASignUps/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SignUpTable sASignUp = db.SignUpTables.Find(id);
            if (sASignUp == null)
            {
                return HttpNotFound();
            }
            return View(sASignUp);
        }

        // POST: SASignUps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserID,Name,Email,Password,ConfirmPassword")] SignUpTable sASignUp)
        {
            if (ModelState.IsValid)
            {

                db.Entry(sASignUp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sASignUp);
        }

        // GET: SASignUps/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SignUpTable sASignUp = db.SignUpTables.Find(id);
            if (sASignUp == null)
            {
                return HttpNotFound();
            }
            return View(sASignUp);
        }

        // POST: SASignUps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            SignUpTable sASignUp = db.SignUpTables.Find(id);
            db.SignUpTables.Remove(sASignUp);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
