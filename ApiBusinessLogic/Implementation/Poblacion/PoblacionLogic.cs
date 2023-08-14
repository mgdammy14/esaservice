using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using ApiBusinessLogic.Interfaces.Poblacion;
using ApiUnitOfWork.General;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ApiBusinessLogic.Implementation.Poblacion
{
    public class PoblacionLogic : IPoblacionLogic
    {
        private readonly IUnitOfWork _unitOfWork;

        public PoblacionLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public string File(int idEncuesta)
        {
            try
            {
                var result = Task.Run(async () => await GenerateAndUploadFileAsync(idEncuesta));
                return result.Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async Task<string> GenerateAndUploadFileAsync(int idEncuesta)
        {
            var poblacion = _unitOfWork.IQuery.GetPoblacionToFile(idEncuesta);

            string bucketName = "esa-s3-dev";
            string accessKey = "AKIA27Z4WFT3LGZQQ4WD";
            string secretKey = "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";
            RegionEndpoint region = RegionEndpoint.USEast1;

            var s3Config = new AmazonS3Config
            {
                RegionEndpoint = region,
                ForcePathStyle = true
            };

            using (var memoryStream = new MemoryStream())
            using (var streamWriter = new StreamWriter(memoryStream))
            using (var csv = new CsvWriter(streamWriter, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(poblacion);
                streamWriter.Flush();

                using (var s3Client = new AmazonS3Client(accessKey, secretKey, s3Config))
                {
                    memoryStream.Seek(0, SeekOrigin.Begin);

                    using (var sha256 = SHA256.Create())
                    {
                        byte[] hashBytes = sha256.ComputeHash(memoryStream);
                        string hashString = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();

                        string fileName = $"archivo_{idEncuesta}_{hashString}.csv";

                        var request = new PutObjectRequest
                        {
                            BucketName = bucketName,
                            Key = fileName,
                            InputStream = memoryStream
                        };

                        await s3Client.PutObjectAsync(request);

                        string s3Url = $"https://s3.amazonaws.com/{bucketName}/{fileName}";
                        return s3Url;
                    }
                }
            }
        }
    }
}
