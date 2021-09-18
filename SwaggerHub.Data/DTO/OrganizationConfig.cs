using Newtonsoft.Json;


namespace SwaggerHub.Data.DTO
{
	public class OrganizationConfig
	{
		[JsonProperty("orgData")]
		public OrgData OrgData { get; set; }
	}
	public class OrgData
	{
		[JsonProperty("orgName")]
		public string OrgName { get; set; }
		[JsonProperty("displayName")]
		public string DisplayName { get; set; }
		[JsonProperty("displayTag")]
		public string DisplayTag { get; set; }
		[JsonProperty("displayImage")]
		public string DisplayImage { get; set; }
		[JsonProperty("favIcon")]
		public string FavIcon { get; set; }
	}

}
