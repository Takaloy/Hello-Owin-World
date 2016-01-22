using System;
using System.Net;
using System.Web.Http;
using LetsTryOwin.Domain;

namespace LetsTryOwin.Controllers
{
    public class RandomController : ApiController
    {
        private readonly IRandomNumberGenerator _randomNumberGenerator;

        public RandomController(IRandomNumberGenerator randomNumberGenerator)
        {
            if (randomNumberGenerator == null)
                throw new ArgumentNullException(nameof(randomNumberGenerator));

            _randomNumberGenerator = randomNumberGenerator;
        }


        public IHttpActionResult Get()
        {
            return Content(HttpStatusCode.OK,
                _randomNumberGenerator.GetRandomNumber());
        }
    }
}