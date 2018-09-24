using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Temp.Reference_NowPlatform;

namespace Temp
{
    public partial class GetIncident : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Note: Please enable SOAP/REST services in your SNow dev instance table(s), Also,
            // Go to system web services --> properties -> enable the 3rd option from the bottom.(This property sets the elementFormDefault attribute of the embedded XML schema to the value of unqualified)
            ServiceNowSoapClient client = new ServiceNowSoapClient();
            client.ClientCredentials.UserName.UserName = "makhan8"; // makhan8 have SOAP role in SNow.
            client.ClientCredentials.UserName.Password = "Password1";

            insert newRecord = new insert();
            insertResponse insertResponse = new insertResponse(); 
            newRecord.first_name = "Jackson";
            newRecord.last_name = "Chris";
            newRecord.phone_number = "911-911-9999";
            //newRecord.number = "CUS3048232";
            try
            {
                insertResponse = client.insert(newRecord);
                TextBox1.Text = insertResponse.sys_id;

            }
            catch (Exception ex)
            {
                TextBox1.Text = ex.Message;
            }
            finally { client.Close(); }
        }
    }
}