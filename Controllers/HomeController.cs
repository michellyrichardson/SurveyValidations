using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SurveyValidations.Models;

namespace SurveyValidations.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Survey()
        {
            Info student = new Info();
            student.Name = "name";
            student.Location = "location";
            student.Language = "language";
            student.Message = "message";

            return View("Survey", student);
        }

        [HttpPost("result")]
        public ViewResult NewStudent(Info FromForm)
        {
            //Add this if statement to validate your restrictions
            if(ModelState.IsValid)
            {
            return View("NewStudent", FromForm);
            }
            else
            {
                return Survey();
            }
        }
    }
}