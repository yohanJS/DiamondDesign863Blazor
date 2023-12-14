using System.ComponentModel.DataAnnotations;

namespace PocBlazorApp.Models
{
    public class AmplifierModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Model Name is required")]
        public string? ModelName { get; set; }
        public double? Ohms { get; set; }
        public string? FrequencyResponse { get; set; }
        public string? LowPassFilter { get; set; }
        public string? HighPassFilter { get; set; }
        public string? OperatingVoltage { get; set; }
        public string? SignalToNoiseRatio { get; set; }
        public string? InputSensitivityRCA { get; set; }
        public string? InputSensitivityHighLevel { get; set; }
        public string? CurrentDrawMusic { get; set; }
        public string? CurrentDrawWithResistiveLoad { get; set; }
        public string? TotalEfficiency { get; set; }
        public string? DampingFactor { get; set; }
        public string? PowerCable { get; set; }
        public string? AudioOutputCable { get; set; }
        public string? RecommendedFuse { get; set; }
        public string? RecommendedBatteryMinimum { get; set; }
        public string? Width { get; set; }
        public string? Length { get; set; }
        public string? Height { get; set; }
        public string? Weight { get; set; }
    }
}
