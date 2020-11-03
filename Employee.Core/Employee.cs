using System;
using System.Collections.Generic;

namespace Employee.Core
{
	public class Pagination
	{
		public int total { get; set; }
		public int pages { get; set; }
		public int page { get; set; }
		public int limit { get; set; }
	}

	public class Meta
	{
		public Pagination pagination { get; set; }
	}

	public interface IEmployee
	{
		int id { get; set; }
		string name { get; set; }
		string email { get; set; }
		string gender { get; set; }
		string status { get; set; }
		DateTime created_at { get; set; }
		DateTime updated_at { get; set; }
	}

	public class RootList
	{
		public int code { get; set; }
		public Meta meta { get; set; }
		public List<EmployeeData> data { get; set; }
	}

	public class Root
	{
		public int code { get; set; }
		public object meta { get; set; }
		public EmployeeData data { get; set; }
	}

	public class EmployeeData
	{
		public int id { get; set; }
		public string name { get; set; }
		public string email { get; set; }
		public string gender { get; set; }
		public string status { get; set; }
		public DateTime created_at { get; set; }
		public DateTime updated_at { get; set; }
	}
}
