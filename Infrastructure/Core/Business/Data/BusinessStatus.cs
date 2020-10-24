using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Core.Business.Data {
    public enum BusinessStatus {
        /// <summary>
        /// Business processing completed successfully.
        /// </summary>
        BusinessOk = 0,

        /// <summary>
        /// Business processing completed with warnings.
        /// </summary>
        BusinessOkWithWarnings = 1,

        /// <summary>
        /// Business processing failed.
        /// </summary>
        BusinessFailed = 2
    }
}
