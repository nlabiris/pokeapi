using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Logging {
    /// <summary>
    /// Logger class.
    /// </summary>
    public class NLogger : Interfaces.ILogger {
        private readonly Logger _logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public void Trace(string message) {
            _logger.Info(message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="message"></param>
        public void Trace(Exception exception, string message) {
            _logger.Trace($"{message} Exception: {exception?.Message}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public void Info(string message) {
            _logger.Info(message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="message"></param>
        public void Info(Exception exception, string message) {
            _logger.Info($"{message} Exception: {exception?.Message}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public void Debug(string message) {
            _logger.Debug(message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="message"></param>
        public void Debug(Exception exception, string message) {
            _logger.Debug($"{message} Exception: {exception?.Message}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public void Warn(string message) {
            _logger.Warn(message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="message"></param>
        public void Warn(Exception exception, string message) {
            _logger.Warn($"{message} Exception: {exception?.Message}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public void LogException(string message, Exception exception) {
            _logger.Error($"{message} Exception: {exception?.Message}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public void LogError(string message) {
            _logger.Error(message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public void Fatal(string message) {
            _logger.Fatal(message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="message"></param>
        public void Fatal(Exception exception, string message) {
            _logger.Fatal($"{message} Exception: {exception?.Message}");
        }
    }
}
