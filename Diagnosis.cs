using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WorkingWithREST
{
    public class Diagnosis
    {
        [JsonPropertyName("id")] public int Id { get; set; }
        [JsonPropertyName("name")] public string Name { get; set; }
        [JsonPropertyName("severity")] public int Severity { get; set; }
    }

    public class Vitals
    {
        [JsonPropertyName("bloodPressureDiastole")] public int BloodPressureDiastole { get; set; }
        [JsonPropertyName("bloodPressureSystole")] public int BloodPressureSystole { get; set; }
        [JsonPropertyName("pulse")] public int Pulse { get; set; }
        [JsonPropertyName("breathingRate")] public int BreathingRate { get; set; }
        [JsonPropertyName("bodyTemperature")] public double BodyTemperature { get; set; }
    }

    public class Doctor
    {
        [JsonPropertyName("id")] public int Id { get; set; }
        [JsonPropertyName("name")] public string Name { get; set; }
    }

    public class Meta
    {
        [JsonPropertyName("height")] public int Height { get; set; }
        [JsonPropertyName("weight")] public int Weight { get; set; }
    }
}
