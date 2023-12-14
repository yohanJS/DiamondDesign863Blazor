using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PocBlazorApp.Models;

namespace PocBlazorApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {

        public DbSet<UserPrimaryInfo>? UserPrimaryInfo { get; set; }
        public DbSet<AmplifierModel>? AmplifierModel { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<AmplifierModel>(entity =>
        //    {
        //        entity.ToTable("amplifiermodels");
        //        entity.Property(e => e.ModelName)
        //            .IsRequired()
        //            .HasMaxLength(255)
        //            .HasColumnName("ModelName"); // Assuming "ModelName" is the column name in the database

        //        entity.Property(e => e.Ohms).HasColumnName("Ohms");

        //        entity.Property(e => e.FrequencyResponse)
        //            .HasColumnName("FrequencyResponse");

        //        entity.Property(e => e.LowPassFilter)
        //            .HasColumnName("LowPassFilter");

        //        entity.Property(e => e.HighPassFilter)
        //            .HasColumnName("HighPassFilter");

        //        entity.Property(e => e.OperatingVoltage)
        //            .HasColumnName("OperatingVoltage");

        //        entity.Property(e => e.SignalToNoiseRatio)
        //            .HasColumnName("SignalToNoiseRatio");

        //        entity.Property(e => e.InputSensitivityRCA)
        //            .HasColumnName("InputSensitivityRCA");

        //        entity.Property(e => e.InputSensitivityHighLevel)
        //            .HasColumnName("InputSensitivityHighLevel");

        //        entity.Property(e => e.CurrentDrawMusic)
        //            .HasColumnName("CurrentDrawMusic");

        //        entity.Property(e => e.CurrentDrawWithResistiveLoad)
        //            .HasColumnName("CurrentDrawWithResistiveLoad");

        //        entity.Property(e => e.TotalEfficiency)
        //            .HasColumnName("TotalEfficiency");

        //        entity.Property(e => e.DampingFactor)
        //            .HasColumnName("DampingFactor");

        //        entity.Property(e => e.PowerCable)
        //            .HasColumnName("PowerCable");

        //        entity.Property(e => e.AudioOutputCable)
        //            .HasColumnName("AudioOutputCable");

        //        entity.Property(e => e.RecommendedFuse)
        //            .HasColumnName("RecommendedFuse");

        //        entity.Property(e => e.RecommendedBatteryMinimum)
        //            .HasColumnName("RecommendedBatteryMinimum");

        //        entity.Property(e => e.Width)
        //            .HasColumnName("Width");

        //        entity.Property(e => e.Length)
        //            .HasColumnName("Length");

        //        entity.Property(e => e.Height)
        //            .HasColumnName("Height");

        //        entity.Property(e => e.Weight)
        //            .HasColumnName("Weight");
        //    });
        //    OnModelCreatingPartial(modelBuilder);
        //}
        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
    
}
