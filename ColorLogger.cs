using UnityEngine;

public static class ColorLogger
{
    /// <summary>
    /// Color your message
    /// </summary>
    /// <param name="message"></param>
    /// <param name="hexColor"></param>
    public static void Log(string message, string hexColor = "#FFFFFF")
    {
        Debug.Log($"<color={hexColor}>{message}</color>");
    }
    /// <summary>
    /// Color your message
    /// </summary>
    /// <param name="message"></param>
    /// <param name="Unity color"></param>
    public static void Log(string message, Color color)
    {
        Debug.Log($"<color={color}>{message}</color>");
    }
    /// <summary>
    /// Color your warning message
    /// </summary>
    /// <param name="message"></param>
    public static void LogWarning(string message)
    {
        Debug.Log($"<color=yellow>{message}</color>");
    }
    /// <summary>
    /// Color your error message
    /// </summary>
    /// <param name="message"></param>
    public static void LogError(string message)
    {
        Debug.Log($"<color=red>{message}</color>");
    }
    /// <summary>
    /// color message composed of multiple colored parts. 
    /// </summary>
    /// <param name="parts"></param>
    public static void LogParts(params (string text, string color)[] parts)
    {
        string formatted = "";
        foreach (var part in parts)
        {
            formatted += $"<color={part.color}>{part.text}</color>";
        }
        Debug.Log(formatted);
    }

    public static void LogParts(params (string text, Color color)[] parts)
    {
        string formatted = "";
        foreach (var part in parts)
        {
            string hex = ColorUtility.ToHtmlStringRGB(part.color);
            formatted += $"<color=#{hex}>{part.text}</color>";
        }
        Debug.Log(formatted);
    }
}