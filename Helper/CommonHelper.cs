using Helper.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class CommonHelper
    {
        private IConfiguration _configuration { get; }
        private IHostingEnvironment _hostingEnvironment { get; }
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CommonHelper(IConfiguration configuration,IHostingEnvironment hostingEnvironment,IHttpContextAccessor httpContextAccessor)
        { 
            _configuration = configuration;
            _hostingEnvironment = hostingEnvironment;
            _httpContextAccessor = httpContextAccessor;
        }
        public CommonResponse UploadFile(IFormFile file, string subDirectory, string fileName)
        {
            CommonResponse response = new CommonResponse();
            try
            {
                string savePath = string.Empty;
                string CurrentDirectory = Directory.GetCurrentDirectory();
                subDirectory = subDirectory ?? string.Empty;
                var target = Path.Combine(_hostingEnvironment.ContentRootPath, "wwwroot", "Files", subDirectory);


                Directory.CreateDirectory(target);
                savePath = Path.Combine("Files", subDirectory, fileName);
                var filePath = Path.Combine(target, fileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                response.Status = true;
                response.Message = "File Uploaded";
                response.Data = savePath;
            }
            catch (Exception ex)
            {
                response.Data = ex;
                response.Message = ex.Message;
            }
            return response;
        }


    }
}
