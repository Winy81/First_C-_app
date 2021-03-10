using System;
using first_project.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace first_project.API.Controllers
{

    [Route("v1/[Controller]")]
    [ApiController]

    public class StreakController
    {
        public StreakController()
        {
        }

        //http://localhost:41937/v1/streak
        [HttpGet]
        public Response GetStreakResponse()
        {
            return new Response();
        }

    }
}
