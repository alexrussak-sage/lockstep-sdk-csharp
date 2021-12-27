/***
 * Lockstep Software Development Kit for C#
 *
 * (c) 2021-2022 Lockstep, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     Ted Spence <tspence@lockstep.io>
 * @copyright  2021-2021 Lockstep, Inc.
 * @version    2021.39
 * @link       https://github.com/tspence/lockstep-sdk-csharp
 */


using RestSharp;

namespace LockstepSDK;

public class CompaniesClient
{
    private readonly LockstepApi client;

    public CompaniesClient(LockstepApi client) {
        this.client = client;
    }

    /// <summary>
    /// Retrieves the Company specified by this unique identifier, optionally including nested data sets.  A Company represents a customer, a vendor, or a company within the organization of the account holder. Companies can have parents and children, representing an organizational hierarchy of corporate entities. You can use Companies to track projects and financial data under this Company label.
    /// 
    /// See [Vendors, Customers, and Companies](https://developer.lockstep.io/docs/companies-customers-and-vendors) for more information.
    /// 
    /// </summary>
    /// <param name="id">The unique Lockstep Platform ID number of this Company; NOT the customer's ERP key</param>
    /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve.        Available collections: Attachments, Contacts, CustomFields, Invoices, Notes, Classification</param>
    public async Task<LockstepResponse<CompanyModel>> RetrieveCompany(Guid id, string include)
    {
        var url = $"/api/v1/Companies/{id}";
        var options = new Dictionary<string, object>();
        options["include"] = include;
        return await this.client.Request<CompanyModel>(Method.GET, url, options, null);
    }

    /// <summary>
    /// Updates a Company that matches the specified id with the requested information.
    /// 
    /// The PATCH method allows you to change specific values on the object while leaving other values alone.  As input you should supply a list of field names and new values.  If you do not provide the name of a field, that field will remain unchanged.  This allows you to ensure that you are only updating the specific fields desired.  A Company represents a customer, a vendor, or a company within the organization of the account holder. Companies can have parents and children, representing an organizational hierarchy of corporate entities. You can use Companies to track projects and financial data under this Company label.
    /// 
    /// See [Vendors, Customers, and Companies](https://developer.lockstep.io/docs/companies-customers-and-vendors) for more information.
    /// 
    /// </summary>
    /// <param name="id">The unique Lockstep Platform ID number of this Company; NOT the customer's ERP key</param>
    /// <param name="body">A list of changes to apply to this Company</param>
    public async Task<LockstepResponse<CompanyModel>> UpdateCompany(Guid id, object body)
    {
        var url = $"/api/v1/Companies/{id}";
        return await this.client.Request<CompanyModel>(Method.PATCH, url, null, body);
    }

    /// <summary>
    /// Disable the Company referred to by this unique identifier.
    /// 
    /// A Company represents a customer, a vendor, or a company within the organization of the account holder. Companies can have parents and children, representing an organizational hierarchy of corporate entities. You can use Companies to track projects and financial data under this Company label.
    /// 
    /// See [Vendors, Customers, and Companies](https://developer.lockstep.io/docs/companies-customers-and-vendors) for more information.
    /// 
    /// </summary>
    /// <param name="id">The unique Lockstep Platform ID number of this Company; NOT the customer's ERP key</param>
    public async Task<LockstepResponse<ActionResultModel>> DisableCompany(Guid id)
    {
        var url = $"/api/v1/Companies/{id}";
        return await this.client.Request<ActionResultModel>(Method.DELETE, url, null, null);
    }

    /// <summary>
    /// Creates one or more Companies from a given model.  A Company represents a customer, a vendor, or a company within the organization of the account holder. Companies can have parents and children, representing an organizational hierarchy of corporate entities. You can use Companies to track projects and financial data under this Company label.
    /// 
    /// See [Vendors, Customers, and Companies](https://developer.lockstep.io/docs/companies-customers-and-vendors) for more information.
    /// 
    /// </summary>
    /// <param name="body">The Companies to create</param>
    public async Task<LockstepResponse<CompanyModel[]>> CreateCompanies(CompanyModel[] body)
    {
        var url = $"/api/v1/Companies";
        return await this.client.Request<CompanyModel[]>(Method.POST, url, null, body);
    }

