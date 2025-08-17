using System;
using System.IO;

using System;
using System.IO;

namespace Basic
{
    public class Exercise29
    {
        public static long GetFileSize(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"File not found: {filePath}");

            return new FileInfo(filePath).Length;
        }

        public static string GetFileSizeResult(string filePath)
        {
            try
            {
                long size = GetFileSize(filePath);
                return $"Size of a file: {size}";
            }
            catch (FileNotFoundException ex)
            {
                return ex.Message;
            }
        }
    }
}