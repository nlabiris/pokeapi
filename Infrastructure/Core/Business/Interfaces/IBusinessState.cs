using Infrastructure.Core.Business.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Core.Business.Interfaces {
    public interface IBusinessState {
        /// <summary>
        /// Returns the business status of business processing.
        /// </summary>
        BusinessStatus BusinessStatus { get; set; }

        /// <summary>
        /// Returns any errors of business processing.
        /// </summary>
        IList<BusinessError> BusinessErrors { get; set; }
    }
}
