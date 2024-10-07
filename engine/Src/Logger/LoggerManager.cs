using System.Runtime.InteropServices;
#if web
using System;
using System.Runtime.InteropServices.JavaScript;
#endif

namespace Wind.Logging {

  public static class WasmInterop {
    [DllImport("mymath", EntryPoint = "add")]
    public static extern int Add(int a, int b);
  }

  public partial class WindWasmLogger {
#if web
    [JSExport]
    internal static string PoweredBy() {
      try {
        var text = $"Powered by wind on {GetHRef()}";
        Console.WriteLine(text);
        Console.WriteLine(WasmInterop.Add(1, 2));
        return text;
      } catch (Exception ex) {
        Console.WriteLine($"Error calling WASM function: {ex.Message}");
        Console.WriteLine($"Stack trace: {ex.StackTrace}");
        return "Error";
      }

    }

    [JSImport("window.location.href", "main.js")]
    internal static partial string GetHRef();
#endif
  }

  public class Logger(string loggerName, LoggerManager loggerManager) {
    public void Error(string message) {
      Message("Error", message);
    }

    public void Info(string message) {
      Message("Info", message);
    }

    public void Warn(string message) {
      Message("Warn", message);
    }

    public void Debug(string message) {
      Message("Debug", message);
    }

    private void Message(string level, string message) {
      _loggerManager.Message(_loggerName, level, message);
    }

    private LoggerManager _loggerManager = loggerManager;
    private string _loggerName = loggerName;
  };

  public class LoggerManager {
    public void Message(string env, string level, string message) {
      Console.WriteLine($"({env}) [{level}] {message}");
    }
  }
}
