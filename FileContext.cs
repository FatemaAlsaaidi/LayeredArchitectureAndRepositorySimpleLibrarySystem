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

        // Load data from a file and return as a List<T>
        public static List<T> LoadDataFromFile<T>(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"File not found: {filePath}. Returning empty list.");
                    return new List<T>();
                }

                string jsonData = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<T>>(jsonData) ?? new List<T>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading data: {ex.Message}");
                return new List<T>();
            }
        }





    }

}
