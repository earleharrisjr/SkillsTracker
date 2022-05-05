using Microsoft.AspNetCore.Mvc;

namespace SkillsTracker.Controllers
{
    public class SkillsController : Controller
    {
                public IActionResult Index()
        {
            string html = "<h1>Skills Tracker</h1>" +
                "<h2>Coding Skills to Learn</h2>" +
                "<ol>" +
                "<li>C#</li>" +
                "<li>JavaScript</li>" +
                "<li>Python</li>" +
                "</ol>";
            return Content(html, "text/html");
        }
        [HttpGet("/skills/form")]
        public IActionResult SkillForm()
        {
            string html = "<form method='post'>" +
                "<label for='date'> Date:</label>" +
                "<br>" +
                "<input type='date' name='date'>" +
                "<br>" +
                "<label for='C#'> C#:</label>" +
                "<br>" +
                "<select name ='CSharp'>" +
                "<option value='beginner' selected>Beginner</option>" +
                "<option value='intermediate'>Intermediate</option>" +
                "<option value='advanced'>Advanced</option>" +
                "</select>" +
                "<br>" +
                "<label for='JavaScript'> JavaScript:</label>" +
                "<br>" +
                "<select name ='JavaScript'>" +
                "<option value='beginner' selected>Beginner</option>" +
                "<option value='intermediate'>Intermediate</option>" +
                "<option value='advanced'>Advanced</option>" +
                "</select>" +
                "<br>" +
                "<label for='Python'> Python:</label>" +
                "<br>" +
                "<select name ='Python'>" +
                "<option value='beginner' selected>Beginner</option>" +
                "<option value='intermediate'>Intermediate</option>" +
                "<option value='advanced'>Advanced</option>" +
                "</select>" +
                "<br>" +
                "<input type='submit' value='Submit' />" +
                "</form>";
            return Content(html, "text/html");
        }
        [HttpPost("/skills/form")]
        public IActionResult FormPost(string date, string CSharp, string JavaScript, string Python)
        {
            string html = $"<h1>Skills Tracker</h1>" +
                $"<h2>{date}</h2>" +
                "<ol>" +
                $"<li>C# Skill Level: {CSharp}</li>" +
                $"<li>JavaScript Skill Level: {JavaScript}</li>" +
                $"<li>Python Skill Level: {Python}</li>" +
                "</ol>";
            return Content(html, "text/html");
        }
    }
}
