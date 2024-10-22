﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using managers_back.src.context;

#nullable disable

namespace managers_back.Migrations
{
    [DbContext(typeof(ApiContext))]
    [Migration("20241022215955_start")]
    partial class start
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("managers_back.src.managers.ManagerModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManagerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("Rank")
                        .HasColumnType("bigint");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stacks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Managers");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Description = "...",
                            ManagerName = "Andre Stamare",
                            RoleName = "FullStack Developer",
                            Stacks = "[\"C#\",\"Reactjs\",\"PostgreSQL\",\"Kafka\"]"
                        },
                        new
                        {
                            Id = 2L,
                            Description = "DDS",
                            ManagerName = "Thiago Vasconcelos",
                            RoleName = "Frontend Developer",
                            Stacks = "[\"HTML\",\"CSS\",\"SASS\",\"Javascript\",\"Typescript\",\"Jest\",\"MDX\",\"ExpressJS\",\"Copilot\",\"Storybook\"]"
                        },
                        new
                        {
                            Id = 3L,
                            Description = "Microfront ends ",
                            ManagerName = "Guilherme Choque",
                            RoleName = "Fullstack Developer",
                            Stacks = "[\"C#\",\"Angular\"]"
                        },
                        new
                        {
                            Id = 4L,
                            Description = "Microfront ends ",
                            ManagerName = "Guilherme Choque",
                            RoleName = "Fullstack Developer",
                            Stacks = "[\"C#\",\"Angular\"]"
                        },
                        new
                        {
                            Id = 5L,
                            Description = "Opal",
                            ManagerName = "Alexandre Pimentel",
                            RoleName = "Backend Developer",
                            Stacks = "[\"Java\",\"Springboot\",\"RabbitMQ\",\"MongoDB\",\"React\",\"PostgreSQL\",\"Python\"]"
                        },
                        new
                        {
                            Id = 6L,
                            Description = "...",
                            ManagerName = "Stefan Albuquerque",
                            RoleName = "Fullstack Developer",
                            Stacks = "[\"ReactJs\",\"Angular\",\"WordPress\",\"Python\",\".NET Core\",\"Springboot\",\"Java\",\"SQL\",\"MSSQL Type ORM\"]"
                        },
                        new
                        {
                            Id = 7L,
                            Description = "...",
                            ManagerName = "Valdomiro Rischtter",
                            RoleName = "Fullstack Developer",
                            Stacks = "[\"C#\",\".NET Core\",\"Angular\",\"Javascript\",\"Typescript\",\"MongoDB\",\"SQL Server\"]"
                        },
                        new
                        {
                            Id = 8L,
                            Description = "...",
                            ManagerName = "Marco Hinz",
                            RoleName = "Backend Developer",
                            Stacks = "[\"Java\",\"Springboot\",\"Codeium\",\"CI/CD\",\"RabbitMQ\",\"MongoDB\",\"Pivotal Cloud Foundry\",\"Kubernetes\",\"Kafka\"]"
                        },
                        new
                        {
                            Id = 9L,
                            Description = "...",
                            ManagerName = "Luciano Santos",
                            RoleName = "???????",
                            Stacks = "[\"??\",\"???\",\"????\"]"
                        },
                        new
                        {
                            Id = 10L,
                            Description = "Asset Team",
                            ManagerName = "Fernanda Gomes",
                            RoleName = "Backend - DevOps",
                            Stacks = "[\"Java\",\"Springboot\",\"Cloud Foundry\",\"Angular\",\"Oracle\",\"Kafka\",\"Nodejs\",\"Typescript\",\"DDS\",\"Kubernetes\",\"RabbitMQ\",\"Redis\",\"MongoDB\"]"
                        },
                        new
                        {
                            Id = 11L,
                            Description = "...",
                            ManagerName = "Leo Tessman",
                            RoleName = "Backend Developer",
                            Stacks = "[\"Java\",\"Oracle\",\"Microservices\",\"Springboot\",\"Kafka\",\"Elastic\",\"GraphQL\",\"Pivotal Cloud Foundry\",\"Conductor\",\"RabbitMQ\"]"
                        },
                        new
                        {
                            Id = 12L,
                            Description = "Banzai",
                            ManagerName = "Luciane Furini",
                            RoleName = "Fullstack Developer",
                            Stacks = "[\"C#\",\".NET Core\",\"Javascript\",\"React\",\"MongoDB\",\"SQL Server\"]"
                        },
                        new
                        {
                            Id = 13L,
                            Description = "...",
                            ManagerName = "Rafael Astrana",
                            RoleName = "Fullstack Developer",
                            Stacks = "[\"Java\",\"React\",\"Go\",\"Python\",\"PL/SQL\"]"
                        },
                        new
                        {
                            Id = 14L,
                            Description = "top1, pair programming",
                            ManagerName = "Cicero Furini",
                            RoleName = "Backend Developer",
                            Stacks = "[\"Java\",\"Springboot\",\"Pivotal Clound Foundry\",\"Oracle\",\"Elastic\",\"Redis\",\"GraphQL\",\"RabbitMQ\",\"Kafka\",\"Conductor\",\"Splunk\",\"Dynatrace\"]"
                        },
                        new
                        {
                            Id = 15L,
                            Description = "????",
                            ManagerName = "Francisco Letwinka",
                            RoleName = "???",
                            Stacks = "[\"??\",\"???\",\"????\"]"
                        },
                        new
                        {
                            Id = 16L,
                            Description = "...",
                            ManagerName = "Lilyan Fernande",
                            RoleName = "Fullstack Developer",
                            Stacks = "[\"Java\",\"React\",\"Go\",\"Python\",\"PL/SQL\",\"Typescript\",\"PostgreSQL\",\"AI/ML\",\"CI/CD\"]"
                        },
                        new
                        {
                            Id = 17L,
                            Description = "??",
                            ManagerName = "Gustavo Tourinho",
                            RoleName = "???",
                            Stacks = "[\"??\",\"???\",\"????\"]"
                        },
                        new
                        {
                            Id = 18L,
                            Description = "...",
                            ManagerName = "Bruno Souza",
                            RoleName = "DevOps",
                            Stacks = "[\"Python\",\"Javascript\",\"AIOps\",\"Data Science\",\"Analytics\",\"Bot and Conversation AI/Gen AI\"]"
                        },
                        new
                        {
                            Id = 19L,
                            Description = "Quicksilver",
                            ManagerName = "Tassia Borochede",
                            RoleName = "Frontend Developer",
                            Stacks = "[\"Nextjs\",\"React\",\"Typescript\",\"Node\"]"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
