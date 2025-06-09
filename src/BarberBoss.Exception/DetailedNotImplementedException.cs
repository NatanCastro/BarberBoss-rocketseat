using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace BarberBoss.Exception;

public class DetailedNotImplementedException(
    string? message = null,
    [CallerMemberName] string memberName = "",
    [CallerFilePath] string filePath = "",
    [CallerLineNumber] int lineNumber = 0)
    : NotImplementedException(FormatMessage(message, memberName, filePath, lineNumber))
{
    private static string FormatMessage(string? message, string memberName, string filePath, int lineNumber)
    {
        var className = GetClassName();
        return
            $"""
             [ERROR] NotImplementedException: {message ?? "Feature not implemented."}
                 at {className}.{memberName} (in {System.IO.Path.GetFileName(filePath)}:line {lineNumber})
             """;
    }

    private static string GetClassName()
    {
        var stackTrace = new StackTrace();
        for (var i = 2; i < stackTrace.FrameCount; i++) // skip internal frames
        {
            var frame = stackTrace.GetFrame(i);
            var method = frame?.GetMethod();
            if (method?.DeclaringType != typeof(DetailedNotImplementedException))
            {
                return method?.DeclaringType?.FullName ?? "UnknownClass";
            }
        }
        return "UnknownClass";
    }
}
