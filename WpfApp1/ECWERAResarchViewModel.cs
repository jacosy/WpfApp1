using System.Collections.Generic;

namespace WpfApp1
{
    public class ECWERAResarchViewModel
    {
        public ECWERAResarchViewModel()
        {
            MailboxResponseList = new List<MailboxIDModel>
            {
                new MailboxIDModel{ MailboxID="A11111", TaxID="T1111111"},
                new MailboxIDModel{ MailboxID="A2222", TaxID="T22222"},
                new MailboxIDModel{ MailboxID="A33333", TaxID="T3333"}
            };
        }

        public string SearchMailboxId { get; set; }
        public List<string> SearchMailboxIdList { get; set; }
        public string SearchTaxId { get; set; }

        public List<MailboxIDModel> MailboxResponseList { get; set; }
    }
}