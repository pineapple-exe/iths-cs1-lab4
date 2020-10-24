using System;
using System.IO;

namespace VocabularyTest
{
    public static class WordListUtils
    {
        public static string GeneratePath(string fileName = null)
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "VocabularyTest");
            if (fileName != null)
            {
                return Path.Combine(folderPath, fileName + ".dat");
            }
            return folderPath;
        }

        public static void FolderCheck()
        {
            string wordListFolder = GeneratePath();
            if (!Directory.Exists(wordListFolder))
            {
                Directory.CreateDirectory(wordListFolder);
            }
        }
    }
}
