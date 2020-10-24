using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Core.Business.Interfaces {
    public interface IBusinessResult<TBusinessData> where TBusinessData : IBusinessData {
        /// <summary>
        /// Returns the business state of business processing.
        /// </summary>
        IBusinessState BusinessState { get; }

        /// <summary>
        /// Contains data of a successful businesss processing.
        /// </summary>
        IList<TBusinessData> Data { get; set; }

        /// <summary>
        /// Returns the number of entity records in case of entity count request.
        /// </summary>
        int EntityCount { get; set; }
    }
}
