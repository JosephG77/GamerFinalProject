using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Collections.Generic;

namespace Finals.Models
{
    public static class SeeData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var db = new ProductsContext(serviceProvider.GetRequiredService<DbContextOptions<ProductsContext>>()))
            {
                if(db.Product.Any())
                {
                    return;
                }
                
                db.Product.AddRange(
                    new Product{
                        ProductName = "Halo Infinite",
                        Genre = "FPS/Adventure",
                        Price = 59.99M,
                        Rating = "Teen 13+",
                        Reviews = new List<Review>{
                            new Review {Score = 5},
                            new Review {Score = 5}
                        }

                    },

                    new Product{
                        ProductName = "BattleField 2042",
                        Genre = "FPS/Action",
                        Price = 69.99M,
                        Rating = "M",
                        Reviews = new List<Review>{
                            new Review {Score = 3},
                            new Review {Score = 2}
                        }
                    },

                    new Product{
                        ProductName = "COD: Vanguard",
                        Genre = "FPS/Action",
                        Price = 59.99M,
                        Rating = "M",
                        Reviews = new List<Review>{
                            new Review {Score = 2},
                            new Review {Score = 2}
                        }
                    },

                    new Product{
                        ProductName = "Doom Eternal",
                        Genre = "FPS/Action-Adventure",
                        Price = 19.99M,
                        Rating = "M",
                        Reviews = new List<Review>{
                            new Review {Score = 5},
                            new Review {Score = 4}
                        }
                    },

                    new Product{
                        ProductName = "GTA V",
                        Genre = "Action",
                        Price = 9.99M,
                        Rating = "M",
                        Reviews = new List<Review>{
                            new Review {Score = 4},
                            new Review {Score = 4}
                        }
                    },

                    new Product{
                        ProductName = "Assassins Creed Valhalla",
                        Genre = "Action/Adventure",
                        Price = 39.99M,
                        Rating = "M",
                        Reviews = new List<Review>{
                            new Review {Score = 3},
                            new Review {Score = 4}
                        }
                    },

                    new Product{
                        ProductName = "Assassins Creed Origins",
                        Genre = "Action/Adenture",
                        Price = 9.99M,
                        Rating = "M",
                        Reviews = new List<Review>{
                            new Review {Score = 4},
                            new Review {Score = 4}
                        }
                    },

                    new Product{
                        ProductName = "Xbox Series X",
                        Genre = "",
                        Price = 499.00M,
                        Rating = "E",
                        Reviews = new List<Review>{
                            new Review {Score = 5},
                            new Review {Score = 5}
                        }
                    },

                    new Product{
                        ProductName = "PS5 Disc Edition",
                        Genre = "",
                        Price = 499.00M,
                        Rating = "E",
                        Reviews = new List<Review>{
                            new Review {Score = 5},
                            new Review {Score = 5}
                        }
                    },

                    new Product{
                        ProductName = "Nintendo Switch OLED",
                        Genre = "",
                        Price = 329.99M,
                        Rating = "E",
                        Reviews = new List<Review>{
                            new Review {Score = 5},
                            new Review {Score = 4}
                        }
                    },

                    new Product{
                        ProductName = "Nintendo Switch",
                        Genre = "",
                        Price = 299.99M,
                        Rating = "E",
                        Reviews = new List<Review>{
                            new Review {Score = 4},
                            new Review {Score = 4}
                        }
                    },

                    new Product{
                        ProductName = "PS5 Digital Edition",
                        Genre = "",
                        Price = 399.00M,
                        Rating = "E",
                        Reviews = new List<Review>{
                            new Review {Score = 4},
                            new Review {Score = 4}
                        }
                    },

                    new Product{
                        ProductName = "Xbox Series S",
                        Genre = "",
                        Price = 299.00M,
                        Rating = "E",
                        Reviews = new List<Review>{
                            new Review {Score = 4},
                            new Review {Score = 4}
                        }
                    },

                    new Product{
                        ProductName = "Nintendo Switch Lite",
                        Genre = "",
                        Price = 199.99M,
                        Rating = "E",
                        Reviews = new List<Review>{
                            new Review {Score = 4},
                            new Review {Score = 4}
                        }

                    },

                    new Product{
                        ProductName = "BattleField 4",
                        Genre = "FPS/Action",
                        Price = 9.99M,
                        Rating = "M",
                        Reviews = new List<Review>{
                            new Review {Score = 4},
                            new Review {Score = 5}
                        }
                    },

                    new Product{
                        ProductName = "BattleField 3",
                        Genre = "FPS/Action",
                        Price = 2.99M,
                        Rating = "M",
                        Reviews = new List<Review>{
                            new Review {Score = 5},
                            new Review {Score = 5}
                        }
                    },

                    new Product{
                        ProductName = "COD: Modern Warfare",
                        Genre = "FPS/Action",
                        Price = 299.99M,
                        Rating = "M",
                        Reviews = new List<Review>{
                            new Review {Score = 5},
                            new Review {Score = 4}
                        }
                    },

                    new Product{
                        ProductName = "Halo",
                        Genre = "FPS/Action-Adventure",
                        Price = 0.99M,
                        Rating = "M",
                        Reviews = new List<Review>{
                            new Review {Score = 5},
                            new Review {Score = 5},
                            new Review {Score = 5}
                        }
                    },

                    new Product{
                        ProductName = "Ratchet & Clank: Rift Apart",
                        Genre = "Action/Adventure",
                        Price = 59.99M,
                        Rating = "Teen",
                        Reviews = new List<Review>{
                            new Review {Score = 4},
                            new Review {Score = 4},
                            new Review {Score = 5},
                            new Review {Score = 3}
                        }
                    }, 

                    new Product{
                        ProductName = "Ratchet & Clank",
                        Genre = "Action/Adventure",
                        Price = 9.99M,
                        Rating = "Teen",
                        Reviews = new List<Review>{
                            new Review {Score = 5},
                            new Review {Score = 4},
                            new Review {Score = 4}
                        }
                    },

                    new Product{
                        ProductName = "Back 4 Blood",
                        Genre = "FPS/Action",
                        Price = 49.99M,
                        Rating = "M",
                        Reviews = new List<Review>{
                            new Review {Score = 5},
                            new Review {Score = 4}
                        }
                    },

                    new Product{
                        ProductName = "Rust",
                        Genre = "Action/Survival",
                        Price = 49.99M,
                        Rating = "M",
                        Reviews = new List<Review>{
                            new Review {Score = 4},
                            new Review {Score = 3}
                        }
                    },

                    new Product{
                        ProductName = "PUBG",
                        Genre = "Battle Royale",
                        Price = 39.99M,
                        Rating = "M",
                        Reviews = new List<Review>{
                            new Review {Score = 3},
                            new Review {Score = 4},
                            new Review {Score = 4}
                        }
                    },

                    new Product{
                        ProductName = "Horizon Zero Dawn",
                        Genre = "Action/Adventure",
                        Price = 9.99M,
                        Rating = "Teen",
                        Reviews = new List<Review>{
                            new Review {Score = 5},
                            new Review {Score = 5},
                            new Review {Score = 4}
                        }
                    },

                    new Product{
                        ProductName = "The Last of Us",
                        Genre = "Action-Adventure/Drama",
                        Price = 9.99M,
                        Rating = "M",
                        Reviews = new List<Review>{
                            new Review {Score = 5},
                            new Review {Score = 5},
                            new Review {Score = 5}
                        }
                    },

                    new Product{
                        ProductName = "The Last of Us Part II",
                        Genre = "Action-Adventure/Drama",
                        Price = 29.99M,
                        Rating = "M",
                        Reviews = new List<Review>{
                            new Review {Score = 4},
                            new Review {Score = 3},
                            new Review {Score = 3}
                        }
                    }, 

                    new Product{
                        ProductName = "Mario Party Superstare",
                        Genre = "Party/Action Game",
                        Price = 59.99M,
                        Rating = "E",
                        Reviews = new List<Review>{
                            new Review {Score = 5},
                            new Review {Score = 5},
                            new Review {Score = 4}
                        }
                    }


                );

                 db.SaveChanges();

            }
        }
    }
}