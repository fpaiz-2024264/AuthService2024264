namespace AuthServiceIN6BV.Application.Exceptions;
 
 
public class BusinessException : System.Exception
{
    public string ErrorCodes {get;}
 
    public BusinessException(string errorCodes, string message) : base(message)
    {
        ErrorCodes = errorCodes;
    }
 
    public BusinessException(string errorCode, string message, System.Exception innerException)
        : base(message, innerException)
    {
        ErrorCodes = errorCode;
    }
}