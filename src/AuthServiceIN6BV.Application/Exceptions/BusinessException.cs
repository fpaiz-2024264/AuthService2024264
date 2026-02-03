namespace AuthServiceIN6BV.Application.Exceptions;
 
 
public class BusinessException : System.Exception
{
    public string ErrorCode {get;}
 
    public BusinessException(string errorCode, string message) : base(message)
    {
        ErrorCode = errorCode;
    }
 
    public BusinessException(string errorCode, string message, System.Exception innerException)
        : base(message, innerException)
    {
        ErrorCode = errorCode;
    }
}