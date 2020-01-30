using System;
using System.IO;
using System.Runtime.Serialization;

public class Program
{
    public static void Main()
    {
        try
        {
            throw new UserAlreadyLoggedInException("User is logged in - no duplicate sessions allowed.");
        }
        catch (UserAlreadyLoggedInException specificEx)
        {
            Console.WriteLine(specificEx.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            // do any cleanup.
        }

        Console.ReadKey();
    }
}


public class UserAlreadyLoggedInException : Exception
{
    public UserAlreadyLoggedInException() { } //Default constructor made available if user wants throw this exception without message.
    public UserAlreadyLoggedInException(string message) : base(message) { }
    public UserAlreadyLoggedInException(string message, Exception InnerException) : base(message, InnerException) { }
    public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context) : base (info, context) { }

}

