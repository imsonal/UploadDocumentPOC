using DataLayer.Entities;
using Helper;
using Helper.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class FTPFileBLL
    {
        private readonly CommonHelper _commonHelper;
        private readonly IConfiguration _configaration;
        private readonly IHostingEnvironment _hostingEnvironment;

        public FTPFileBLL( CommonHelper commonHelper, IConfiguration configuration, IHostingEnvironment hostingEnvironment)
        { 
           // _dBContext = userLogContext;
            _commonHelper = commonHelper;
            _configaration = configuration;
            _hostingEnvironment = hostingEnvironment;
        }

        public CommonResponse DownloadFTPFile()
        { 
            CommonResponse commonResponse = new CommonResponse();
            string ftpURL = _configaration.GetSection("FTPCredetial:FTPServer").Value;
            string UserName = _configaration.GetSection("FTPCredetial:UserName").Value;
            string Password = _configaration.GetSection("FTPCredetial:Password").Value;
            string FileName = "PPM20220711-New.csv";
            string LocalDirectory = Path.Combine(_hostingEnvironment.ContentRootPath, "wwwroot", "Files");

            try
            {
                FtpWebRequest requestFileDownload = (FtpWebRequest)WebRequest.Create(ftpURL + "/" + FileName);
                requestFileDownload.Credentials = new NetworkCredential(UserName, Password);
                requestFileDownload.Method = WebRequestMethods.Ftp.DownloadFile;
                FtpWebResponse responseFileDownload = (FtpWebResponse)requestFileDownload.GetResponse();
                Stream responseStream = responseFileDownload.GetResponseStream();
                FileStream writeStream = new FileStream(LocalDirectory + "/" + FileName, FileMode.Create);
                int Length = 33586;
                Byte[] buffer = new Byte[Length];
                //Stream fileStream = new FileStream(path + "/" + file, FileMode.OpenOrCreate
                int bytesRead = responseStream.Read(buffer, 0, Length);
                responseStream.CopyTo(writeStream);
                responseStream.Close();
                while (bytesRead > 0)
                {
                    writeStream.Write(buffer, 0, bytesRead);
                    bytesRead = responseStream.Read(buffer, 0, Length);
                }
                responseStream.Close();
                writeStream.Close();
                commonResponse.Message = "Success......";
                commonResponse.StatusCode = HttpStatusCode.OK;
                commonResponse.Status = true;
                requestFileDownload = null;
            }
            catch (Exception)
            {
                throw;
            }
            return commonResponse;
            
        }
        //public CommonResponse UploadCSVDocument(UploadCSVDocumentReqDTO uploadDocumentReqDTO)
        //{
        //    string ftpURL = _configaration.GetSection("FTPCredetial:FTPServer").Value;
        //    string UserName = _configaration.GetSection("FTPCredetial:UserName").Value;
        //    string Password = _configaration.GetSection("FTPCredetial:Password").Value;
        //    //  string ftpDirectory = ;
        //    string FileName = "PPM20220711-New.csv";
        //    string LocalDirectory = Path.Combine(_hostingEnvironment.ContentRootPath, "wwwroot", "Files");


        //    CommonResponse commonResponse = new CommonResponse();
        //    //if (!File.Exists(LocalDirectory + "/" + FileName))
        //    //{
        //    try
        //    {
        //        FtpWebRequest requestFileDownload = (FtpWebRequest)WebRequest.Create(ftpURL + "/" + FileName);
        //        requestFileDownload.Credentials = new NetworkCredential(UserName, Password);
        //        requestFileDownload.Method = WebRequestMethods.Ftp.DownloadFile;
        //        FtpWebResponse responseFileDownload = (FtpWebResponse)requestFileDownload.GetResponse();
        //        Stream responseStream = responseFileDownload.GetResponseStream();
        //        FileStream writeStream = new FileStream(LocalDirectory + "/" + FileName, FileMode.Create);
        //        int Length = 33586;
        //        Byte[] buffer = new Byte[Length];
        //        //Stream fileStream = new FileStream(path + "/" + file, FileMode.OpenOrCreate
        //        int bytesRead = responseStream.Read(buffer, 0, Length);
        //        responseStream.CopyTo(writeStream);
        //        responseStream.Close();
        //        while (bytesRead > 0)
        //        {
        //            writeStream.Write(buffer, 0, bytesRead);
        //            bytesRead = responseStream.Read(buffer, 0, Length);
        //        }
        //        responseStream.Close();
        //        writeStream.Close();
        //        commonResponse.Message = "Success......";
        //        commonResponse.StatusCode = HttpStatusCode.OK;
        //        commonResponse.Status = true;
        //        requestFileDownload = null;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //    // }
        //    return commonResponse;
        //}
    }
}
