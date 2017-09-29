using NLog;
using System.Diagnostics;

namespace NLogSample
{
    public sealed class Log
    {
        private static readonly Log instance = new Log();
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private Log() {}

        public static Log Instance
        {
            get
            {
                return instance;
            }
        }

        /// <summary>
        /// エラーログを出力します。
        /// </summary>
        /// <param name="message">メッセージ</param>
        public void Error(string message)
        {
            var callerFrame = new StackFrame(1);
            var methodName = callerFrame.GetMethod().Name;
            var reflectedType = callerFrame.GetMethod().ReflectedType;

            var className = string.Empty;
            if (reflectedType != null)
                className = reflectedType.Name;

            Logger.Error(MakeMessage(className, methodName, message));
        }

        /// <summary>
        /// 警告ログを出力します。
        /// </summary>
        /// <param name="message">メッセージ</param>
        public void Warn(string message)
        {
            var callerFrame = new StackFrame(1);
            var methodName = callerFrame.GetMethod().Name;
            var reflectedType = callerFrame.GetMethod().ReflectedType;

            var className = string.Empty;
            if (reflectedType != null)
                className = reflectedType.Name;

            Logger.Warn(MakeMessage(className, methodName, message));
        }

        /// <summary>
        /// インフォメーションログを出力します。
        /// </summary>
        /// <param name="message">メッセージ</param>
        public void Info(string message)
        {
            var callerFrame = new StackFrame(1);
            var methodName = callerFrame.GetMethod().Name;
            var reflectedType = callerFrame.GetMethod().ReflectedType;

            var className = string.Empty;
            if (reflectedType != null)
                className = reflectedType.Name;

            Logger.Info(MakeMessage(className, methodName, message));
        }

        /// <summary>
        /// デバッグログを出力します。
        /// </summary>
        /// <param name="message">メッセージ</param>
        public void Debug(string message)
        {
            var callerFrame = new StackFrame(1);
            var methodName = callerFrame.GetMethod().Name;
            var reflectedType = callerFrame.GetMethod().ReflectedType;

            var className = string.Empty;
            if (reflectedType != null)
                className = reflectedType.Name;

            Logger.Debug(MakeMessage(className, methodName, message));
        }

        /// <summary>
        /// 出力文を作成します。
        /// </summary>
        /// <param name="message">メッセージ</param>
        private string MakeMessage(string className, string methodName, string message)
        {
            return $"{className}, {methodName}, {message}";
        }
    }
}
