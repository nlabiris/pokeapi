using Infrastructure.Core.Business.Data;
using Infrastructure.Core.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Core.Business {
    public class BusinessResult<TBusinessData> : IBusinessResult<TBusinessData> where TBusinessData : IBusinessData {
        public BusinessResult() {
            BusinessState = new BusinessState() { BusinessStatus = BusinessStatus.BusinessOk };
            Data = new List<TBusinessData>();
        }
        public IBusinessState BusinessState { get; }
        public IList<TBusinessData> Data { get; set; }
        public int EntityCount { get; set; }
    }
}
