using Microsoft.Net.Http.Headers;
using System.Collections.Generic;

namespace CRudApplication.CommonLayer.Model
{
    public class ReadAllInformationResponse
    {
        public bool IsSuccess { get; set; }

        public string Message { get; set; }

        public List<GetReadAllInformation> readAllInformation { get; set; }

    }

    public class GetReadAllInformation
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string EmailID { get; set; }

        public string MobileNumber { get; set; }

        public string Gender { get; set; }

        public bool IsActive { get; set; }

        public string Salary { get; set; }
    }
}
