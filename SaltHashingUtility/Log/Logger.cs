using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Required to access the Trace functions
using System.Diagnostics;

namespace SaltHashingUtility.Log
{
    /// <summary>
    ///     LOGGER - Allows for more detailed Tracelogging
    /// </summary>
    public static class Logger
    {
        private static TraceSwitch globalTraceSwitch;

        /// <summary>
        ///     INIT - Initialise the TraceLogger
        /// </summary>
        public static void Init()
        {
            globalTraceSwitch = new TraceSwitch("TraceLevelSwitch", "Global trace level switch");
            HeaderInit();
        }

        /// <summary>
        ///     TEST - Trace Enhancements Results
        /// </summary>
        /// <param name="message"></param>
        public static void Test(string message)
        {
            Trace.WriteLineIf(globalTraceSwitch.TraceInfo,
                string.Format("{0} TEST: {1}", DateTime.Now.ToString(), message));

        }

        /// <summary>
        ///     ERROR - Trace Errors
        /// </summary>
        /// <param name="message"></param>
        /// <param name="module"></param>
        public static void Error(string message, string module)
        {
            WriteEntry(message, "ERRR", module);
        }

        /// <summary>
        ///     RESOLVED - Trace Error Resolutions
        /// </summary>
        /// <param name="message"></param>
        /// <param name="module"></param>
        public static void Resolved(string message, string module)
        {
            WriteEntry(message, "ERFX", module);
        }

        /// <summary>
        ///     ERROR - Trace Errors Resolution Update
        /// </summary>
        /// <param name="message"></param>
        /// <param name="module"></param>
        public static void ErrorUpdate(string message, string module)
        {
            WriteEntry(message, "ERUP", module);
        }

        /// <summary>
        ///     USER - Trace User Actions
        /// </summary>
        /// <param name="message"></param>
        /// <param name="module"></param>
        public static void User(string message, string module)
        {
            WriteEntry(message, "USER", module);
        }

        /// <summary>
        ///     EXCEPTION - Trace Exceptions
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="module"></param>
        public static void Exception(Exception ex, string module)
        {
            try
            {
                var st = new StackTrace(ex, true);
                var line = st.GetFrame(st.FrameCount - 1).GetFileLineNumber();
                var method = st.GetFrame(st.FrameCount - 1).GetFileName();
                string ExcMessage = "";

                // Log Inner Exception if it exists
                if (ex.Message.Contains("See the inner exception for details"))
                {
                    try
                    {
                        ExcMessage = ex.InnerException.Message;
                    }
                    catch (Exception)
                    {
                        ExcMessage = ex.Message;
                    }
                }
                else
                {
                    ExcMessage = ex.Message;
                }

                WriteEntry(String.Format(ex.Message + " [File: {0} ] [Line: {1} ] + ", method, line), "EXCP", module);
            }
            catch (Exception exc)
            {// Failed to get Line Number
                WriteEntry(String.Format(exc.Message), "EXCP", module);
            }
        }

        /// <summary>
        ///     WARNING - Trace Warnings
        /// </summary>
        /// <param name="message"></param>
        /// <param name="module"></param>
        public static void Warning(string message, string module)
        {
            WriteEntry(message, "WARN", module);
        }

        /// <summary>
        ///     PROCESS - Trace Processes
        /// </summary>
        /// <param name="message"></param>
        /// <param name="module"></param>
        public static void Process(string message, string module)
        {
            WriteEntry(message, "PROC", module);
        }

        /// <summary>
        ///     INFO - Trace Information
        /// </summary>
        /// <param name="message"></param>
        /// <param name="module"></param>
        public static void Info(string message, string module)
        {
            WriteEntry(message, "INFO", module);
        }

        /// <summary>
        ///     CONFIG - Trace Application Configuration
        /// </summary>
        /// <param name="message"></param>
        /// <param name="module"></param>
        public static void Configuration(string message, string module)
        {
            WriteEntry(message, "CNFG", module);
        }

        /// <summary>
        ///     DEBUG - Traces Debug Points
        /// </summary>
        /// <param name="message"></param>
        /// <param name="module"></param>
        public static void Debug(string message, string module)
        {
            
            WriteEntry(message, "DBUG", module);
       
        }

        /// <summary>
        ///     LINEBREAK - Trace New Line
        /// </summary>
        /// <param name="lineBreak"></param>
        public static void LineBreak(string linebreak)
        {
            System.Diagnostics.Trace.WriteLine(linebreak);
        }

        /// <summary>
        ///     WRITEENTRY - Trace File Write
        /// </summary>
        /// <param name="message"></param>
        /// <param name="type"></param>
        /// <param name="module"></param>
        private static void WriteEntry(string message, string type, string module)
        {
            System.Diagnostics.Trace.WriteLine(
                    string.Format("| {0} \t| {1} \t| {2,-35} | {3}",
                                  DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                                  type,
                                  module,
                                  message));

            // Close and Flush the Trace
            System.Diagnostics.Trace.Flush();

        }

        /// <summary>
        ///     HEADERINIT - Trace Header Initialisation (Minimal)
        /// </summary>
        private static void HeaderInit_Min()
        {
            System.Diagnostics.Trace.WriteLine(
                    string.Format("\n-------------------------------------------------------------------------------------------------------------------------------------------------" +
                                  "\n|                                              {0} [{1}]                                             |\n" +
                                  "-------------------------------------------------------------------------------------------------------------------------------------------------\n" +
                                  "| TIMESTAMP  \t\t| TYPE \t| MODULE > MESSAGE",
                                  "SLS MASTER DATA IMPORT SERVICE",
                                  DateTime.Now.ToString("HH:mm:ss dd-MM-yyyy")
                                  ));

            // Close and Flush the Trace
            System.Diagnostics.Trace.Flush();
        }

        /// <summary>
        ///     HEADERINIT - Trace Header Initialisation (Detailed)
        /// </summary>
        public static void HeaderInit()
        {
            System.Diagnostics.Trace.WriteLine(
                    string.Format("\n-------------------------------------------------------------------------------------------------------------------------------------------------" +
                                  "\n|                                              {0} [{1}]                                             |\n" +
                                  "-------------------------------------------------------------------------------------------------------------------------------------------------\n" +
                                  "| {2} \t\t| {3} | {4,-35} | {5} ",
                                  "SLS SALT HASHING UTILITY",
                                  DateTime.Now.ToString("HH:mm:ss dd-MM-yyyy"),
                                  "EVENT TIMESTAMP",
                                  "EVENT",
                                  "PROGRAM LOCATION",
                                  "MESSAGE"
                                  ));

            // Close and Flush the Trace
            System.Diagnostics.Trace.Flush();


        }
    }
}