    /// <summary>
    /// Queries Companies for this account using the specified filtering, sorting, nested fetch, and pagination rules requested.
    /// 
    /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the Lockstep Developer website.  A Company represents a customer, a vendor, or a company within the organization of the account holder. Companies can have parents and children, representing an organizational hierarchy of corporate entities. You can use Companies to track projects and financial data under this Company label.
    /// 
    /// See [Vendors, Customers, and Companies](https://developer.lockstep.io/docs/companies-customers-and-vendors) for more information.
    /// 
    /// </summary>
    /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
    /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve.        Available collections: Attachments, Contacts, CustomFields, Invoices, Notes, Classification</param>
    /// <param name="order">The sort order for the results, in the [Searchlight order syntax](https://github.com/tspence/csharp-searchlight).</param>
    /// <param name="pageSize">The page size for results (default 200, maximum of 10,000)</param>
    /// <param name="pageNumber">The page number for results (default 0)</param>
    public async Task<LockstepResponse<FetchResult<CompanyModel>>> QueryCompanies(string filter, string include, string order, int pageSize, int pageNumber)
    {
        var url = $"/api/v1/Companies/query";
        var options = new Dictionary<string, object>();
        options["filter"] = filter;
        options["include"] = include;
        options["order"] = order;
        options["pageSize"] = pageSize;
        options["pageNumber"] = pageNumber;
        return await this.client.Request<FetchResult<CompanyModel>>(Method.GET, url, options, null);
    }

    /// <summary>
    /// Queries Customer Summaries for this account using the specified filtering, sorting, nested fetch, and pagination rules requested.
    /// 
    /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the Lockstep Developer website.  The Customer Summary View represents a slightly different view of the data and includes some extra fields that might be useful. For more information, see the data format of the Customer Summary Model.  See [Vendors, Customers, and Companies](https://developer.lockstep.io/docs/companies-customers-and-vendors) for more information.
    /// 
    /// </summary>
    /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
    /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve.        No collections are currently available but may be offered in the future</param>
    /// <param name="order">The sort order for the results, in the [Searchlight order syntax](https://github.com/tspence/csharp-searchlight).</param>
    /// <param name="pageSize">The page size for results (default 200, maximum of 10,000)</param>
    /// <param name="pageNumber">The page number for results (default 0)</param>
    public async Task<LockstepResponse<FetchResult<CustomerSummaryModel>>> QueryCustomerSummary(string filter, string include, string order, int pageSize, int pageNumber)
    {
        var url = $"/api/v1/Companies/views/customer-summary";
        var options = new Dictionary<string, object>();
        options["filter"] = filter;
        options["include"] = include;
        options["order"] = order;
        options["pageSize"] = pageSize;
        options["pageNumber"] = pageNumber;
        return await this.client.Request<FetchResult<CustomerSummaryModel>>(Method.GET, url, options, null);
    }

    /// <summary>
    /// Retrieves the Customer Details specified by this unique identifier, optionally including nested data sets.  The Customer Detail View represents a slightly different view of the data and includes some extra fields that might be useful. For more information, see the data format of the Customer Detail Model.  See [Vendors, Customers, and Companies](https://developer.lockstep.io/docs/companies-customers-and-vendors) for more information.
    /// 
    /// </summary>
    /// <param name="id">The unique Lockstep Platform ID number of this Company; NOT the customer's ERP key</param>
    public async Task<LockstepResponse<CustomerDetailsModel>> RetrieveCustomerDetail(Guid id)
    {
        var url = $"/api/v1/Companies/views/customer-details/{id}";
        return await this.client.Request<CustomerDetailsModel>(Method.GET, url, null, null);
    }
}
