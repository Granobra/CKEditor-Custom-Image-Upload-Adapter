using CKEditor_Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace CKEditor_Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public ActionResult<UploadResponse> Upload()
        {
            //Image upload servisini yazmalısınız. 
            //Dönüş değeri yüklenen görselin yolu olacaktır. 

            UploadResponse output = new UploadResponse
            {
                Default = "https://localhost:44353/img/to-top.png"
            };

            return output;
        }
    }
}