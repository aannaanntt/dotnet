//namespace DependencyInjection
//{
//   public interface IAccount
//    {
//        void PrintDetails();
//    }
    
//    class CA : IAccount
//    {
//        void IAccount.PrintDetails()
//        {
//            Console.WriteLine("Details of Current Account");
//        }
//    }
//    class SA : IAccount
//    {
//        void IAccount.PrintDetails()
//        {
//            Console.WriteLine("Details from Saving Account");
//        }
//    }

//    //class Account
//    //{
//    //    private IAccount account;
//    //    public Account(IAccount account)
//    //    {
//    //        this.account = account;
//    //    }

//    //    public void PrintAccounts() { 
//    //        account.PrintDetails();
//    //    }
            
        
//    //}

//    class Account
//    {
//        public IAccount account { get; set; }

//        public void PrintDetails() { 
//            account.PrintDetails();
//        }
//    }
    
//    class Program
//    {
//        static void Main(string[] args)
//        {
      
//            Account sa = new Account();
//            sa.account= new SA();
//            sa.PrintDetails();
            
//        }
//    }

//}