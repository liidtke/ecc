module Pages.Login

open Falco
open Falco.Routing
open Falco.Markup
open Falco.Markup.Attr

let main () =
    Elem.section
        [ acl "p-section" ]
        [
          Elem.form
              [ acl "row--25-75" ]
              [
                Elem.h2 [] [ txt "Realizar Login" ]
                Elem.label [ aFor "username"; acl "" ] [ txt "Email" ]
                Elem.input
                    [ aType "email"
                      aid "username"
                      name "username"
                      Attr.placeholder "email@site.com" ]
                Elem.label [ aFor "pwd"; acl "" ] [ txt "Senha" ]
                Elem.input [ aType "password"; aid "pwd"; name "pwd" ] ]

          ]

let homePage () = page "Home" <| main ()

let home = get "/login" (Response.ofHtml <| homePage ())
let endpoints = [ home ]
