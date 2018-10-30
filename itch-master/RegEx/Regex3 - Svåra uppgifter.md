## Route och HttpGet/Post

Ersätt

    [Route("GetCustomer"), HttpGet]

med

    [HttpGet("GetCustomer")]

och ersätt

    [Route("GetCustomer"), HttpPost]

med

    [HttpPost("GetCustomer")]




## Dubbelord 

Ersätt "dubbelord" med ett ord. T.ex omvandla:

    I skogen finns en PandaPanda som äteräter bambu bambu

...till 

    I skogen finns en Panda som äter bambu bambu


## Dubbletter av ord 

Ta bort dubbletter av ord i en textfil 

T.ex

    I skogenskogen finns en Panda Panda som äter bambu bambu

Omvandlas till

    I skogenskogen finns en Panda som äter bambu



## Duplicerade rader 

Ta bort duplicerade rader i en textfil.

T.ex

    I skogen finns en Panda
    I skogen finns en Panda
    som äter
    som äter
    som äter
    bambu

Omvandlas till

    I skogen finns en Panda
    som äter
    bambu



## Konstskola.html - bara paragrafer (svår!)

Kolla i konstskola.html. Gör om alla taggar till p-taggar . 

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
    oo@happybåts.se
    oo@happybits
    oo.happybits.se
    oo..@happybits.se
    oo@happybits..se
    oo.@happybits.se
    .oo@happybits.se
    oo.@happybits.se.
    oo@happybits.seeek

## Epost II

Skriv ett C#-program som plockar ut epostnamnet, hostnamnet och topdomänen ur epostadressen. Alltså:

oscar.olsson.svensson@hej.stendahls.se =>

	Namn: oscar.olsson.svensson
	Host: hej.stendahls
	Topdomän: se

## Extra 

Formulera en egen uppgift för att ersätta/ta bort text ur en textfil. Lös uppgiften. Redovisa för din lärare.