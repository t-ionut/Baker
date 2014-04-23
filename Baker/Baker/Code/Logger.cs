using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Baker
{
    public static class Logger
    {
        #region - Methods

        /// <summary>
        /// Used to write the start of a login session
        /// </summary>
        /// <param name="user"></param>
        /// <param name="isAdmin"></param>
        public static void WriteSessionStart(string user, bool isAdmin)
        {
            if (!Directory.Exists("LogFiles"))
                Directory.CreateDirectory("LogFiles");

            File.AppendAllText(String.Format("{0}\\{1}_{2:d2}_{3:d2}_AppLog.txt",
            Application.StartupPath.ToString() + "\\LogFiles\\", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
            String.Format("--------------------#login_session#--------------------" + Environment.NewLine + 
            "<LOGINDATE := {0}> : <USER := {1}> : <ADMIN := {2}>" + Environment.NewLine + "{3}" + Environment.NewLine,
            DateTime.Now.ToString(), user, isAdmin.ToString(), Environment.NewLine));
        }

        /// <summary>
        /// used to write to log file
        /// </summary>
        /// <param name="form">The name of the Object where the error occured</param>
        /// <param name="operation">The name of the operation that executed when the error occured</param>
        /// <param name="error">The actual error message</param>
        public static void WriteToLog(string obj, string operation, string error)
        {
            if (!Directory.Exists("LogFiles"))
                Directory.CreateDirectory("LogFiles");

            File.AppendAllText(String.Format("{0}\\{1}_{2:d2}_{3:d2}_AppLog.txt",
            Application.StartupPath.ToString() + "\\LogFiles\\", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
            String.Format("#log_start#" + Environment.NewLine + "<LOGDATE := {0}> : <OBJECT := {1}> : <OPERATION := {2}> "
            + ": <ERROR_TROW := {3}>" + Environment.NewLine + "#log_end#{4}" + Environment.NewLine,
            DateTime.Now.ToString(), obj, operation, error, Environment.NewLine));
        }

        /// <summary>
        /// used to write to log file
        /// </summary>
        /// <param name="form">The name of the Object where the error occured</param>
        /// <param name="operation">The name of the operation that executed when the error occured</param>
        /// <param name="parameters">the operation parameters</param>
        /// <param name="error">the error message</param>
        public static void WriteToLog(string obj, string operation, string parameters, string error)
        {
            File.AppendAllText(String.Format("{0}\\{1}_{2:d2}_{3:d2}_AppLog.txt",
            Application.StartupPath.ToString() + "\\LogFiles\\", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
            String.Format("#log_start#" + Environment.NewLine + "<LOGDATE := {0}> : <OBJECT := {1}> : <OPERATION := {2}> : <Parameters := {3}> "
            + ": <ERROR_TROW := {4}>" + Environment.NewLine + "#log_end#{5}" + Environment.NewLine,
            DateTime.Now.ToString(), obj, operation, parameters, error, Environment.NewLine));
        }

        /// <summary>
        /// used to write to log file 
        /// </summary>
        /// <param name="obj">The name of the Object where the error occured</param>
        /// <param name="operation">The name of the operation that executed when the error occured</param>
        /// <param name="parameters">the operation parameters</param>
        /// <param name="error">the error message</param>
        /// <param name="stackTrace">stack trace to identify where the error ocurrend</param>
        public static void WriteToLog(string obj, string operation, string parameters, string error, string stackTrace)
        {
            File.AppendAllText(String.Format("{0}\\{1}_{2:d2}_{3:d2}_AppLog.txt",
            Application.StartupPath.ToString() + "\\LogFiles\\", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
            String.Format("#log_start#" + Environment.NewLine + "<LOGDATE := {0}> : <OBJECT := {1}> : <OPERATION := {2}> : <Parameters := {3}> "
            + ": <ERROR_TROW := {4}> : <Stack Trace := {5}>" + Environment.NewLine + "#log_end#{6}" + Environment.NewLine,
            DateTime.Now.ToString(), obj, operation, parameters, error, stackTrace, Environment.NewLine));
        }

        #endregion



        
    }
}
