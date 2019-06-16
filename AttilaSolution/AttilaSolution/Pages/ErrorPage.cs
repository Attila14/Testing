using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttilaSolution.Pages
{
    /*   @author
     *    Attila Molnar 16 June 2019
     * 
     */
    class ErrorPage
    {
        private ErrorPageActController act;
        private ErrorPageVerifyController verify;

        public ErrorPageActController acting()
        {
            return act;
        }

        public ErrorPageVerifyController verifyPage()
        {
            return verify;
        }

        // Hide the constructor of ErrorPage => you cannot instantiate it without parameters
        private ErrorPage() { }

        private ErrorPage(ErrorPageActController acting, ErrorPageVerifyController verifyPage)
        {
            this.act = acting;
            this.verify = verifyPage;
        }

        public static ErrorPage getFormPage() { return new ErrorPage(new ErrorPageActController(), new ErrorPageVerifyController()); }
    }
}