using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace Infrastrucure.Context
{
    public class ContextSeed
    {
        private static DBContext _dbContext;
        private static IServiceProvider _serviceProvider;
        public static void Seed(DBContext appDbContext, IServiceProvider serviceProvider , IConfiguration configuration)
        {
            _dbContext = appDbContext;
            _dbContext.Database.EnsureCreated();
            _serviceProvider = serviceProvider;

            SeedInputType();
            SeedLK_IdeaCategory();
            SeedLk_RequestStage();
            if (configuration.GetSection("IsSeedData").Get<bool>())
            { SeedIdeaBank(); }
        }

        private static void SeedInputType()
        {
            string InputTypesJson = File.ReadAllText(@"SeedData" + Path.DirectorySeparatorChar + "InputTypeSeedData.json");
            var InputTypes = JsonConvert.DeserializeObject<List<LK_InputType>>(InputTypesJson);

            if (InputTypes != null && InputTypes.Any())
            {
                _dbContext.Database.OpenConnection();
                try
                {
                    if (!_dbContext.LK_InputTypes.Any())
                    {
                        foreach (var InputType in InputTypes)
                        {
                            InputType.CreatedOn = DateTime.Now;
                        }

                        _dbContext.LK_InputTypes.AddRange(InputTypes);
                        _dbContext.SaveChanges();
                    }
                    else
                    {
                        var existingInputTypes = _dbContext.LK_InputTypes.ToList();
                        var newInputTypes = InputTypes
                            .Where(na => existingInputTypes.Any(ea => ea.NameEn == na.NameEn))
                            .ToList();

                        if (!newInputTypes.Any())
                        {
                            foreach (var InputType in newInputTypes)
                            {
                                InputType.CreatedOn = DateTime.Now;
                            }

                            _dbContext.LK_InputTypes.AddRange(newInputTypes);
                            _dbContext.SaveChanges();
                        }
                    }
                }
                finally
                {
                    _dbContext.Database.CloseConnection();
                }
            }
        }
        private static void SeedLK_IdeaCategory()
        {

            string LK_IdeaCategoryJson = File.ReadAllText(@"SeedData" + Path.DirectorySeparatorChar + "LK_IdeaCategorySeedData.json");
            var LK_IdeaCategories = JsonConvert.DeserializeObject<List<LK_IdeaCategory>>(LK_IdeaCategoryJson);

            if (LK_IdeaCategories != null && LK_IdeaCategories.Any())
            {
                _dbContext.Database.OpenConnection();
                try
                {
                   // _dbContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [4EPlatform.KnowledgeManagement.IdeaBank].[dbo].[LK_IdeaCategories] ON");
                    if (!_dbContext.LK_IdeaCategories.Any())
                    {
                        foreach (var LK_IdeaCategory in LK_IdeaCategories)
                        {
                            LK_IdeaCategory.CreatedOn = DateTime.Now;
                        }

                        _dbContext.LK_IdeaCategories.AddRange(LK_IdeaCategories);

                        _dbContext.SaveChanges();
                    }
                    else
                    {
                        var existingLK_IdeaCategoriess = _dbContext.LK_IdeaCategories.ToList();
                        var newLK_IdeaCategoriess = LK_IdeaCategories
                            .Where(na => !existingLK_IdeaCategoriess.Any(ea => ea.Id == na.Id))
                            .ToList();

                        if (newLK_IdeaCategoriess.Any())
                        {
                            foreach (var LK_IdeaCategory in newLK_IdeaCategoriess)
                            {
                                LK_IdeaCategory.CreatedOn = DateTime.Now;
                            }

                            _dbContext.LK_IdeaCategories.AddRange(newLK_IdeaCategoriess);
                            _dbContext.SaveChanges();
                        }
                    }
                }
                catch (Exception ex) 
                {
                    _dbContext.Database.CloseConnection();
                }
            }

        }

        private static void SeedLk_RequestStage()
        {

            string Lk_RequestStageJson = File.ReadAllText(@"SeedData" + Path.DirectorySeparatorChar + "Lk_RequestStageSeedData.json");
            var Lk_RequestStages = JsonConvert.DeserializeObject<List<Lk_RequestStage>>(Lk_RequestStageJson);

            if (Lk_RequestStages != null && Lk_RequestStages.Any())
            {
                _dbContext.Database.OpenConnection();
                try
                {
                    _dbContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [4EPlatform.KnowledgeManagement.IdeaBank].[dbo].[Lk_RequestStages] ON");
                    if (!_dbContext.Lk_RequestStages.Any())
                    {
                        foreach (var Lk_RequestStage in Lk_RequestStages)
                        {
                            Lk_RequestStage.CreatedOn = DateTime.Now;
                        }

                        _dbContext.Lk_RequestStages.AddRange(Lk_RequestStages);

                        _dbContext.SaveChanges();
                    }
                    else
                    {
                        var existingLk_RequestStages = _dbContext.Lk_RequestStages.ToList();
                        var newLLk_RequestStages= Lk_RequestStages
                            .Where(na => !existingLk_RequestStages.Any(ea => ea.Id == na.Id))
                            .ToList();

                        if (newLLk_RequestStages.Any())
                        {
                            foreach (var Lk_RequestStage in newLLk_RequestStages)
                            {
                                Lk_RequestStage.CreatedOn = DateTime.Now;
                            }

                            _dbContext.Lk_RequestStages.AddRange(newLLk_RequestStages);
                            _dbContext.SaveChanges();
                        }
                    }

                    _dbContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [4EPlatform.KnowledgeManagement.IdeaBank].[dbo].[Lk_RequestStages] OFF");
                }
                catch (Exception ex)
                {
                    _dbContext.Database.CloseConnection();
                }
            }

        }

        private static void SeedIdeaBank()
        {

            string IdeaBankSeedDatajson = File.ReadAllText(@"SeedData" + Path.DirectorySeparatorChar + "IdeaBankSeedData.json");
            var IdeaBanks = JsonConvert.DeserializeObject<List<IdeaBank.Domain.Models.IdeaBank>>(IdeaBankSeedDatajson);

            if (IdeaBanks != null && IdeaBanks.Any())
            {
                _dbContext.Database.OpenConnection();
                try
                {
        
                    if (!_dbContext.IdeaBanks.Any())
                    {
                        foreach (var idea in IdeaBanks)
                        {
                            idea.CreatedOn = DateTime.Now;
                            if (idea.IdeaAttachments != null)
                            {
                                foreach (var att in idea.IdeaAttachments)
                                {
                                    att.CreatedOn = DateTime.Now;
                                }
                            }
                            if (idea.IdeaComments != null)
                            {
                                foreach (var att in idea.IdeaComments)
                                {
                                    att.CreatedOn = DateTime.Now;
                                }
                            }
                            if (idea.IdeaLikes != null)
                            {
                                foreach (var att in idea.IdeaLikes)
                                {
                                    att.CreatedOn = DateTime.Now;
                                }
                            }
                            if (idea.IdeaRates != null)
                            {
                                foreach (var att in idea.IdeaRates)
                                {
                                    att.CreatedOn = DateTime.Now;
                                }
                            }
                        }

                        _dbContext.IdeaBanks.AddRange(IdeaBanks);

                        _dbContext.SaveChanges();
                    }
                    
                }
                catch (Exception ex)
                {
                    _dbContext.Database.CloseConnection();
                }
            }

        }
    }
}
