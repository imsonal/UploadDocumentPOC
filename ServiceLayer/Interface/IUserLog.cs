using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Interface
{
    public interface IUserLog
    {
        //public interface ILog
        //{
        //    void Information(string message);
        //    void Warning(string message);
        //    void Debug(string message);
        //    void Error(string message);
        //}

        void Information(string message);
        void Warning(string message);
        void Debug(string message);
        void Error(string message);
    }
}
