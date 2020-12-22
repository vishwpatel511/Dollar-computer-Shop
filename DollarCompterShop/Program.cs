using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using DollarComputerShop;

namespace DollarCompterShop
{
   public class Program
   {
       public static StartForm startform;
       public static AboutBox about;
       public static DisplayProductForm displayproductform;
       public static Dictionary<FormEnumClass, Form> formDictionary;
       public static ProductinfoStore productinfoStore;
       

       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            startform = new StartForm();
            about = new AboutBox();
            productinfoStore =new ProductinfoStore();
            displayproductform = new DisplayProductForm();
            formDictionary = new Dictionary<FormEnumClass, Form>();
            formDictionary.Add(FormEnumClass.START_FORM, new StartForm());
            formDictionary.Add(FormEnumClass.NEW_ORDER_FORM, new NewOrderForm());
            formDictionary.Add(FormEnumClass.DISPLAY_PRODUCT_INFO_FORM, new DisplayProductForm());
            formDictionary.Add(FormEnumClass.CHECKOUT_FORM, new CheckoutScreen());
            

            Application.Run(new SplashForm());
        }
    }
}

