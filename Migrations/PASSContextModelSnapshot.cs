﻿// <auto-generated />
using System;
using Infobase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infobase.Migrations
{
    [DbContext(typeof(PASSContext))]
    partial class PASSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-preview3-35497")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Infobase.Models.PASS.Activity", b =>
                {
                    b.Property<int>("ActivityId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DefaultIndicatorGroupId");

                    b.Property<int>("Index");

                    b.HasKey("ActivityId");

                    b.HasAlternateKey("Index");

                    b.HasIndex("DefaultIndicatorGroupId");

                    b.ToTable("Activity");
                });

            modelBuilder.Entity("Infobase.Models.PASS.ActivityDescriptionTranslation", b =>
                {
                    b.Property<int>("TranslationId");

                    b.Property<int>("ActivityId");

                    b.HasKey("TranslationId", "ActivityId");

                    b.HasIndex("ActivityId");

                    b.ToTable("ActivityDescriptionTranslation");
                });

            modelBuilder.Entity("Infobase.Models.PASS.ActivityNameTranslation", b =>
                {
                    b.Property<int>("TranslationId");

                    b.Property<int>("ActivityId");

                    b.HasKey("TranslationId", "ActivityId");

                    b.HasIndex("ActivityId");

                    b.ToTable("ActivityNameTranslation");
                });

            modelBuilder.Entity("Infobase.Models.PASS.Indicator", b =>
                {
                    b.Property<int>("IndicatorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DefaultMeasureId");

                    b.Property<int>("Index");

                    b.Property<int>("LifeCourseId");

                    b.HasKey("IndicatorId");

                    b.HasAlternateKey("Index");

                    b.HasIndex("DefaultMeasureId");

                    b.HasIndex("LifeCourseId");

                    b.ToTable("Indicator");
                });

            modelBuilder.Entity("Infobase.Models.PASS.IndicatorGroup", b =>
                {
                    b.Property<int>("IndicatorGroupId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActivityId");

                    b.Property<int?>("DefaultLifeCourseId");

                    b.Property<int>("Index");

                    b.HasKey("IndicatorGroupId");

                    b.HasAlternateKey("Index");

                    b.HasIndex("ActivityId");

                    b.HasIndex("DefaultLifeCourseId");

                    b.ToTable("IndicatorGroup");
                });

            modelBuilder.Entity("Infobase.Models.PASS.IndicatorGroupNameTranslation", b =>
                {
                    b.Property<int>("TranslationId");

                    b.Property<int>("IndicatorGroupId");

                    b.HasKey("TranslationId", "IndicatorGroupId");

                    b.HasIndex("IndicatorGroupId");

                    b.ToTable("IndicatorGroupNameTranslation");
                });

            modelBuilder.Entity("Infobase.Models.PASS.IndicatorNameTranslation", b =>
                {
                    b.Property<int>("TranslationId");

                    b.Property<int>("IndicatorId");

                    b.HasKey("TranslationId", "IndicatorId");

                    b.HasIndex("IndicatorId");

                    b.ToTable("IndicatorNameTranslation");
                });

            modelBuilder.Entity("Infobase.Models.PASS.LifeCourse", b =>
                {
                    b.Property<int>("LifeCourseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DefaultIndicatorId");

                    b.Property<int>("Index");

                    b.Property<int>("IndicatorGroupId");

                    b.HasKey("LifeCourseId");

                    b.HasAlternateKey("Index");

                    b.HasIndex("DefaultIndicatorId");

                    b.HasIndex("IndicatorGroupId");

                    b.ToTable("LifeCourse");
                });

            modelBuilder.Entity("Infobase.Models.PASS.LifeCourseNameTranslation", b =>
                {
                    b.Property<int>("TranslationId");

                    b.Property<int>("LifeCourseId");

                    b.HasKey("TranslationId", "LifeCourseId");

                    b.HasIndex("LifeCourseId");

                    b.ToTable("LifeCourseNameTranslation");
                });

            modelBuilder.Entity("Infobase.Models.PASS.Measure", b =>
                {
                    b.Property<int>("MeasureId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double?>("CVSuppressAt");

                    b.Property<double?>("CVWarnAt");

                    b.Property<int?>("DefaultStrataId");

                    b.Property<bool>("Included");

                    b.Property<int>("Index");

                    b.Property<int>("IndicatorId");

                    b.HasKey("MeasureId");

                    b.HasAlternateKey("Index");

                    b.HasIndex("DefaultStrataId");

                    b.HasIndex("IndicatorId");

                    b.ToTable("Measure");
                });

            modelBuilder.Entity("Infobase.Models.PASS.MeasureAdditionalRemarksTranslation", b =>
                {
                    b.Property<int>("TranslationId");

                    b.Property<int>("MeasureId");

                    b.HasKey("TranslationId", "MeasureId");

                    b.HasIndex("MeasureId");

                    b.ToTable("MeasureAdditionalRemarksTranslation");
                });

            modelBuilder.Entity("Infobase.Models.PASS.MeasureDataAvailableTranslation", b =>
                {
                    b.Property<int>("TranslationId");

                    b.Property<int>("MeasureId");

                    b.HasKey("TranslationId", "MeasureId");

                    b.HasIndex("MeasureId");

                    b.ToTable("MeasureDataAvailableTranslation");
                });

            modelBuilder.Entity("Infobase.Models.PASS.MeasureDefinitionTranslation", b =>
                {
                    b.Property<int>("TranslationId");

                    b.Property<int>("MeasureId");

                    b.HasKey("TranslationId", "MeasureId");

                    b.HasIndex("MeasureId");

                    b.ToTable("MeasureDefinitionTranslation");
                });

            modelBuilder.Entity("Infobase.Models.PASS.MeasureMethodTranslation", b =>
                {
                    b.Property<int>("TranslationId");

                    b.Property<int>("MeasureId");

                    b.HasKey("TranslationId", "MeasureId");

                    b.HasIndex("MeasureId");

                    b.ToTable("MeasureMethodTranslation");
                });

            modelBuilder.Entity("Infobase.Models.PASS.MeasureNameTranslation", b =>
                {
                    b.Property<int>("TranslationId");

                    b.Property<int>("MeasureId");

                    b.HasKey("TranslationId", "MeasureId");

                    b.HasIndex("MeasureId");

                    b.ToTable("MeasureNameTranslation");
                });

            modelBuilder.Entity("Infobase.Models.PASS.MeasurePopulationTranslation", b =>
                {
                    b.Property<int>("TranslationId");

                    b.Property<int>("MeasureId");

                    b.HasKey("TranslationId", "MeasureId");

                    b.HasIndex("MeasureId");

                    b.ToTable("MeasurePopulationTranslation");
                });

            modelBuilder.Entity("Infobase.Models.PASS.MeasureSourceTranslation", b =>
                {
                    b.Property<int>("TranslationId");

                    b.Property<int>("MeasureId");

                    b.HasKey("TranslationId", "MeasureId");

                    b.HasIndex("MeasureId");

                    b.ToTable("MeasureSourceTranslation");
                });

            modelBuilder.Entity("Infobase.Models.PASS.MeasureUnitTranslation", b =>
                {
                    b.Property<int>("TranslationId");

                    b.Property<int>("MeasureId");

                    b.HasKey("TranslationId", "MeasureId");

                    b.HasIndex("MeasureId");

                    b.ToTable("MeasureUnitTranslation");
                });

            modelBuilder.Entity("Infobase.Models.PASS.Point", b =>
                {
                    b.Property<int>("PointId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CVInterpretation");

                    b.Property<int?>("CVValue");

                    b.Property<int>("Index");

                    b.Property<int>("StrataId");

                    b.Property<int>("Type");

                    b.Property<double?>("ValueAverage");

                    b.Property<double?>("ValueLower");

                    b.Property<double?>("ValueUpper");

                    b.HasKey("PointId");

                    b.HasAlternateKey("Index");

                    b.HasIndex("StrataId");

                    b.ToTable("Point");
                });

            modelBuilder.Entity("Infobase.Models.PASS.PointLabelTranslation", b =>
                {
                    b.Property<int>("TranslationId");

                    b.Property<int>("PointId");

                    b.HasKey("TranslationId", "PointId");

                    b.HasIndex("PointId");

                    b.ToTable("PointLabelTranslation");
                });

            modelBuilder.Entity("Infobase.Models.PASS.Strata", b =>
                {
                    b.Property<int>("StrataId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Index");

                    b.Property<int>("MeasureId");

                    b.HasKey("StrataId");

                    b.HasAlternateKey("Index");

                    b.HasIndex("MeasureId");

                    b.ToTable("Strata");
                });

            modelBuilder.Entity("Infobase.Models.PASS.StrataNameTranslation", b =>
                {
                    b.Property<int>("TranslationId");

                    b.Property<int>("StrataId");

                    b.HasKey("TranslationId", "StrataId");

                    b.HasIndex("StrataId");

                    b.ToTable("StrataNameTranslation");
                });

            modelBuilder.Entity("Infobase.Models.PASS.StrataNotesTranslation", b =>
                {
                    b.Property<int>("TranslationId");

                    b.Property<int>("StrataId");

                    b.HasKey("TranslationId", "StrataId");

                    b.HasIndex("StrataId");

                    b.ToTable("StrataNotesTranslation");
                });

            modelBuilder.Entity("Infobase.Models.PASS.StrataPopulationTranslation", b =>
                {
                    b.Property<int>("TranslationId");

                    b.Property<int>("StrataId");

                    b.HasKey("TranslationId", "StrataId");

                    b.HasIndex("StrataId");

                    b.ToTable("StrataPopulationTranslation");
                });

            modelBuilder.Entity("Infobase.Models.PASS.StrataSourceTranslation", b =>
                {
                    b.Property<int>("TranslationId");

                    b.Property<int>("StrataId");

                    b.HasKey("TranslationId", "StrataId");

                    b.HasIndex("StrataId");

                    b.ToTable("StrataSourceTranslation");
                });

            modelBuilder.Entity("Infobase.Models.PASS.Translation", b =>
                {
                    b.Property<int>("TranslationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LanguageCode");

                    b.Property<string>("Text");

                    b.Property<string>("Type");

                    b.HasKey("TranslationId");

                    b.ToTable("Translation");
                });

            modelBuilder.Entity("Infobase.Models.PASS.Activity", b =>
                {
                    b.HasOne("Infobase.Models.PASS.IndicatorGroup", "DefaultIndicatorGroup")
                        .WithMany()
                        .HasForeignKey("DefaultIndicatorGroupId");
                });

            modelBuilder.Entity("Infobase.Models.PASS.ActivityDescriptionTranslation", b =>
                {
                    b.HasOne("Infobase.Models.PASS.Activity", "Activity")
                        .WithMany("ActivityDescriptionTranslations")
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Infobase.Models.PASS.Translation", "Translation")
                        .WithMany("ActivityDescriptionTranslations")
                        .HasForeignKey("TranslationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Infobase.Models.PASS.ActivityNameTranslation", b =>
                {
                    b.HasOne("Infobase.Models.PASS.Activity", "Activity")
                        .WithMany("ActivityNameTranslations")
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Infobase.Models.PASS.Translation", "Translation")
                        .WithMany("ActivityNameTranslations")
                        .HasForeignKey("TranslationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Infobase.Models.PASS.Indicator", b =>
                {
                    b.HasOne("Infobase.Models.PASS.Measure", "DefaultMeasure")
                        .WithMany()
                        .HasForeignKey("DefaultMeasureId");

                    b.HasOne("Infobase.Models.PASS.LifeCourse", "LifeCourse")
                        .WithMany("Indicators")
                        .HasForeignKey("LifeCourseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Infobase.Models.PASS.IndicatorGroup", b =>
                {
                    b.HasOne("Infobase.Models.PASS.Activity", "Activity")
                        .WithMany("IndicatorGroups")
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Infobase.Models.PASS.LifeCourse", "DefaultLifeCourse")
                        .WithMany()
                        .HasForeignKey("DefaultLifeCourseId");
                });

            modelBuilder.Entity("Infobase.Models.PASS.IndicatorGroupNameTranslation", b =>
                {
                    b.HasOne("Infobase.Models.PASS.IndicatorGroup", "IndicatorGroup")
                        .WithMany("IndicatorGroupNameTranslations")
                        .HasForeignKey("IndicatorGroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Infobase.Models.PASS.Translation", "Translation")
                        .WithMany("IndicatorGroupNameTranslations")
                        .HasForeignKey("TranslationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Infobase.Models.PASS.IndicatorNameTranslation", b =>
                {
                    b.HasOne("Infobase.Models.PASS.Indicator", "Indicator")
                        .WithMany("IndicatorNameTranslations")
                        .HasForeignKey("IndicatorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Infobase.Models.PASS.Translation", "Translation")
                        .WithMany("IndicatorNameTranslations")
                        .HasForeignKey("TranslationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Infobase.Models.PASS.LifeCourse", b =>
                {
                    b.HasOne("Infobase.Models.PASS.Indicator", "DefaultIndicator")
                        .WithMany()
                        .HasForeignKey("DefaultIndicatorId");

                    b.HasOne("Infobase.Models.PASS.IndicatorGroup", "IndicatorGroup")
                        .WithMany("LifeCourses")
                        .HasForeignKey("IndicatorGroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Infobase.Models.PASS.LifeCourseNameTranslation", b =>
                {
                    b.HasOne("Infobase.Models.PASS.LifeCourse", "LifeCourse")
                        .WithMany("LifeCourseNameTranslations")
                        .HasForeignKey("LifeCourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Infobase.Models.PASS.Translation", "Translation")
                        .WithMany("LifeCourseNameTranslations")
                        .HasForeignKey("TranslationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Infobase.Models.PASS.Measure", b =>
                {
                    b.HasOne("Infobase.Models.PASS.Strata", "DefaultStrata")
                        .WithMany()
                        .HasForeignKey("DefaultStrataId");

                    b.HasOne("Infobase.Models.PASS.Indicator", "Indicator")
                        .WithMany("Measures")
                        .HasForeignKey("IndicatorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Infobase.Models.PASS.MeasureAdditionalRemarksTranslation", b =>
                {
                    b.HasOne("Infobase.Models.PASS.Measure", "Measure")
                        .WithMany("MeasureAdditionalRemarksTranslations")
                        .HasForeignKey("MeasureId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Infobase.Models.PASS.Translation", "Translation")
                        .WithMany("MeasureAdditionalRemarksTranslations")
                        .HasForeignKey("TranslationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Infobase.Models.PASS.MeasureDataAvailableTranslation", b =>
                {
                    b.HasOne("Infobase.Models.PASS.Measure", "Measure")
                        .WithMany("MeasureDataAvailableTranslations")
                        .HasForeignKey("MeasureId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Infobase.Models.PASS.Translation", "Translation")
                        .WithMany("MeasureDataAvailableTranslations")
                        .HasForeignKey("TranslationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Infobase.Models.PASS.MeasureDefinitionTranslation", b =>
                {
                    b.HasOne("Infobase.Models.PASS.Measure", "Measure")
                        .WithMany("MeasureDefinitionTranslations")
                        .HasForeignKey("MeasureId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Infobase.Models.PASS.Translation", "Translation")
                        .WithMany("MeasureDefinitionTranslations")
                        .HasForeignKey("TranslationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Infobase.Models.PASS.MeasureMethodTranslation", b =>
                {
                    b.HasOne("Infobase.Models.PASS.Measure", "Measure")
                        .WithMany("MeasureMethodTranslations")
                        .HasForeignKey("MeasureId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Infobase.Models.PASS.Translation", "Translation")
                        .WithMany("MeasureMethodTranslations")
                        .HasForeignKey("TranslationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Infobase.Models.PASS.MeasureNameTranslation", b =>
                {
                    b.HasOne("Infobase.Models.PASS.Measure", "Measure")
                        .WithMany("MeasureNameTranslations")
                        .HasForeignKey("MeasureId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Infobase.Models.PASS.Translation", "Translation")
                        .WithMany("MeasureNameTranslations")
                        .HasForeignKey("TranslationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Infobase.Models.PASS.MeasurePopulationTranslation", b =>
                {
                    b.HasOne("Infobase.Models.PASS.Measure", "Measure")
                        .WithMany("MeasurePopulationTranslations")
                        .HasForeignKey("MeasureId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Infobase.Models.PASS.Translation", "Translation")
                        .WithMany("MeasurePopulationTranslations")
                        .HasForeignKey("TranslationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Infobase.Models.PASS.MeasureSourceTranslation", b =>
                {
                    b.HasOne("Infobase.Models.PASS.Measure", "Measure")
                        .WithMany("MeasureSourceTranslations")
                        .HasForeignKey("MeasureId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Infobase.Models.PASS.Translation", "Translation")
                        .WithMany("MeasureSourceTranslations")
                        .HasForeignKey("TranslationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Infobase.Models.PASS.MeasureUnitTranslation", b =>
                {
                    b.HasOne("Infobase.Models.PASS.Measure", "Measure")
                        .WithMany("MeasureUnitTranslations")
                        .HasForeignKey("MeasureId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Infobase.Models.PASS.Translation", "Translation")
                        .WithMany("MeasureUnitTranslations")
                        .HasForeignKey("TranslationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Infobase.Models.PASS.Point", b =>
                {
                    b.HasOne("Infobase.Models.PASS.Strata", "Strata")
                        .WithMany("Points")
                        .HasForeignKey("StrataId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Infobase.Models.PASS.PointLabelTranslation", b =>
                {
                    b.HasOne("Infobase.Models.PASS.Point", "Point")
                        .WithMany("PointLabelTranslations")
                        .HasForeignKey("PointId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Infobase.Models.PASS.Translation", "Translation")
                        .WithMany("PointLabelTranslations")
                        .HasForeignKey("TranslationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Infobase.Models.PASS.Strata", b =>
                {
                    b.HasOne("Infobase.Models.PASS.Measure", "Measure")
                        .WithMany("Stratas")
                        .HasForeignKey("MeasureId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Infobase.Models.PASS.StrataNameTranslation", b =>
                {
                    b.HasOne("Infobase.Models.PASS.Strata", "Strata")
                        .WithMany("StrataNameTranslations")
                        .HasForeignKey("StrataId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Infobase.Models.PASS.Translation", "Translation")
                        .WithMany("StrataNameTranslations")
                        .HasForeignKey("TranslationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Infobase.Models.PASS.StrataNotesTranslation", b =>
                {
                    b.HasOne("Infobase.Models.PASS.Strata", "Strata")
                        .WithMany("StrataNotesTranslations")
                        .HasForeignKey("StrataId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Infobase.Models.PASS.Translation", "Translation")
                        .WithMany("StrataNotesTranslations")
                        .HasForeignKey("TranslationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Infobase.Models.PASS.StrataPopulationTranslation", b =>
                {
                    b.HasOne("Infobase.Models.PASS.Strata", "Strata")
                        .WithMany("StrataPopulationTranslations")
                        .HasForeignKey("StrataId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Infobase.Models.PASS.Translation", "Translation")
                        .WithMany("StrataPopulationTranslations")
                        .HasForeignKey("TranslationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Infobase.Models.PASS.StrataSourceTranslation", b =>
                {
                    b.HasOne("Infobase.Models.PASS.Strata", "Strata")
                        .WithMany("StrataSourceTranslations")
                        .HasForeignKey("StrataId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Infobase.Models.PASS.Translation", "Translation")
                        .WithMany("StrataSourceTranslations")
                        .HasForeignKey("TranslationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
