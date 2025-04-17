using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SchoolAPI.Filters
{
    public class ValidateStudentFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.ActionArguments.TryGetValue("student", out var value) && value is Student student)
            {
                if (student.Average < 0 || student.Average > 20)
                {
                    context.Result = new BadRequestObjectResult("La moyenne doit être comprise entre 0 et 20.");
                }
            }

            base.OnActionExecuting(context);
        }
    }

}
