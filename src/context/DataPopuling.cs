using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using managers_back.src.managers;
using Microsoft.EntityFrameworkCore;

namespace managers_back.src.context
{
    public static class DataPopuling
    {
        private static List<ManagerModel> managers = new() {
            new () {
                Id = 1,
                ManagerName = "Andre Stamare",
                RoleName = "FullStack Developer",
                Stacks = new List<string>{"C#", "Reactjs", "PostgreSQL", "Kafka"},
                Description = "..."
            },
            new () {
                Id = 2,
                ManagerName = "Thiago Vasconcelos",
                RoleName = "Frontend Developer",
                Stacks = new List<string>{"HTML", "CSS", "SASS", "Javascript", "Typescript", "Jest", "MDX", "ExpressJS", "Copilot", "Storybook"},
                Description = "DDS"
            },
            new () {
                Id = 3,
                ManagerName = "Guilherme Choque",
                RoleName = "Fullstack Developer",
                Stacks = new List<string>{"C#", "Angular"},
                Description = "Microfront ends "
            },
            new () {
                Id = 4,
                ManagerName = "Guilherme Choque",
                RoleName = "Fullstack Developer",
                Stacks = new List<string>{"C#", "Angular"},
                Description = "Microfront ends "
            },
            new () {
                Id = 5,
                ManagerName = "Alexandre Pimentel",
                RoleName = "Backend Developer",
                Stacks = new List<string>{"Java", "Springboot", "RabbitMQ", "MongoDB", "React", "PostgreSQL", "Python"},
                Description = "Opal"
            },
            new () {
                Id = 6,
                ManagerName = "Stefan Albuquerque",
                RoleName = "Fullstack Developer",
                Stacks = new List<string>{"ReactJs", "Angular", "WordPress", "Python", ".NET Core", "Springboot", "Java", "SQL", "MSSQL Type ORM"},
                Description = "..."
            },
            new () {
                Id = 7,
                ManagerName = "Valdomiro Rischtter",
                RoleName = "Fullstack Developer",
                Stacks = new List<string>{"C#", ".NET Core", "Angular", "Javascript", "Typescript", "MongoDB", "SQL Server"},
                Description = "..."
            },
            new () {
                Id = 8,
                ManagerName = "Marco Hinz",
                RoleName = "Backend Developer",
                Stacks = new List<string>{"Java", "Springboot", "Codeium", "CI/CD", "RabbitMQ", "MongoDB", "Pivotal Cloud Foundry", "Kubernetes", "Kafka"},
                Description = "..."
            },
            new () {
                Id = 9,
                ManagerName = "Luciano Santos",
                RoleName = "???????",
                Stacks = new List<string>{"??", "???", "????"},
                Description = "..."
            },
            new () {
                Id = 10,
                ManagerName = "Fernanda Gomes",
                RoleName = "Backend - DevOps",
                Stacks = new List<string>{"Java", "Springboot", "Cloud Foundry", "Angular", "Oracle", "Kafka", "Nodejs", "Typescript", "DDS", "Kubernetes", "RabbitMQ", "Redis", "MongoDB"},
                Description = "Asset Team"
            },
            new () {
                Id = 11,
                ManagerName = "Leo Tessman",
                RoleName = "Backend Developer",
                Stacks = new List<string>{"Java", "Oracle", "Microservices", "Springboot", "Kafka", "Elastic", "GraphQL", "Pivotal Cloud Foundry", "Conductor", "RabbitMQ"},
                Description = "..."
            },
            new () {
                Id = 12,
                ManagerName = "Luciane Furini",
                RoleName = "Fullstack Developer",
                Stacks = new List<string>{"C#", ".NET Core", "Javascript", "React", "MongoDB", "SQL Server"},
                Description = "Banzai"
            },
            new () {
                Id = 13,
                ManagerName = "Rafael Astrana",
                RoleName = "Fullstack Developer",
                Stacks = new List<string>{"Java", "React", "Go", "Python", "PL/SQL"},
                Description = "..."
            },
            new () {
                Id = 14,
                ManagerName = "Cicero Furini",
                RoleName = "Backend Developer",
                Stacks = new List<string>{"Java", "Springboot", "Pivotal Clound Foundry", "Oracle", "Elastic", "Redis", "GraphQL", "RabbitMQ", "Kafka", "Conductor", "Splunk", "Dynatrace"},
                Description = "top1, pair programming"
            },
            new () {
                Id = 15,
                ManagerName = "Francisco Letwinka",
                RoleName = "???",
                Stacks = new List<string>{"??", "???", "????"},
                Description = "????"
            },
            new () {
                Id = 16,
                ManagerName = "Lilyan Fernande",
                RoleName = "Fullstack Developer",
                Stacks = new List<string>{"Java", "React", "Go", "Python", "PL/SQL", "Typescript", "PostgreSQL", "AI/ML", "CI/CD"},
                Description = "..."
            },
            new () {
                Id = 17,
                ManagerName = "Gustavo Tourinho",
                RoleName = "???",
                Stacks = new List<string>{"??", "???", "????"},
                Description = "??"
            },
            new () {
                Id = 18,
                ManagerName = "Bruno Souza",
                RoleName = "DevOps",
                Stacks = new List<string>{"Python", "Javascript", "AIOps", "Data Science", "Analytics", "Bot and Conversation AI/Gen AI"},
                Description = "..."
            },
            new () {
                Id = 19,
                ManagerName = "Tassia Borochede",
                RoleName = "Frontend Developer",
                Stacks = new List<string>{"Nextjs", "React", "Typescript", "Node"},
                Description = "Quicksilver"
            }
        };
        public static void Populate(this ModelBuilder modelBuilder) {
            modelBuilder.Entity<ManagerModel>()
                .HasData(managers);
        }
    }
}