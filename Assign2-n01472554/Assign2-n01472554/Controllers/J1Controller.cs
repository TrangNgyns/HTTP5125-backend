using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assign2_n01472554.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// Receives 
        /// <param name="burger"> Integer representing the index burger choice </param>
        /// <param name="drink"> Integer representing the index drink choice </param>
        /// <param name="side"> Integer representing the index side choice </param>
        /// <param name="dessert"> Integer representing the index dessert choice </param>
        /// <param name="totalCal"> Integer the sum of calories for the four menu choices </param>
        /// <param name="message"> The string output declaring customer's total calories. </param>
        /// <returns>
        /// "Your total calorie count is {totalCal}"
        /// </returns>
        /// </summary>
        /// <example>
        // GET api/J1/Menu/4/4/4/4 -> "Your total calorie count is 0"
        // GET api/J1/Menu/1/2/3/4 -> "Your total calorie count is 691"
        /// </example>

        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger, int drink, int side, int dessert)
        {
            int[] burgerList = { 461, 431, 420, 0 };
            int[] drinkList = { 130, 160, 118, 0 };
            int[] sideList = { 100, 57, 70, 0 };
            int[] dessertList = { 167, 266, 75, 0 };
            int burgerChoice;
            
            if (burger == 1)
            {
                burgerChoice = burgerList[0];
            }
            else if (burger == 2)
            {
                burgerChoice = burgerList[1];
            }
            else if (burger == 3)
            {
                burgerChoice = burgerList[2];
            }
            else
            {
                burgerChoice = burgerList[3];
            }
            
            int drinkChoice;
            if (drink == 1)
            {
                drinkChoice = drinkList[0];
            }
            else if (drink == 2)
            {
                drinkChoice = drinkList[1];
            }
            else if (drink == 3)
            {
                drinkChoice = drinkList[2];
            }
            else
            {
                drinkChoice = drinkList[3];
            }

            int sideChoice;
            if (side == 1)
            {
                sideChoice = sideList[0];
            }
            else if (side == 2)
            {
                sideChoice = sideList[1];
            }
            else if (side == 3)
            {
                sideChoice = sideList[2];
            }
            else
            {
                sideChoice = sideList[3];
            }

            int dessertChoice;
            if (dessert == 1)
            {
                dessertChoice = dessertList[0];
            }
            else if (dessert == 2)
            {
                dessertChoice = dessertList[1];
            }
            else if (dessert == 3)
            {
                dessertChoice = dessertList[2];
            }
            else
            {
                dessertChoice = dessertList[3];
            }
            int totalCal = burgerChoice + drinkChoice + sideChoice + dessertChoice;
            string message = "Your total calorie count is " + totalCal;
            return message;
        }
        /// Notes: I'm working on another way to shorten this IF ELSE IF statements to search for array index. This was my first try.

    }
}
