
namespace InstallmentRecordsApp;

public class UnacceptedInputException : Exception
{
   
    public UnacceptedInputException() 
    {
        
    }

    public UnacceptedInputException(string message) : base(message) 
    {
        
    }

    public UnacceptedInputException(string message, Exception inner) : base(message, inner) 
    { 

    }

    
}
