﻿namespace TaskSis.Models
{
	public class Product
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? Description { get; set; }
		public string? Price { get; set; }
		public string? ImageUrl { get; set; }
		public float Stock { get; set; }
		public DateTime RegisterDate { get; set; }
	}
}