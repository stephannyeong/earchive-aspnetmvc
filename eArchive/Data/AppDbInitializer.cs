using eArchive.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eArchive.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Authors
                if (!context.Authors.Any())
                {
                    context.Authors.AddRange(new List<Author>()
                    {
                        new Author()
                        {
                            ProfilePictureURL = "https://i.ibb.co/1Jcv2kH/author-noimg.jpg",
                            AuthorName = "Jayne Ann Baliton",
                            Affiliation = "Don Mariano Marcos Memorial State University"
                        },

                        new Author()
                        {
                            ProfilePictureURL = "https://i.ibb.co/1Jcv2kH/author-noimg.jpg",
                            AuthorName = "Regine Joy Bayale",
                            Affiliation = "Don Mariano Marcos Memorial State University"
                        },

                        new Author()
                        {
                            ProfilePictureURL = "https://i.ibb.co/1Jcv2kH/author-noimg.jpg",
                            AuthorName = "Jashleen Kate Baldemor",
                            Affiliation = "Don Mariano Marcos Memorial State University"
                        },

                        new Author()
                        {
                            ProfilePictureURL = "https://i.ibb.co/1Jcv2kH/author-noimg.jpg",
                            AuthorName = "Ellen Esteban",
                            Affiliation = "Don Mariano Marcos Memorial State University"
                        },

                        new Author()
                        {
                            ProfilePictureURL = "https://i.ibb.co/1Jcv2kH/author-noimg.jpg",
                            AuthorName = "Cole Stephany Estrada",
                            Affiliation = "Don Mariano Marcos Memorial State University"
                        },

                        new Author()
                        {
                            ProfilePictureURL = "https://i.ibb.co/1Jcv2kH/author-noimg.jpg",
                            AuthorName = "Jerome Thievre",
                            Affiliation = "Institut National de l'Audiovisuel"
                        },

                        new Author()
                        {
                            ProfilePictureURL = "https://i.ibb.co/1Jcv2kH/author-noimg.jpg",
                            AuthorName = "Marie-Luce Viaud",
                            Affiliation = "Institut National de l'Audiovisuel"
                        },

                        new Author()
                        {
                            ProfilePictureURL = "https://i.ibb.co/1Jcv2kH/author-noimg.jpg",
                            AuthorName = "Anne Verroust-Blondet",
                            Affiliation = "Institut National de l'Audiovisuel"
                        }
                    });
                    context.SaveChanges();
                }

                //Researches
                if (!context.Researches.Any())
                {
                    context.Researches.AddRange(new List<Research>()
                    {
                        new Research()
                        {
                            Title = "OCR-Based Information Technology Research Compendium of DMMMSU-MLUC",
                            Abstract = "OCR Abstract",
                            Keywords = "OCR, Compendium",
                            PublishYear = "2023"
                        },

                        new Research()
                        {
                            Title = "Using Euler Diagrams in Traditional Library Environments",
                            Abstract = "Traditional Library Abstract",
                            Keywords = "Traditional, Library",
                            PublishYear = "2005",
                        }
                    });
                    context.SaveChanges();
                }

                //Authors & Researches
                if (!context.Authors_Researches.Any())
                {
                    context.Authors_Researches.AddRange(new List<Authors_Researches>()
                    {
                        new Authors_Researches()
                        {
                            AuthorId = 1,
                            ResearchId = 1
                        },

                        new Authors_Researches()
                        {
                            AuthorId = 2,
                            ResearchId = 1
                        },

                        new Authors_Researches()
                        {
                            AuthorId = 3,
                            ResearchId = 1
                        },

                        new Authors_Researches()
                        {
                            AuthorId = 4,
                            ResearchId = 1
                        },

                        new Authors_Researches()
                        {
                            AuthorId = 5,
                            ResearchId = 1
                        },

                        new Authors_Researches()
                        {
                            AuthorId = 6,
                            ResearchId = 2
                        },

                        new Authors_Researches()
                        {
                            AuthorId = 7,
                            ResearchId = 2
                        }
                    });
                    context.SaveChanges();
                }

            }
        }
    }
}
