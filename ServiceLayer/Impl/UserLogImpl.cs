using BussinessLayer;
using Helper.Models;
using ServiceLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Impl
{
    public class UserLogImpl : IUserLog
    {
        private readonly UserLogBLL _userLogBLL;
        public UserLogImpl(UserLogBLL userLogBLL)
        { 
            _userLogBLL = userLogBLL;
        }
        public CommonResponse Debug(string message)
        {
            throw new NotImplementedException();
        }

        public CommonResponse Error(string message)
        {
            throw new NotImplementedException();
        }

        public CommonResponse Information(string message)
        {
            throw new NotImplementedException();
        }

        public CommonResponse Warning(string message)
        {
            throw new NotImplementedException();
        }

        void IUserLog.Debug(string message)
        {
            throw new NotImplementedException();
        }

        void IUserLog.Error(string message)
        {
            throw new NotImplementedException();
        }

        void IUserLog.Information(string message)
        {
            throw new NotImplementedException();
        }

        void IUserLog.Warning(string message)
        {
            throw new NotImplementedException();
        }
    }
}
