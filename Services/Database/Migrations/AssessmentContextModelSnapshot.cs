﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Service.Database;

#nullable disable

namespace Service.Database.Migrations
{
    [DbContext(typeof(AssessmentContext))]
    partial class AssessmentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Model.Assessment", b =>
                {
                    b.Property<int>("AssessmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AssessmentId"), 1L, 1);

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("AssessmentId");

                    b.HasIndex("GroupId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Assessments");
                });

            modelBuilder.Entity("Model.Competence", b =>
                {
                    b.Property<int>("CompetenceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompetenceId"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Evidence")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FormId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("CompetenceId");

                    b.HasIndex("FormId");

                    b.ToTable("Competences");
                });

            modelBuilder.Entity("Model.Criterion", b =>
                {
                    b.Property<int>("CriterionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CriterionId"), 1L, 1);

                    b.Property<int>("CompetenceId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CriterionId");

                    b.HasIndex("CompetenceId");

                    b.ToTable("Criteria");
                });

            modelBuilder.Entity("Model.Form", b =>
                {
                    b.Property<int>("FormId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FormId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FormId");

                    b.ToTable("Forms");
                });

            modelBuilder.Entity("Model.FormIndicator", b =>
                {
                    b.Property<int>("FormId")
                        .HasColumnType("int");

                    b.Property<int>("IndicatorId")
                        .HasColumnType("int");

                    b.HasKey("FormId", "IndicatorId");

                    b.HasIndex("IndicatorId");

                    b.ToTable("FormIndicators");
                });

            modelBuilder.Entity("Model.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GroupId"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("GroupId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Model.GroupStudent", b =>
                {
                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("StudentNumber")
                        .HasColumnType("int");

                    b.HasKey("GroupId", "StudentNumber");

                    b.HasIndex("StudentNumber");

                    b.ToTable("GroupStudents");
                });

            modelBuilder.Entity("Model.Indicator", b =>
                {
                    b.Property<int>("IndicatorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IndicatorId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("IndicatorId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Indicators");
                });

            modelBuilder.Entity("Model.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectId"), 1L, 1);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FormId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectId");

                    b.HasIndex("FormId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Model.Rating", b =>
                {
                    b.Property<int>("AssessmentId")
                        .HasColumnType("int");

                    b.Property<int>("CriterionId")
                        .HasColumnType("int");

                    b.Property<int>("RequirementId")
                        .HasColumnType("int");

                    b.HasKey("AssessmentId", "CriterionId");

                    b.HasIndex("CriterionId");

                    b.HasIndex("RequirementId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("Model.Requirement", b =>
                {
                    b.Property<int>("RequirementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RequirementId"), 1L, 1);

                    b.Property<int>("CriterionId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IndicatorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RequirementId");

                    b.HasIndex("CriterionId");

                    b.HasIndex("IndicatorId");

                    b.ToTable("Requirements");
                });

            modelBuilder.Entity("Model.Student", b =>
                {
                    b.Property<int>("StudentNumber")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentNumber");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Model.Assessment", b =>
                {
                    b.HasOne("Model.Group", "Group")
                        .WithMany("Assessments")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Project", "Project")
                        .WithMany("Assessments")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Model.Competence", b =>
                {
                    b.HasOne("Model.Form", "Form")
                        .WithMany("Competences")
                        .HasForeignKey("FormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Form");
                });

            modelBuilder.Entity("Model.Criterion", b =>
                {
                    b.HasOne("Model.Competence", "Competence")
                        .WithMany("Criteria")
                        .HasForeignKey("CompetenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Competence");
                });

            modelBuilder.Entity("Model.FormIndicator", b =>
                {
                    b.HasOne("Model.Form", "Form")
                        .WithMany("FromIndicators")
                        .HasForeignKey("FormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Indicator", "Indicator")
                        .WithMany("FromIndicators")
                        .HasForeignKey("IndicatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Form");

                    b.Navigation("Indicator");
                });

            modelBuilder.Entity("Model.GroupStudent", b =>
                {
                    b.HasOne("Model.Group", "Group")
                        .WithMany("GroupStudents")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Student", "Student")
                        .WithMany("GroupStudents")
                        .HasForeignKey("StudentNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Model.Project", b =>
                {
                    b.HasOne("Model.Form", "Form")
                        .WithMany("Projects")
                        .HasForeignKey("FormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Form");
                });

            modelBuilder.Entity("Model.Rating", b =>
                {
                    b.HasOne("Model.Assessment", "Assessment")
                        .WithMany("Ratings")
                        .HasForeignKey("AssessmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Criterion", "Criterion")
                        .WithMany("Ratings")
                        .HasForeignKey("CriterionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Model.Requirement", "Requirement")
                        .WithMany("Ratings")
                        .HasForeignKey("RequirementId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Assessment");

                    b.Navigation("Criterion");

                    b.Navigation("Requirement");
                });

            modelBuilder.Entity("Model.Requirement", b =>
                {
                    b.HasOne("Model.Criterion", "Criterion")
                        .WithMany("Requirements")
                        .HasForeignKey("CriterionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Indicator", "Indicator")
                        .WithMany()
                        .HasForeignKey("IndicatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Criterion");

                    b.Navigation("Indicator");
                });

            modelBuilder.Entity("Model.Assessment", b =>
                {
                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("Model.Competence", b =>
                {
                    b.Navigation("Criteria");
                });

            modelBuilder.Entity("Model.Criterion", b =>
                {
                    b.Navigation("Ratings");

                    b.Navigation("Requirements");
                });

            modelBuilder.Entity("Model.Form", b =>
                {
                    b.Navigation("Competences");

                    b.Navigation("FromIndicators");

                    b.Navigation("Projects");
                });

            modelBuilder.Entity("Model.Group", b =>
                {
                    b.Navigation("Assessments");

                    b.Navigation("GroupStudents");
                });

            modelBuilder.Entity("Model.Indicator", b =>
                {
                    b.Navigation("FromIndicators");
                });

            modelBuilder.Entity("Model.Project", b =>
                {
                    b.Navigation("Assessments");
                });

            modelBuilder.Entity("Model.Requirement", b =>
                {
                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("Model.Student", b =>
                {
                    b.Navigation("GroupStudents");
                });
#pragma warning restore 612, 618
        }
    }
}
