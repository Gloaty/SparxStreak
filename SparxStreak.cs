using System;
using System.Threading;
using System.Collections.Generic; 

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Welcome to SparxStreak!");
		Console.WriteLine("This is an application to help with Sparx Maths. ");
		Console.WriteLine("This application has 2 modes; one with a calculator, one without. ");
		Console.WriteLine("Please press 1 for calculator mode, and 2 for non-calculator mode. ");
		string calcMode = Console.ReadLine();
		Console.Clear();
		switch (calcMode)
		{
		case "1":
			CalculatorMode();
			break;
		case "2":
			nonCalculatorMode();
			break;
		default:
		    errorHandler();
		    break;
		}   
	}
	public static void CalculatorMode() {
		Console.WriteLine("Calculator Mode Selected");
		Console.WriteLine("Loading...");
		Thread.Sleep(2000);
		Console.Clear();
		bookCodeHandler.bookCodeInitialise();
	}
	public static void nonCalculatorMode() {
		Console.WriteLine("Non-Calculator Mode Selected");
		Console.WriteLine("Loading...");
		Thread.Sleep(2000);
		Console.Clear();
	}
	public static class bookCodeHandler {
	    public static void bookCodeInitialise() {
        	int bookCodeSecondaryNumberInit = 0;
        	Console.WriteLine("Please Enter the BookCode's Letter. ");
        	string bookCodeLetterInit = Console.ReadLine();
        	Console.Clear();
        	Console.WriteLine("Please enter the BookCode's number. ");
        	int bookCodeNumberInit = Convert.ToInt32(Console.ReadLine());
        	Console.Clear();
        	if ((bookCodeNumberInit % 10) == 0) {
            	bookCodeNumberInit = 0;
       	    	bookCodeSecondaryNumberInit++;
        	}
        	bookCodeNumberInit.ToString();
        	string bookCode = bookCodeLetterInit + bookCodeNumberInit + bookCodeSecondaryNumberInit;
        	Console.WriteLine(bookCode);
        	Console.WriteLine("Is this your Book Code? (Y/N)");
        	string bookCodeConfirmation = Console.ReadLine().ToUpper();
        	switch (bookCodeConfirmation) {
            	case "Y":
                	Console.WriteLine("BookCode Confirmed. Initializing Calculator...");
                	break;
            	case "N":
            		Console.WriteLine("Initiating BookCode Override...");
            		Thread.Sleep(1000);
            		Console.Clear();
            		bookCodeOverride(bookCode, bookCodeConfirmation);
            		break;
            	default:
            		Console.WriteLine("Input not Recognized. Please Re-enter your BookCode");
            		bookCodeInitialise();
            		break;
            }
	    }
        public static void bookCodeOverride(string bookCode, string bookCodeConfirmation) {
    	Console.WriteLine("Please manually enter your BookCode. The letter MUST be Capital. ");
    	bookCode = Console.ReadLine();
    	Console.WriteLine(bookCode);
    	Console.WriteLine("Is this your BookCode? (Y/N)");
    	bookCodeConfirmation = Console.ReadLine().ToUpper();
    	switch (bookCodeConfirmation) {
        	case "N":
            	bookCodeOverride(bookCode, bookCodeConfirmation);
            	break;
    	    }
        }
    }
    public static void errorHandler() {
        Console.WriteLine("An Error has occurred!");
        Console.WriteLine("Press any key to close application...");
        Console.ReadKey();
    }
}