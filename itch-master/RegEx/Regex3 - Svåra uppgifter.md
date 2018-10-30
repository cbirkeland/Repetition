## Route och HttpGet/Post

Ers�tt

    [Route("GetCustomer"), HttpGet]

med

    [HttpGet("GetCustomer")]

och ers�tt

    [Route("GetCustomer"), HttpPost]

med

    [HttpPost("GetCustomer")]




## Dubbelord 

Ers�tt "dubbelord" med ett ord. T.ex omvandla:

    I skogen finns en PandaPanda som �ter�ter bambu bambu

...till 

    I skogen finns en Panda som �ter bambu bambu


## Dubbletter av ord 

Ta bort dubbletter av ord i en textfil 

T.ex

    I skogenskogen finns en Panda Panda som �ter bambu bambu

Omvandlas till

    I skogenskogen finns en Panda som �ter bambu



## Duplicerade rader 

Ta bort duplicerade rader i en textfil.

T.ex

    I skogen finns en Panda
    I skogen finns en Panda
    som �ter
    som �ter
    som �ter
    bambu

Omvandlas till

    I skogen finns en Panda
    som �ter
    bambu



## Konstskola.html - bara paragrafer (sv�r!)

Kolla i konstskola.html. G�r om alla taggar till p-taggar . 

T.ex:

    <a href="http://gbgkonstskola.se/" title="Home" rel="home">Home</a>

    till

    <p href="http://gbgkonstskola.se/" title="Home" rel="home">Home</p>

T.ex:

    <meta property="og:type" content="website" /> 

	till

    <p property="og:type" content="website"></p>



## Epost 

Validera epostadress

Ok:

    oo@happybits.se
    oscar.olsson@stendahls.se
    oscar.olsson.svensson@hej.stendahls.se

Inte ok:

    oscar
    @happybits.se
    oo@@happybits.se
    oo@happyb�ts.se
    oo@happybits
    oo.happybits.se
    oo..@happybits.se
    oo@happybits..se
    oo.@happybits.se
    .oo@happybits.se
    oo.@happybits.se.
    oo@happybits.seeek

## Epost II

Skriv ett C#-program som plockar ut epostnamnet, hostnamnet och topdom�nen ur epostadressen. Allts�:

oscar.olsson.svensson@hej.stendahls.se =>

	Namn: oscar.olsson.svensson
	Host: hej.stendahls
	Topdom�n: se

## Extra 

Formulera en egen uppgift f�r att ers�tta/ta bort text ur en textfil. L�s uppgiften. Redovisa f�r din l�rare.