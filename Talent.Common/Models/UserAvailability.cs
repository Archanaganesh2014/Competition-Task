﻿using Talent.Common.Contracts;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Talent.Common.Models
{
    public class UserAvailability: IMongoCommon
    {
        public Guid UId { get; set; }
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public string UserId { get; set; }
        public string AvailabilityType { get; set; }
        public int NumberOfAvailableHours { get; set; }
        public int EarnTarget { get; set; }
        public bool IsDeleted { get; set; }
    }
}
