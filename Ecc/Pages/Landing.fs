module Pages.Landing

open Falco
open Falco.Routing
open Falco.Markup
open Falco.Markup.Attr
open Pages.Components

let main () =
    Elem.main
        [acl "l-main"]
        [ Elem.div
              [ acl "p-row" ]
              [ Elem.section [ acl "p-strip is-bordered" ] [ Elem.h2 [] [ txt "Realizar Login" ] ]

                ] ]

let homePage () = page2 "Home" <| main ()

let home = get "/login" (Response.ofHtml <| homePage ())
let endpoints = [ home ]
