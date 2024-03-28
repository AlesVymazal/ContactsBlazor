# ContactsBlazor
1. How to run the project
   * Clone the project and open the *ContactsBlazor.sln* file in Visual Studio 2022   
   * Build and run the project
   * Go to the right side menu and click on Register and create new account. You will be prompoted to apply database migartion. Click on the button and create new     account again (don't forget to click on *Click here to confirm your account*). If applying migration doesn't work stop the application and go to Package Manager in Visual Studio and run command Update-Database and then register new account.
   * Log in with the account you've created
   * Go to the right side menu and click Create new contact and test the appliacation
2. List of functions
   ### Home.razor
     * *FilterFunction* - filters the content of the table by selected filter property
     * *Delete* - deletes one item in table
   ### EditContact.razoe
     * *Save* - saves the changed contact into the database
   ### CreateContact.razor
     * *Save* - saves the newly created contact into the database
     * *CreateContacts* - creates several predefined contacts
   
   
  
   
