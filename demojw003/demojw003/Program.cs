using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.S3;
using Amazon.S3.Transfer;

namespace demojw003
{
    class Program
    {
        static string bucketName = "file.jydemohw003.com";
        static string folderName = "ImageFiles";
        static string keyName = "sample2.png";
        static string filePath = @"C:\amazon_s3\Images\sample2.png";
        

        static IAmazonS3 client;

        static void Main(string[] args)
        {
            using (client= new AmazonS3Client(Amazon.RegionEndpoint.USWest2))
            {
                SaveImage();
            }
        }
        static void SaveImage()
        {
            try
            {
                TransferUtility fileTransferUtility = new TransferUtility(new AmazonS3Client(Amazon.RegionEndpoint.USWest2));
                TransferUtilityUploadRequest request = new TransferUtilityUploadRequest()
                {
                    BucketName = string.Format(@"{0}/{1}", bucketName, folderName), Key = keyName, FilePath = filePath,
                };
                fileTransferUtility.Upload(request);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
