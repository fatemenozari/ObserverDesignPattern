namespace observer_design_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var company = new Company();
            var sms = new SMS("fateme");
            company.Attach(sms);


            var email = new Email("faezeh");
            company.Attach(email);

            company.Lottery(" Hello participants , The lottery was done (: ");
        }
    }
}
