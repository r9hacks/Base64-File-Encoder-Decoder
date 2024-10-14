using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Please provide a file name as an argument.");
            return;
        }

        string fileName = args[0];
        string directory = "files";

        // Ensure the directory exists
        if (!Directory.Exists(directory))
        {
            Directory.CreateDirectory(directory);
        }

        // Construct the full input file path
        string inputFilePath = Path.Combine(directory, fileName);

        // Ensure the input file exists in the "files" folder
        if (!File.Exists(inputFilePath))
        {
            Console.WriteLine($"The file '{inputFilePath}' was not found.");
            return;
        }

        string fileContent = File.ReadAllText(inputFilePath);
        string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(inputFilePath);
        string extension = Path.GetExtension(inputFilePath);

        // Check if the file is already Base64-encoded
        if (IsBase64String(fileContent))
        {
            // Decode the Base64 content and save the original file
            byte[] decodedBytes = Convert.FromBase64String(fileContent);
            string decodedFilePath = Path.Combine(directory, fileNameWithoutExtension + "_decoded" + extension);
            File.WriteAllBytes(decodedFilePath, decodedBytes);
            Console.WriteLine($"Decoded file saved as: {decodedFilePath}");
        }
        else
        {
            // Encode the file content to Base64
            byte[] fileBytes = File.ReadAllBytes(inputFilePath);
            string base64Content = Convert.ToBase64String(fileBytes);

            // Save the Base64 content to a new file in the 'output' folder with +base64.txt
            string base64FilePath = Path.Combine(directory, fileNameWithoutExtension + "+base64.txt");
            File.WriteAllText(base64FilePath, base64Content);
            Console.WriteLine($"Base64 file saved as: {base64FilePath}");
        }
    }

    static bool IsBase64String(string base64)
    {
        Span<byte> buffer = new Span<byte>(new byte[base64.Length]);
        return Convert.TryFromBase64String(base64, buffer, out _);
    }
}
