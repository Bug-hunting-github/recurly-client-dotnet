using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Recurly.Resources {
  public class SubscriptionChange : Resource {
  
    /// <value>Activated at</value>
    [JsonProperty("activate_at")]
    public DateTime? ActivateAt { get; set; }
  
    /// <value>Returns `true` if the subscription change is activated.</value>
    [JsonProperty("activated")]
    public bool? Activated { get; set; }
  
    /// <value>These add-ons will be used when the subscription renews.</value>
    [JsonProperty("add_ons")]
    public List<SubscriptionAddOn> AddOns { get; set; }
  
    /// <value>Created at</value>
    [JsonProperty("created_at")]
    public DateTime? CreatedAt { get; set; }
  
    /// <value>Deleted at</value>
    [JsonProperty("deleted_at")]
    public DateTime? DeletedAt { get; set; }
  
    /// <value>The ID of the Subscription Change.</value>
    [JsonProperty("id")]
    public string Id { get; set; }
  
    
    [JsonProperty("plan")]
    public PlanMini Plan { get; set; }
  
    /// <value>Subscription quantity</value>
    [JsonProperty("quantity")]
    public int? Quantity { get; set; }
  
    /// <value>The ID of the subscription that is going to be changed.</value>
    [JsonProperty("subscription_id")]
    public string SubscriptionId { get; set; }
  
    /// <value>Unit amount</value>
    [JsonProperty("unit_amount")]
    public float? UnitAmount { get; set; }
  
    /// <value>Updated at</value>
    [JsonProperty("updated_at")]
    public DateTime? UpdatedAt { get; set; }
  
  }
}
