using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace CHAPI.Models
{
    [JsonObject]
    public class Company
    {
        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("undeliverable_registered_office_address")]
        public bool undeliverable_registered_office_address { get; set; }

        [Display(Name = "Registered Office Address")]
        [JsonProperty("registered_office_address")]
        public RegisteredOfficeAddress? registered_office_address { get; set; }

        [JsonProperty("type")]
        public string? type { get; set; }

        [JsonProperty("annual_return")]
        public AnnualReturn? annual_return { get; set; }

        [Display(Name = "Date of Creation")]
        [JsonProperty("date_of_creation")]
        public string? date_of_creation { get; set; }

        [Display(Name = "Company Number")]
        [JsonProperty("company_number")]
        public string? company_number { get; set; }

        [Display(Name = "Company Name")]
        [JsonProperty("company_name")]
        public string? company_name { get; set; }

        [JsonProperty("last_full_members_list_date")]
        public string? last_full_members_list_date { get; set; }

        [JsonProperty("jurisdiction")]
        public string? jurisdiction { get; set; }

        [Display(Name = "Has Been Liquidated")]
        [JsonProperty("has_been_liquidated")]
        public bool has_been_liquidated { get; set; }

        [JsonProperty("accounts")]
        public Accounts? accounts { get; set; }

        [Display(Name = "Has Insolvancy History")]
        [JsonProperty("has_insolvency_history")]
        public bool has_insolvency_history { get; set; }

        [JsonProperty("etag")]
        public string? etag { get; set; }

        [JsonProperty("has_charges")]
        public bool has_charges { get; set; }

        [Display(Name = "Company Status")]
        [JsonProperty("company_status")]
        public string? company_status { get; set; }

        [JsonProperty("confirmation_statement")]
        public ConfirmationStatement? confirmation_statement { get; set; }

        [JsonProperty("links")]
        public Links? links { get; set; }

        [Display(Name = "Registerd Office In Dispute")]
        [JsonProperty("registered_office_is_in_dispute")]
        public bool registered_office_is_in_dispute { get; set; }

        [Display(Name = "Can File")]
        [JsonProperty("can_file")]
        public bool can_file { get; set; }

        [Display(Name = "Sic Codes")]
        [JsonProperty("sic_codes")]
        public List<string>? sic_codes { get; set; }

        [Display(Name = "date of Cessation")]
        [JsonProperty("date_of_cessation")]
        public string? date_of_cessation { get; set; }

        [Display(Name = "Kind")]
        [JsonProperty("kind")]
        public string? kind { get; set; }
    }

}

