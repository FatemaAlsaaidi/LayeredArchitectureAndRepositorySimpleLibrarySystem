using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LayeredArchitectureAndRepositorySimpleLibrarySystem
{
    class FileContext
    {
        // File paths for storing data
        public static string FileBookPath = "Books.json";
        public static string FileMembersPath = "Members.json";
        public static string FileBorrowRecordPath = "BorrowRecord.json";

        // Save data to a file in JSON format
        public static void SaveDataToFile<T>(List<T> data, string filePath)
        {
            try
            {
                string jsonData = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, jsonData);
                Console.WriteLine($"Data saved successfully to {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving data: {ex.Message}");
            }
        }

       


    }

}
