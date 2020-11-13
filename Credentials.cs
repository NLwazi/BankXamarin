namespace Banking
{
    public class Credentials
    {
        public string UserNname { get; set; }
        public string Password { get; set;}

       
        public Credentials(string UserName, string Password) 
        
        {
            this.UserNname = UserNname;
            this.Password = Password;
        
        }
    }

}