using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// [Controller] class atrribute merkkaa käännösvaiheessa (dotnet build)

[ApiController]
[Route("")]
public class Controller
{

    [HttpGet]
    public async Task<ActionResult<string>> GetGreeting() {
        return "haloo haloo haloo"
        + " haloo haloo haloo"
        + " kaikki ok!";
    }

    [HttpGet("/Milla")]
    public ActionResult<string> GetMilla() {
        return "Milla Milla Milla";
    }
}