﻿namespace Mews.Fiscalizations.Basque.Model;

public sealed class InvoiceData
{
    private InvoiceData(
        String1To250 description,
        IEnumerable<InvoiceItem> items,
        decimal totalAmount,
        IEnumerable<TaxMode> taxModes,
        decimal? supportWithheldAmount = null,
        decimal? tax = null,
        DateTime? transactionDate = null)
    {
        Description = description;
        Items = items;
        TotalAmount = totalAmount;
        TaxModes = taxModes;
        SupportWithheldAmount = supportWithheldAmount.ToOption();
        Tax = tax.ToOption();
        TransactionDate = transactionDate.ToOption();
    }

    public String1To250 Description { get; }

    public IEnumerable<InvoiceItem> Items { get; }

    public decimal TotalAmount { get; }

    public IEnumerable<TaxMode> TaxModes { get; }

    public Option<decimal> SupportWithheldAmount { get; }

    public Option<decimal> Tax { get; }

    public Option<DateTime> TransactionDate { get; }

    public static Try<InvoiceData, IReadOnlyList<Error>> Create(
        String1To250 description,
        IEnumerable<InvoiceItem> items,
        decimal totalAmount,
        IEnumerable<TaxMode> taxModes,
        decimal? supportWithheldAmount = null,
        decimal? tax = null,
        DateTime? transactionDate = null)
    {
        return Try.Aggregate(
            ObjectValidations.NotNull(description),
            items.ToList().ToTry(i => i.Any() && i.Count <= 1000, _ => new Error($"{nameof(items)} count must be in range [1, 1000].")),
            taxModes.ToTry(t => t.NonEmpty(), _ => new Error($"{nameof(taxModes)} shouldn't be empty.")),
            (d, i, t) => new InvoiceData(d, i, totalAmount, t, supportWithheldAmount, tax, transactionDate)
        );
    }
}