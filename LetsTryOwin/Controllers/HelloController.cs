using System.Collections.Generic;
using System.Web.Http;

namespace LetsTryOwin.Controllers
{
    public class HelloController : ApiController
    {
        public object Get(string id)
        {
            return new {ID = string.Format("Hello {0}!", id)};
        }
    }
}