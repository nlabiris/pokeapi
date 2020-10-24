using Infrastructure.Core.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Core.Business.Data {
    [Serializable]
    public class BusinessError : IBusinessError {
        public BusinessError() {
            BusinessErrorType = BusinessErrorType.Error;
        }
        public BusinessErrorType BusinessErrorType { get; set; }
        public BusinessErrorCode BusinessErrorCode { get; set; }
        public BusinessWarningCode BusinessWarningCode { get; set; }
        public string BusinessErrorDescription { get; set; }
        public string ExternalBusinessErrorCode { get; set; }
    }
}
