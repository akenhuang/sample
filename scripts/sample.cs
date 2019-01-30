public class BadSqlQuery
{
  public:
    BucketInfo GetBucketInfo(string bucketName)
    {
      string command = "select * from bucket where Name=";
      command += bucketName;
      // Do query job
    }
}
