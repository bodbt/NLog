namespace NLogSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Instance.Debug("Debug A");

            Log.Instance.Info("Info B");

            Log.Instance.Warn("Warning C");

            Log.Instance.Error("Error D");
        }
    }
}
