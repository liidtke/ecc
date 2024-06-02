module Pages.Target

open Domain
open Falco
open Falco.Routing
open Falco.Markup
open Pages.Components
open Application

let top =
    [ Elem.h1 [ acl "header" ] [ txt "Tipos de Agendamento" ]
      Elem.p [ acl "text-sm" ] [ txt "Defina os tipos de agendamentos disponíveis" ]
      Elem.div [ acl "divider" ] [] ]


let listing () = Elem.div [ acl "content" ] []
let adding () = Elem.div [ acl "content" ] []
let editing () = Elem.div [ acl "content" ] []

let home =
    top @ [ listing () ]
    |> page "Tipos de Agendamento"
    |> Response.ofHtml

let homeEndpoint = get "/app/tipos-agendamento" home


let endpoints = [ homeEndpoint ]
