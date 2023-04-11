using System;

namespace EgeYapiCore
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WS.CrmServiceClient client = new WS.CrmServiceClient();
                WS.Opp Lead = new WS.Opp();
                Lead.username = "emlaktasondakika";
                Lead.password = "egeyapi-@k9*";
                Lead.firstname = "dincer";
                Lead.lastname = "genc";
                Lead.ilgilendigiproje = "MODERNYAKA";
                Lead.mobile = "05497176001";
                Lead.email = "dincer@egeyapi.com";
                Lead.aciklama = "description";
                Lead.googleID = "";
                Lead.utmcampaign = "";
                Lead.utmsource = "";
                Lead.utmcontent = "";
                Lead.utmterm = "";
                Lead.utmmedium = "";
                Lead.emailizin = "Var";
                Lead.smsizin = "Var";
                Lead.cihazturu = "Desktop / Mobile";
                Lead.referrer = "";
                Lead.form = "wishne";
                Lead.formlink = "";
                Lead.browserlang = "tr-TR";
                Lead.kayittarihi = DateTime.Now; ;
                string sonuc = client.CreateOpportunity2Async(Lead).GetAwaiter().GetResult() ;
                Console.WriteLine(sonuc.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            Console.ReadLine();


        }
    }
}
