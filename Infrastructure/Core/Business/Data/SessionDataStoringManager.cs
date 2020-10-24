using Infrastructure.Core.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Core.Business.Data {
    /// <summary>
    /// Interface for the storing of session data
    /// WARNING: The implementations of this interface are injected in Singleton scope
    /// </summary>
    public class SessionDataStoringManager : ISessionDataStoringManager {
        public string ActiveMethod => throw new NotImplementedException();

        public bool HasLogEnabled => throw new NotImplementedException();

        public bool HasActiveMethod => throw new NotImplementedException();

        public IList<BusinessError> LastManagerErrors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ClearErrors() {
            throw new NotImplementedException();
        }

        public void ClearLogToActiveMethod() {
            throw new NotImplementedException();
        }

        public void EnableLogToActiveMethod() {
            throw new NotImplementedException();
        }

        public object GetCurrentManagerErrors() {
            throw new NotImplementedException();
        }

        public IList<BusinessError> GetLastManagerErrors() {
            throw new NotImplementedException();
        }

        public object GetObject(string key) {
            throw new NotImplementedException();
        }

        public void SetActiveMethod(string method) {
            throw new NotImplementedException();
        }

        public void SetError(BusinessError error) {
            throw new NotImplementedException();
        }

        public void StoreObject(string key, object @object) {
            throw new NotImplementedException();
        }
    }
}
