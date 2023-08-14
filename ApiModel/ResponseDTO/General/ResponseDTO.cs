using System;
namespace ApiModel.ResponseDTO.General
{
    public class ResponseDTO
    {
        public string status { get; set; }
        public string description { get; set; }
        public object detail { get; set; }

        public ResponseDTO Success(ResponseDTO obj, object objModel)
        {
            obj.description = "Transaction Sucessfully";
            obj.status = "OK";
            obj.detail = objModel;
            return obj;
        }

        public ResponseDTO Failed(ResponseDTO obj, Exception e)
        {
            obj.description = e.Message;
            obj.status = "NOK";
            return obj;
        }
    }
}
