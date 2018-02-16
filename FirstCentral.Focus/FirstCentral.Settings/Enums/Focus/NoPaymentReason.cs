using System.ComponentModel;

namespace FirstCentral.Settings.Enums.Focus
{
    public enum NoPaymentReason
    {
        [Description("None")]
        None = 0,      
        [Description("Administration Error")]
        AdministrationError = 1, 
        [Description("Outstanding balance")]
        OutstandingBalance = 2,
        [Description("Customer Deceased")]
        CustomerDeceased = 3,
        [Description("Refund")]
        Refund = 4,
        [Description("Unable to make payment")]
        UnableToMakePayment = 5,
        [Description("Unhappy to pay cancellation/fee’s")]
        UnhappyToPayCancellationFees = 6,
        [Description("Incorrect cancellation figure")]
        IncorrectCancellationFigure = 7,
        [Description("System Error")]
        SystemError = 8,
        [Description("Card Expired")]
        CardExpired = 9
    }
}
