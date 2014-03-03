Features
-----------
This program implements a parking meter user interface with the following features:

* Language selection (English and French, the Canadian national languages)
* Users can purchase tickets for a chosen number of minutes (Minimum = 15 minutes, maximum = 3 hours)
	* Tickets can be purchased using coins, debit, or credit
* Users can return their tickets and get refunds for unused time
	* Refunds are given in coins only at this point
* Ticket information is displayed in a pop-up dialog as it would appear on a printed ticket
* Users can change purchasing and refund options until there is a monetary transfer.

Instructions
-------------
This is a simple program with linear control flow. Instructions required for individual screens in the user interface are included
on screen or in dialog boxes (for hardware related instructions).

Design Notes
--------------
* This program was writen using Microsoft Visual C# 2010 Express. The main project file is TheParkingMeter.sln
* Pop-up dialogs are used to indicate actions performed by the hardware. They provide a brief description of what a user would
  see if they were using this program as part of a parking meter.
* The French language option was not implemented due to time constraints. This option would affect the language of text in the
  user interface. Language text would be stored in a public class and a flag is set when a language is chosen. The text read into the
  program from the language class would depend on this language flag. Program flow is the same regardless of language.
* In the payment screen for coins, each type of coin is represented as a button. This is for simulation purposes only. On the parking
  meter, they would be static images.
* The images used for coins are not ideal, but they were chosen due to time constraints. In the final product, coin images would be
  replaced with illustrations of Canadian coins.
* When a transaction is completed, the program returns to the Language Selection screen.
* Ticket refunds are available in cash only - options for refund on credit or debit are potential security hazards.

Important Notes
---------------

* The program assumes a fixed rate of $0.50 per minute
* Pop-up dialog boxes are NOT part of the user interface - they are meant to simulate actions performed by the
  parking meter hardware. To view the user interface that is paired with the dialog box, drag the dialog boxes away from 
  the program window.
* If the "Buy Ticket" option has been used previously in a program session, the "Refund Ticket" option will use the information
  stored from the ticket creation. The program can store information from one ticket.
* If the "Buy Ticket" option has not been used in this program session, the program will use the
  following default values:
	* Purchase time and date = current time and date
	* Ticket expires 30 minutes from the current time and date
