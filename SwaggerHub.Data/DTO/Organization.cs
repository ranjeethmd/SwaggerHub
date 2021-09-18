using Newtonsoft.Json;
using System.Collections.Generic;

namespace SwaggerHub.Data.DTO
{
	public class Organization
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("description")]
		public string Description { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
		[JsonProperty("offset")]
		public int Offset { get; set; }
		[JsonProperty("totalCount")]
		public int TotalCount { get; set; }
		[JsonProperty("apis")]
		public List<Api> Apis { get; set; }
	}
	public class Api
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("description")]
		public string Description { get; set; }
		[JsonProperty("tags")]
		public List<object> Tags { get; set; }
		[JsonProperty("properties")]
		public List<Property> Properties { get; set; }
	}
	public class Property
	{
		[JsonProperty("type")]
		public string Type { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
		[JsonProperty("value")]
		public string Value { get; set; }
	}

}
