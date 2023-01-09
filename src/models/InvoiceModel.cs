/***
 * Lockstep Platform SDK for C#
 *
 * (c) 2021-2023 Lockstep, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     Lockstep Network <support@lockstep.io>
 * @copyright  2021-2023 Lockstep, Inc.
 * @link       https://github.com/Lockstep-Network/lockstep-sdk-csharp
 */



#pragma warning disable CS8618

using System;

namespace LockstepSDK.Models
{

    /// <summary>
    /// An Invoice represents a bill sent from one company to another.  The creator of the invoice is identified
    /// by the `CompanyId` field, and the recipient of the invoice is identified by the `CustomerId` field.  Most
    /// invoices are uniquely identified both by a Lockstep Platform ID number and a customer ERP &quot;key&quot; that was
    /// generated by the system that originated the invoice.  Invoices have a total amount and a due date, and when
    /// some payments have been made on the Invoice the `TotalAmount` and the `OutstandingBalanceAmount` may be
    /// different.
    /// </summary>
    public class InvoiceModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        ///
        /// For the ID of this record in its originating financial system, see `ErpKey`.
        /// </summary>
        public Guid? InvoiceId { get; set; }

        /// <summary>
        /// The ID number of the company that created this invoice.
        /// </summary>
        public Guid? CompanyId { get; set; }

        /// <summary>
        /// The ID number of the counterparty for the invoice, for example, a customer or vendor.
        /// </summary>
        public Guid? CustomerId { get; set; }

        /// <summary>
        /// The unique ID of this record as it was known in its originating financial system.
        ///
        /// If this company record was imported from a financial system, it will have the value `ErpKey`
        /// set to the original primary key number of the record as it was known in the originating financial
        /// system.  If this record was not imported, this value will be `null`.
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
        public string ErpKey { get; set; }

        /// <summary>
        /// The &quot;Purchase Order Code&quot; is a code that is sometimes used by companies to refer to the original PO
        /// that was sent that caused this invoice to be written.  If a customer sends a purchase order to a vendor,
        /// the vendor can then create an invoice and refer back to the originating purchase order using this field.
        /// </summary>
        public string PurchaseOrderCode { get; set; }

        /// <summary>
        /// An additional reference code that is sometimes used to identify this invoice.
        /// The meaning of this field is specific to the ERP or accounting system used by the user.
        /// </summary>
        public string ReferenceCode { get; set; }

        /// <summary>
        /// A code identifying the salesperson responsible for writing this quote, invoice, or order.
        /// </summary>
        public string SalespersonCode { get; set; }

        /// <summary>
        /// A name identifying the salesperson responsible for writing this quote, invoice, or order.
        /// </summary>
        public string SalespersonName { get; set; }

        /// <summary>
        /// A code identifying the type of this invoice.
        ///
        /// Recognized Invoice types are:
        /// * `AR Invoice` - Represents an invoice sent by Company to the Customer
        /// * `AP Invoice` - Represents an invoice sent by Vendor to the Company
        /// * `AR Credit Memo` - Represents a credit memo generated by Company given to Customer
        /// * `AP Credit Memo` - Represents a credit memo generated by Vendor given to Company
        /// </summary>
        public string InvoiceTypeCode { get; set; }

        /// <summary>
        /// A code identifying the status of this invoice.
        ///
        /// Recognized Invoice status codes are:
        /// * `Open` - Represents an invoice that is considered open and needs more work to complete
        /// * `Closed` - Represents an invoice that is considered closed and resolved
        /// </summary>
        public string InvoiceStatusCode { get; set; }

        /// <summary>
        /// A code identifying the terms given to the purchaser.  This field is imported directly from the originating
        /// financial system and does not follow a specified format.
        /// </summary>
        public string TermsCode { get; set; }

        /// <summary>
        /// If the customer negotiated any special terms different from the standard terms above, describe them here.
        /// </summary>
        public string SpecialTerms { get; set; }

        /// <summary>
        /// The three-character ISO 4217 currency code used for this invoice.
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// The total value of this invoice, inclusive of all taxes and line items.
        /// </summary>
        public decimal? TotalAmount { get; set; }

        /// <summary>
        /// The total sales (or transactional) tax calculated for this invoice.
        /// </summary>
        public decimal? SalesTaxAmount { get; set; }

        /// <summary>
        /// The total discounts given by the seller to the buyer on this invoice.
        /// </summary>
        public decimal? DiscountAmount { get; set; }

        /// <summary>
        /// The remaining balance value of this invoice.
        /// </summary>
        public decimal? OutstandingBalanceAmount { get; set; }

        /// <summary>
        /// The reporting date for this invoice.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string InvoiceDate { get; set; }

        /// <summary>
        /// The date when discounts were adjusted for this invoice.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string DiscountDate { get; set; }

        /// <summary>
        /// The date when this invoice posted to the company&#39;s general ledger.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string PostedDate { get; set; }

        /// <summary>
        /// The date when the invoice was closed and finalized after completion of all payments and delivery of all products and
        /// services.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string InvoiceClosedDate { get; set; }

        /// <summary>
        /// The date when the remaining outstanding balance is due.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string PaymentDueDate { get; set; }

        /// <summary>
        /// The date and time when this record was imported from the user&#39;s ERP or accounting system.
        /// </summary>
        public DateTime? ImportedDate { get; set; }

