using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WorkingWithREST
{
    public class MedicalRecord
    {
        [JsonPropertyName("id")] public int Id { get; set; }
        [JsonPropertyName("timestamp")] public long Timestamp { get; set; }
        [JsonPropertyName("userId")] public int UserId { get; set; }
        [JsonPropertyName("userName")] public string UserName { get; set; }
        [JsonPropertyName("userDob")] public string UserDob { get; set; }
        [JsonPropertyName("diagnosis")] public Diagnosis Diagnosis { get; set; }
        [JsonPropertyName("vitals")] public Vitals Vitals { get; set; }
        [JsonPropertyName("doctor")] public Doctor Doctor { get; set; }
        [JsonPropertyName("meta")] public Meta Meta { get; set; }
    }
}
