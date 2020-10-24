using Infrastructure.Core.Business.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Core.Business.Interfaces {
    public interface IBusinessError {
        BusinessErrorType BusinessErrorType { get; set; }
        BusinessErrorCode BusinessErrorCode { get; set; }
        BusinessWarningCode BusinessWarningCode { get; set; }
        string ExternalBusinessErrorCode { get; set; }
        string BusinessErrorDescription { get; set; }
    }
}
