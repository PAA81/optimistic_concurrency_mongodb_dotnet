﻿using System;
using System.Linq;
using MongoDB.Bson;

namespace MongoDB.Kennedy.Sample
{
	public class Book : IMongoEntity
	{
		public string Name { get; set; }
		public int PageCount { get; set; }
		public ObjectId _id { get; set; }
		public string _accessId { get; set; }
	}
}