        /// <summary>
        /// The ID number of the invoice&#39;s origination address
        /// </summary>
        public Guid? PrimaryOriginAddressId { get; set; }

        /// <summary>
        /// The ID number of the invoice&#39;s bill-to address
        /// </summary>
        public Guid? PrimaryBillToAddressId { get; set; }

        /// <summary>
        /// The ID number of the invoice&#39;s ship-to address
        /// </summary>
        public Guid? PrimaryShipToAddressId { get; set; }

        /// <summary>
        /// The date on which this invoice record was created.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The ID number of the user who created this invoice.
        /// </summary>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// The date on which this invoice record was last modified.
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The ID number of the user who most recently modified this invoice.
        /// </summary>
        public Guid? ModifiedUserId { get; set; }

        /// <summary>
        /// The AppEnrollmentId of the application that imported this record.  For accounts
        /// with more than one financial system connected, this field identifies the originating
        /// financial system that produced this record.  This value is null if this record
        /// was not loaded from an external ERP or financial system.
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }

        /// <summary>
        /// Is the invoice voided?
        /// </summary>
        public bool? IsVoided { get; set; }

        /// <summary>
        /// Is the invoice in dispute?
        /// </summary>
        public bool? InDispute { get; set; }

        /// <summary>
        /// Should the invoice be excluded from aging calculations?
        /// </summary>
        public bool? ExcludeFromAging { get; set; }

        /// <summary>
        /// Indicates the preferred delivery method for this invoice. Examples include Print, Email, Fax
        /// </summary>
        public string PreferredDeliveryMethod { get; set; }

        /// <summary>
        /// The Currency Rate used to get from the account&#39;s base currency to the invoice amount.
        /// </summary>
        public decimal? CurrencyRate { get; set; }

        /// <summary>
        /// All addresses connected to this invoice.
        /// To retrieve this collection, specify `Addresses` in the &quot;Include&quot; parameter for your query.
        /// </summary>
        public InvoiceAddressModel[] Addresses { get; set; }

        /// <summary>
        /// All lines attached to this invoice.
        /// To retrieve this collection, specify `Lines` in the &quot;Include&quot; parameter for your query.
        /// </summary>
        public InvoiceLineModel[] Lines { get; set; }

        /// <summary>
        /// All payments attached to this invoice, the amount of the payment applied to this Invoice, and the date the Payment was applied.
        /// To retrieve this collection, specify `Payments` in the &quot;Include&quot; parameter for your query.
        /// </summary>
        public InvoicePaymentDetailModel[] Payments { get; set; }

        /// <summary>
        /// A collection of notes linked to this record.  To retrieve this collection, specify `Notes` in the
        /// `include` parameter when retrieving data.
        ///
        /// To create a note, use the [Create Note](https://developer.lockstep.io/reference/post_api-v1-notes)
        /// endpoint with the `TableKey` to `Invoice` and the `ObjectKey` set to the `InvoiceId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public NoteModel[] Notes { get; set; }

        /// <summary>
        /// A collection of attachments linked to this record.  To retrieve this collection, specify `Attachments` in
        /// the `include` parameter when retrieving data.
        ///
        /// To create an attachment, use the [Upload Attachment](https://developer.lockstep.io/reference/post_api-v1-attachments)
        /// endpoint with the `TableKey` to `Invoice` and the `ObjectKey` set to the `InvoiceId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public AttachmentModel[] Attachments { get; set; }

        /// <summary>
        /// The Company associated to this invoice.
        /// To retrieve this item, specify `Company` in the &quot;Include&quot; parameter for your query.
        /// </summary>
        public CompanyModel Company { get; set; }

        /// <summary>
        /// The Customer associated to the invoice customer
        /// To retrieve this item, specify `Customer` in the &quot;Include&quot; parameter for your query.
        /// </summary>
        public CompanyModel Customer { get; set; }

        /// <summary>
        /// The Contact associated to the invoice customer
        /// To retrieve this item, specify `Customer` in the &quot;Include&quot; parameter for your query.
        /// </summary>
        public ContactModel CustomerPrimaryContact { get; set; }

        /// <summary>
        /// The credit memos associated to this invoice.
        /// To retrieve this item, specify `CreditMemos` in the &quot;Include&quot; parameter for your query.
        /// </summary>
        public CreditMemoInvoiceModel[] CreditMemos { get; set; }

        /// <summary>
        /// A collection of custom fields linked to this record.  To retrieve this collection, specify
        /// `CustomFieldValues` in the `include` parameter when retrieving data.
        ///
        /// To create a custom field, use the [Create Custom Field](https://developer.lockstep.io/reference/post_api-v1-customfieldvalues)
        /// endpoint with the `TableKey` to `Invoice` and the `ObjectKey` set to the `InvoiceId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public CustomFieldValueModel[] CustomFieldValues { get; set; }

        /// <summary>
        /// A collection of custom fields linked to this record.  To retrieve this collection, specify
        /// `CustomFieldDefinitions` in the `include` parameter when retrieving data.
        ///
        /// To create a custom field, use the [Create Custom Field](https://developer.lockstep.io/reference/post_api-v1-customfieldvalues)
        /// endpoint with the `TableKey` to `Invoice` and the `ObjectKey` set to the `InvoiceId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public CustomFieldDefinitionModel[] CustomFieldDefinitions { get; set; }
    }
}
