using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ToDoList
{
   
    class TextFileUtil
    {
        
        public static void writeToFile(List<ToDo>items)
        {

            try
            {
                
                

                //File created
               
                if (!File.Exists("ToDoList.txt"))
                {
                    File.Create("ToDoList.txt");
                }


                //Code Attribution,code in this class learnt and adpated from:
                //Author: VC SOIT
                //https://www.youtube.com/watch?v=fmAIJmaVBvw
                using (StreamWriter outputfile = new StreamWriter("ToDoList.txt")) 
                {
                    foreach (ToDo item in items)
                    {
                        outputfile.WriteLine(item.Description + "#" + item.Date + "#" + item.Priority);
                        
                    }
                    
                }
                
            }
            catch (Exception Ex)
            {
               
                
                System.Windows.Forms.MessageBox.Show(Ex.Message);
            }

        }
        
        public static void writeToFile(ToDo item)
        {
            try
            {
                using (StreamWriter outputfile = new StreamWriter("ToDoList.txt", true)) {
                    outputfile.WriteLine(item.Description + "#" + item.Date + "#" + item.Priority);
                }
            }catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


       public static List<ToDo> readFromFile()
        {
            List<ToDo> tempList = new List<ToDo>();
            string line;
            try
            {
                StreamReader reader = new StreamReader("ToDoList.txt");

                while ((line = reader.ReadLine()) != null)
                {
                    string[] lineParts = line.Split('#');
                    string description = lineParts[0];
                    string priority = lineParts[2];
                    string date = lineParts[1];
                    string[] dateParts = date.Split('/');
                    int year = int.Parse(dateParts[0]);
                    int month = int.Parse(dateParts[1]);
                    int day = Convert.ToInt32(dateParts[2].Substring(0, 2));
                    DateTime d = new DateTime(year, month, day);
                    ToDo t = new ToDo(description, d, priority);
                    tempList.Add(t);
                }


                reader.Close();

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }

            return (tempList);
        }

        }
    }

