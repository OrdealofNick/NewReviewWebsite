using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NewReviewWebsite.Controllers
{
    public class HomeController : Controller
    {
            public IActionResult Index() {
                return View();
            }

            public IActionResult About() {
                ViewData["Message"] = "Your application description page.";

                return View();
            }

            public IActionResult Contact() {
                ViewData["Message"] = "Your contact page.";

                return View();
            }

            public IActionResult Error() {
                return View();
            }
            public IActionResult Review() {
                return View();
            }

            public IActionResult ATrickoftheTail() {
                return View();
            }

            public IActionResult ReviewTwo() {
                return View();
            }

            public IActionResult ReviewThree() {
                return View();
            }

            public IActionResult SignIn() {
                return View();
            }

            public IActionResult SignUp() {
                return View();
            }

            public IActionResult ScreamBloodyGore() {
                return View();
            }
            public IActionResult Astonishing() {
                return View();
            }
            public IActionResult DivisionBell() {
                return View();
            }
            public IActionResult UnderConstruction() {
                return View();
            }
            public IActionResult Hardwired() {
                return View();
            }
            public IActionResult LambLiesDown() {
                return View();
            }
            public IActionResult ImagesWords() {
                return View();
            }
            public IActionResult FallingIntoInfinity() {
                return View();
            }
            public IActionResult FromGenesisToRevelation() {
                return View();
            }
            public IActionResult ChildrenOfFire() {
                return View();
            }
            public IActionResult AlongTheShadow() {
                return View();
            }
            public IActionResult LowTeens() {
                return View();
            }
            public IActionResult LongColdWinter() {
                return View();
            }
            public IActionResult EvilEmpire() {
                return View();
            }
            public IActionResult FromMarsToSirus() {
                return View();
            }
            public IActionResult Colors() {
                return View();
            }
            public IActionResult OnceMoreRoundTheSun() {
                return View();
            }
            public IActionResult Wovenwar() {
                return View();
            }
        }
    }
