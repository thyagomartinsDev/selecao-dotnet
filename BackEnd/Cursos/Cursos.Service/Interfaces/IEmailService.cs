using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursos.Service.Interfaces
{
    public interface IEmailService
    {
        Task EnviaEmail(string toEmail, string subject, string content);
    }
}
