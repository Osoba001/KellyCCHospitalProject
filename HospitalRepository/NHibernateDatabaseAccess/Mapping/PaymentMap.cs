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
            References(x => x.Patient);
        }
    }
}
