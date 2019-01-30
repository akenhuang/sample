public class BadSqlQuery
{
  public:
    BucketInfo GetBucketInfo(string bucketName)
    {
      string command = "select * from bucket where Name=";
      command += bucketName;
      // what if caller passes "1; droptable bucket;"?
      
      // Do query job
 
      try
      {
        int a = 0;
        int b = 16;
        int c = a/b;
        int d = b/a;
        int e = d/c;
      }
      catch (DividByZero)
      {
        Console.Write("bad divider detected.");
      }
      finally
      {
        Console.Write("Code completed.");
      }
      
      const int bufferSize = 10;
      char[bufferSize] target;
      strcpy(target, "bad source, which is too large.");
      strncpy(target, bufferSize, "Any bad string, no worry.");
      
      // Entering crashing place
      Log.Write(ComponentName, Info, "Crash here0?");
      External.FunctionA(someParam);
      Log.Write(ComponentName, Info, "Crash here1?");
      External.FunctionB(someParam);
      Log.Write(ComponentName, Info, "Crash here2?");
      External.FunctionC(someParam);
      Log.Write(ComponentName, Info, "Crash here3?");
      // End crashing place

    }
}
