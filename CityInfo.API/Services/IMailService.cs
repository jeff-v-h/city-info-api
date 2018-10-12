using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Services
{
    // The mail service is used in this project to notify by email when a point of interest
    // has been deleted. Deleting something has quite an impact on consumers of APIs
    // The SQL Server Database Engine can send e-mail messages to users.
    // The database app uses Database Mail which uses standard Simple Mail Transfer Protocol (SMTP)
    public interface IMailService
    {
        void Send(string subject, string message);
    }
}
