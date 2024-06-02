module Pages.App

open Falco.Markup
open Falco
open Falco.Routing
open Falco.Markup
open Falco.Markup.Attr
open Pages.Components


let homeContent =
    Elem.main [] [
    // Elem.h2 [] [txt "Welcome Home"]
    hero "Gerenciador do ECC" "Bem vindo ao novo gerenciador do ECC. Este site visa facilitar o cadastro de dados usados no encontro de casais"
    Elem.button [acl "btn"] [txt "oioi"]
]

let app = html "Home" [homeContent]

let home = get "/" (Response.ofHtml <| app )
let endpoints = [ home ]
