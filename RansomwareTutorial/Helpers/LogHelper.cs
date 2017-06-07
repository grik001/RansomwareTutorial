using RansomwareTutorial.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RansomwareTutorial.Helpers
{
    public static class LogHelper
    {
        public static List<LogData> Logs { get; private set; }

        public static void ResetLog()
        {
            Logs = new List<LogData>();
        }

        public static void AddLog(string message)
        {
            if (Logs == null)
                Logs = new List<LogData>();

            LogData log = new LogData() { EntryTime = DateTime.UtcNow, Message = message };
            Logs.Add(log);
        }

        public class LogData
        {
            public DateTime EntryTime { get; set; }
            public string Message { get; set; }
        }
    }
}
