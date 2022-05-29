namespace HospitalRepository.NHibernateDatabaseAccess.Mapping
{
    public class PaymentMap : ClassMap<Payment>
    {
        public PaymentMap()
        {
            Id(x => x.Id);
            Map(x => x.TimeOfPayment);
            Map(x => x.Amount);
            Map(x => x.IsAprove);
            Map(x => x.PayingFor);
            References(x => x.Patient);
            References(x => x.Hospital).Cascade.All();
        }
    }
}
