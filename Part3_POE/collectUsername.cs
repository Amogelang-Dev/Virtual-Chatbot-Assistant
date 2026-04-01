using System.Security.Cryptography.X509Certificates;

namespace Part3_POE
{
    public class collectUsername
    {
        //global variable declaration
        private string username = string.Empty;

        //method to return the username after being collected
        public string UsernameCollection()
        {
            //returning the username
            return username;

        }//end of code

        //assign username collected
        public void AssignUsername(string username) 
        {
            
            //assigning the username
            this.username = username;



        } //end of code



    }
}