using Infrastructure.Core.Business.Data;
using Infrastructure.Core.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Core.Business {
    public class BusinessState : IBusinessState {
        public BusinessState() {
            BusinessStatus = BusinessStatus.BusinessOk;
            BusinessErrors = new List<BusinessError>();
        }
        public BusinessStatus BusinessStatus { get; set; }
        public IList<BusinessError> BusinessErrors { get; set; }
    }
}
