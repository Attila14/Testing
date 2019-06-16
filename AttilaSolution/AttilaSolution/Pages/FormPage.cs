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
    class FormPage
    {
        private FormPageActController act;
        private FormPageVerifyController verify;

        public FormPageActController acting()
        {
            return act;
        }

        public FormPageVerifyController verifyPage()
        {
            return verify;
        }

        // Hide the constructor of FormPage => you cannot instantiate it without parameters
        private FormPage() { }

        private FormPage(FormPageActController acting, FormPageVerifyController verifyPage)
        {
            this.act = acting;
            this.verify = verifyPage;
        }

        public static FormPage getFormPage() { return new FormPage(new FormPageActController(), new FormPageVerifyController()); }
    }
}
