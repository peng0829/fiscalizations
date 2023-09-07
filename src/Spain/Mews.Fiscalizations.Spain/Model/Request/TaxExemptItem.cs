﻿namespace Mews.Fiscalizations.Spain.Model.Request;

public sealed class TaxExemptItem
{
    public TaxExemptItem(Amount amount, CauseOfExemption? cause = null)
    {
        Amount = Check.IsNotNull(amount, nameof(amount));
        Cause = cause.ToOption();
    }

    public Amount Amount { get; }

    public Option<CauseOfExemption> Cause { get; }
}