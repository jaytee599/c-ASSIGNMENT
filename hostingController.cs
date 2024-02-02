using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASSIGNMENNT_n01635556_joeltuffour.Controllers
{
    public class hostingController : Controller
    {
        // GET: /<controller>/
        public IEnumerable<string>
        CalculateHostingCost(double id)
        {
            double costPerFortnight = 5.50;
            double hstRate = 0.13;
            int fortnight = 14;

            // Ensure id is non-negative
            if (id < 0)
            {
                yield return "Invalid input. ID must be non-negative.";
                yield break;
            }

            // Calculate the number of fortnights
            int fortnights = (int)Math.Ceiling(id / fortnight);

            double hostingCost = fortnights * costPerFortnight;
            double hstAmount = hostingCost * hstRate;
            double totalCost = hostingCost + hstAmount;

            yield return $"{fortnights} {(fortnights == 1 ? "fortnight" : "fortnights")} at ${costPerFortnight:F2}/FN = ${hostingCost:F2} CAD";
            yield return $"HST {hstRate * 100}% = ${hstAmount:F2} CAD";
            yield return $"Total = ${totalCost:F2} CAD";
        }
        ```

        //In this version, the method uses the 'yield' keyword to returnn a sequence of strings as an 'IEnumerable<>'.
        // This also includes additional checks for negative values of 'id' and uses 'Math.Ceiling' to calculate the number of fortnights more accurately.



