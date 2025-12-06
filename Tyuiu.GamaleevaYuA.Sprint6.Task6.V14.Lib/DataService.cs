using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GamaleevaYuA.Sprint6.Task6.V14.Lib
{
    public class DataService : ISprint6Task6V14
    {
        public string CollectTextFromFile(string path)
        {
            int len = 0;
            
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] newline = line.Split();
                    for (int i = 0; i< newline.Length; i++)
                    {
                        if (newline[i].Contains('z'))
                        {
                            len += 1;
                        }
                    }
                }
            }
            string[] resStr = new string[len];
            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] newline = line.Split();
                    for (int i = 0; i < newline.Length; i++)
                    {
                        if (newline[i].Contains('z'))
                        {
                            resStr[index++] = newline[i];
                        }
                    }
                }
            }
            return string.Join(" ", resStr);
        }
    }
}
