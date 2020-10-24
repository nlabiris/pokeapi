using Infrastructure.Core.Business.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Core.Business.Interfaces {
    /// <summary>
    /// Interface for the storing of session data
    /// WARNING: The implementations of this interface are injected in Singleton scope
    /// </summary>
    public interface ISessionDataStoringManager {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="object"></param>
        void StoreObject(string key, object @object);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        object GetObject(string key);

        /// <summary>
        /// 
        /// </summary>
        string ActiveMethod { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="method"></param>
        void SetActiveMethod(string method);

        /// <summary>
        /// 
        /// </summary>
        void EnableLogToActiveMethod();

        /// <summary>
        /// 
        /// </summary>
        void ClearLogToActiveMethod();

        /// <summary>
        /// 
        /// </summary>
        bool HasLogEnabled { get; }

        /// <summary>
        /// 
        /// </summary>
        bool HasActiveMethod { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="error"></param>
        void SetError(BusinessError error);

        /// <summary>
        /// 
        /// </summary>
        IList<BusinessError> LastManagerErrors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        object GetCurrentManagerErrors();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IList<BusinessError> GetLastManagerErrors();

        /// <summary>
        /// 
        /// </summary>
        void ClearErrors();
    }
}
