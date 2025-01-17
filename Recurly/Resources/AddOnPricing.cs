/**
 * This file is automatically created by Recurly's OpenAPI generation process
 * and thus any edits you make by hand will be lost. If you wish to make a
 * change to this file, please create a Github issue explaining the changes you
 * need and we will usher them to the appropriate places.
 */
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace Recurly.Resources
{
    [ExcludeFromCodeCoverage]
    public class AddOnPricing : Request
    {

        /// <value>3-letter ISO 4217 currency code.</value>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <value>Determines whether or not tax is included in the unit amount. The Tax Inclusive Pricing feature (separate from the Mixed Tax Pricing feature) must be enabled to use this flag.</value>
        [JsonProperty("tax_inclusive")]
        public bool? TaxInclusive { get; set; }

        /// <value>Allows up to 2 decimal places. Required unless `unit_amount_decimal` is provided.</value>
        [JsonProperty("unit_amount")]
        public decimal? UnitAmount { get; set; }

        /// <value>
        /// Allows up to 9 decimal places. Only supported when `add_on_type` = `usage`.
        /// If `unit_amount_decimal` is provided, `unit_amount` cannot be provided.
        /// </value>
        [JsonProperty("unit_amount_decimal")]
        public string UnitAmountDecimal { get; set; }

    }
}
