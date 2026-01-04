namespace Modetour.B2C.Commons
{
    public class HttpResultGeneric<T>
    {
        public MessageCode messageCode { get; set; }
        public string message { get; set; }
        public T content { get; set; }
        public HttpResultGeneric()
        {

        }
        public HttpResultGeneric(MessageCode messageCode)
        {
            this.messageCode = messageCode;
        }
        public HttpResultGeneric(MessageCode messageCode, string message)
        {
            this.messageCode = messageCode;
            this.message = message;
        }
        public HttpResultGeneric(MessageCode messageCode, string message, T content)
        {
            this.messageCode = messageCode;
            this.message = message;
            this.content = content;
        }
    }

}
