namespace FileDuplicator
{
    class ClFileDuplicator
    {
        public string UprCaseConvert(ref string inTxt)
        {
            string outTxt;

            if (inTxt is not null)
            {
                outTxt = inTxt.ToUpper();
            }
            else
            {
                outTxt = "### Content was NULL ###";
            }

            return outTxt;
        }

        public static void Main(String[] args)
        {
            string inPath = "AppFiles\\InputFiles\\FileIn.txt";
            string outPath = "AppFiles\\OutputFiles\\FileOut.txt";

            ClFileDuplicator clFileDuplicator = new();

            try
            {
                if (File.Exists(inPath))
                {
                    string fileTxt = File.ReadAllText(inPath);
                    string fileOutTxt = clFileDuplicator.UprCaseConvert(ref fileTxt);
                        
                    File.WriteAllText(outPath, fileOutTxt);
                    Console.WriteLine("Message : Requested process complete");
                }
                else
                {
                    Console.WriteLine("Error : File does not exist");
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }
    }
}