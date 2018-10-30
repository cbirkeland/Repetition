# Lab 4

G�r gr�nsnitt f�r en varukorg:

![](lab4-varukorg.PNG)

L�s inte varukorgen fr�n ett webapi

Tryck p� + => varans antal �kar med ett

Tryck p� - => varans antal minskar med ett

En vara f�r inte ha negativt antal

Det ska g� att skriva in antal varor i textrutorna ocks�.

Om en vara har noll antal => visa texten "NOLL".

Summera antalet varor.

## Tips

Skapa en endpoint som returnerar alla varor:

    [Route("products")]
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(new List<Product>
            {
                new Product {Name = "Skiftnyckel", Quantity = 5},
                new Product {Name = "Hammare", Quantity = 10},
                new Product {Name = "S�g", Quantity = 0}

            });
        }

    }