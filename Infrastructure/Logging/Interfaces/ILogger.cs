using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Logging.Interfaces {
    public interface ILogger {
        /// <summary>
        /// Writes the diagnostic message at the Error level.
        /// </summary>
        /// <param name="message"></param>
        void LogError(string message);

        /// <summary>
        /// Writes the diagnostic message and exception at the Error level.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        void LogException(string message, Exception exception);

        /// <summary>
        /// Writes the diagnostic message at the Trace level.
        /// </summary>
        /// <param name="message"></param>
        void Trace(string message);

        /// <summary>
        /// Writes the diagnostic message and exception at the Trace level.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        void Trace(Exception exception, string message);

        /// <summary>
        /// Writes the diagnostic message at the Info level.
        /// </summary>
        /// <param name="message"></param>
        void Info(string message);

        /// <summary>
        /// Writes the diagnostic message and exception at the Info level.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        void Info(Exception exception, string message);

        /// <summary>
        /// Writes the diagnostic message at the Debug level.
        /// </summary>
        /// <param name="message"></param>
        void Debug(string message);

        /// <summary>
        /// Writes the diagnostic message and exception at the Debug level.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        void Debug(Exception exception, string message);

        /// <summary>
        /// Writes the diagnostic message at the Warn level.
        /// </summary>
        /// <param name="message"></param>
        void Warn(string message);

        /// <summary>
        /// Writes the diagnostic message and exception at the Warn level.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        void Warn(Exception exception, string message);

        /// <summary>
        /// Writes the diagnostic message at the Fatal level.
        /// </summary>
        /// <param name="message"></param>
        void Fatal(string message);

        /// <summary>
        /// Writes the diagnostic message and exception at the Fatal level.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        void Fatal(Exception exception, string message);
    }
}
