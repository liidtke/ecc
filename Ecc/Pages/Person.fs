module Pages.Person

open Domain
open Falco
open Falco.Routing
open Falco.Markup
open Application

let top =
    [ Elem.h1 [ acl "header" ] [ txt "Cadastro de Pessoas" ]
      Elem.p [ acl "" ] [ txt "Cadastrar" ]
      Elem.div [ acl "divider" ] [] ]


let listing () = Elem.div [ acl "content"; ] []
let adding () = Elem.div [ acl "content" ] []
let editing () = Elem.div [ acl "content" ] []

let home ctx () =
    top @ [ listing () ]
    |> page2 "Cadastro de Pessoas"
    |> succeed

let homeEndpoint = get "/pessoas" (runHtml home ())


let endpoints = [ homeEndpoint ]
