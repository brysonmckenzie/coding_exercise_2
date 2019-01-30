using System;
using System.IO;
using System.Xml.Linq;
using System.Linq;


namespace Runbeck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Runbeck Election Services");


            Console.WriteLine("Start File Access...");

            Console.Write("Where is the file located?" + "(ex: /Users/brysmck/Projects/Runbeck/Runbeck/)   :");

            string location = Console.ReadLine();

            Console.Write("Is the file format CSV or TSV?");
            string file_format = Console.ReadLine().ToUpper();

            Console.Write("How many fields should each record contain?");
            string col = Console.ReadLine();

            int num = Convert.ToInt32(col);
            string[] arr = new string[num];


            Console.WriteLine("File Complete");
            ///Test
            //Console.WriteLine(num);
            for (int i = 0; i < num; i++)
            {
            }


            if (file_format == "CSV")
            {
                //var filePath = location;
                //var csvFile = from file in Directory.EnumerateFiles(filePath, "*.csv", SearchOption.TopDirectoryOnly)
                //from line in File.ReadLines(file)
                //Console.WriteLine(line)


                //foreach (var currentFile in csvFile)
                //{
                //    Console.WriteLine(currentFile);
                //}


                //end_format = "csv";
                //file_format = "info.cvs";



                Console.WriteLine(location);

                var file_path = location + file_format.ToLower();

                var x_file = (File.Exists(file_path.ToString()) ? true : false);

                // Console.WriteLine(x_file);



                if (x_file == true)
                {



                    if (file_format == "CSV")
                    {

                        using (StreamWriter writer = new StreamWriter(file_path.ToString()))
                        {
                            string delimiter_t = ",";

                            using (StreamWriter writer1 = new StreamWriter(file_path.ToString()))
                            {
                                writer1.WriteLine("First" + delimiter_t + "Middle" + delimiter_t + "Last");

                                writer1.WriteLine("Jane" + delimiter_t + "Taylor" + delimiter_t + "Doe");

                                writer1.WriteLine("Jane" + delimiter_t + "Taylor" + delimiter_t + "Doe");

                                writer1.WriteLine("Chris" + delimiter_t + "" + delimiter_t + "Lee");
                                writer1.WriteLine("Jode" + delimiter_t + "" + delimiter_t + "Morro");


                            }






                        }


                    }
                    else if (file_format == "TSV")


                    //File Path I used while creating this application on .NET Core mac osx        
                    // ------>>    "/Users/brysmck/Projects/Runbeck/Runbeck/"
                    //Console.WriteLine(location);
                    //var file_path = location + file_format;
                    //var x_file = (File.Exists(file_path.ToString()) ? true : false);
                    // Console.WriteLine(x_file);
                    //if (x_file != true)
                    {

                        string delimiter_t = "\t";

                        using (StreamWriter writer = new StreamWriter(file_path.ToString()))
                        {
                            writer.WriteLine("First" + delimiter_t + "Middle" + delimiter_t + "Last");

                            writer.WriteLine("Jane" + delimiter_t + "Taylor" + delimiter_t + "Doe");

                            writer.WriteLine("Jane" + delimiter_t + "Taylor" + delimiter_t + "Doe");

                            writer.WriteLine("Chris" + delimiter_t + "" + delimiter_t + "Lee");
                            writer.WriteLine("Jode" + delimiter_t + "" + delimiter_t + "Morro");


                        }

                    }
                  
                    Console.WriteLine("File Complete");
                }
            }
        }

    }

}

//Expect to test and improve alot more with existing concepts. I will be working on a better version but my ideals are inline.