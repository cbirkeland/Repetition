 private static void DemoAddSomeBattles()
        {
            using (var context = new SamuraiContext())
            {
                var b = new Battle
                {
                    Name = "Slaget vid Osaka",
                    Description = "Ett slag vid Osaka (såklart!)",
                    IsBrutal = true,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1),
                    BattleLog = new BattleLog
                    {
                        Name = "The diaries of Samurai Jim",
                        BattleEvents = new List<BattleEvent>
                        {
                            new BattleEvent
                            {
                                Summary = "Lasse dog",
                                Description = "Sorgligt",
                                Order = 0,
                            },
                            new BattleEvent
                            {
                                Summary = "Return of Lasse",
                                Description = "Alla glada",
                                Order = 1,
                            },
                        }
                    }
                };



                context.Battles.Add(b);
                context.SaveChanges();
            }
        }