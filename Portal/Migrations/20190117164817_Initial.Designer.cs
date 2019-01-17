﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OpenSim.Portal.Model;

namespace OpenSim.Portal.Migrations
{
    [DbContext(typeof(PortalDbContext))]
    [Migration("20190117164817_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OpenSim.Portal.Model.Presentation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("AuthorId");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Presentations");
                });

            modelBuilder.Entity("OpenSim.Portal.Model.Server", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("AuthorId");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Servers");
                });

            modelBuilder.Entity("OpenSim.Portal.Model.ServerPresentation", b =>
                {
                    b.Property<int>("ServerId");

                    b.Property<int>("PresentationId");

                    b.HasKey("ServerId", "PresentationId");

                    b.HasIndex("PresentationId");

                    b.ToTable("ServerPresentation");
                });

            modelBuilder.Entity("OpenSim.Portal.Model.ServerSimulation", b =>
                {
                    b.Property<int>("ServerId");

                    b.Property<int>("SimulationId");

                    b.HasKey("ServerId", "SimulationId");

                    b.HasIndex("SimulationId");

                    b.ToTable("ServerSimulation");
                });

            modelBuilder.Entity("OpenSim.Portal.Model.Simulation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("AuthorId");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Simulations");
                });

            modelBuilder.Entity("OpenSim.Portal.Model.SimulationPresentation", b =>
                {
                    b.Property<int>("SimulationId");

                    b.Property<int>("PresentationId");

                    b.HasKey("SimulationId", "PresentationId");

                    b.HasIndex("PresentationId");

                    b.ToTable("SimulationPresentation");
                });

            modelBuilder.Entity("OpenSim.Portal.Model.SimulationReference", b =>
                {
                    b.Property<int>("SimulationId");

                    b.Property<int>("ReferenceId");

                    b.HasKey("SimulationId", "ReferenceId");

                    b.HasIndex("ReferenceId");

                    b.ToTable("SimulationReference");
                });

            modelBuilder.Entity("OpenSim.Portal.Model.ServerPresentation", b =>
                {
                    b.HasOne("OpenSim.Portal.Model.Presentation", "Presentation")
                        .WithMany()
                        .HasForeignKey("PresentationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OpenSim.Portal.Model.Server", "Server")
                        .WithMany()
                        .HasForeignKey("ServerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OpenSim.Portal.Model.ServerSimulation", b =>
                {
                    b.HasOne("OpenSim.Portal.Model.Server", "Server")
                        .WithMany()
                        .HasForeignKey("ServerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OpenSim.Portal.Model.Simulation", "Simulation")
                        .WithMany()
                        .HasForeignKey("SimulationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OpenSim.Portal.Model.SimulationPresentation", b =>
                {
                    b.HasOne("OpenSim.Portal.Model.Presentation", "Presentation")
                        .WithMany()
                        .HasForeignKey("PresentationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OpenSim.Portal.Model.Simulation", "Simulation")
                        .WithMany()
                        .HasForeignKey("SimulationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OpenSim.Portal.Model.SimulationReference", b =>
                {
                    b.HasOne("OpenSim.Portal.Model.Simulation", "Reference")
                        .WithMany()
                        .HasForeignKey("ReferenceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OpenSim.Portal.Model.Simulation", "Simulation")
                        .WithMany()
                        .HasForeignKey("SimulationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
