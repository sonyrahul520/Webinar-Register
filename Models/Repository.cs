using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webinar_Register.Models
{
    public class Repository
    {
        private static List<WebinarRegisters> responses = new List<WebinarRegisters>();
        public static IEnumerable<WebinarRegisters> Responses => responses;

        public static void AddResponse(WebinarRegisters response)
        {
            responses.Add(response);
        }
    }
}
