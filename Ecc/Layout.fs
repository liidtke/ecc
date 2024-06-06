[<AutoOpen>]
module Layout

open Falco.Markup
open Falco.Markup.Attr

let html title body =
    Elem.html
        [ create "data-theme" <| "light" ]
        [ Elem.head
              []
              [ Elem.meta
                    [ name "viewport"
                      content "width=device-width, initial-scale=1, maximum-scale=1, user-scalable=0" ]
                Elem.meta [ charset "UTF-8" ]
                Elem.link
                    [ href "https://fonts.googleapis.com/css?family=Lato:400,700"
                      rel "stylesheet" ]
                Elem.link [ href "/static/app.css"; rel "stylesheet" ]
                Elem.link
                    [ href "https://assets.ubuntu.com/v1/vanilla-framework-version-4.11.0.min.css"
                      type' "text/css"
                      rel "stylesheet" ]
                // Elem.link
                //     [ href "https://cdn.jsdelivr.net/npm/@picocss/pico@1/css/pico.min.css"
                //       type' "text/css"
                //       rel "stylesheet" ]
                Elem.link
                    [ href "https://fonts.googleapis.com/css?family=Nunito+Sans:200,300,400,600,700"
                      rel "stylesheet" ]
                Elem.link
                    [ href "https://fonts.googleapis.com/css?family=Montserrat:400,700"
                      rel "stylesheet" ]
                // Elem.link
                //     [ href "https://cdn.jsdelivr.net/npm/flatpickr/dist/flatpickr.min.css"
                //       rel "stylesheet" ]
                Elem.script [ src "https://unpkg.com/@stackoverflow/stacks-icons/dist/browser.umd.js" ] []
                Elem.script [ src "/static/app.js" ] []
                Elem.script [ src "https://unpkg.com/htmx.org@1.9.7" ] []
                Elem.script [ src "https://unpkg.com/hyperscript.org@0.9.7" ] []
                // Elem.script [ src "https://cdn.jsdelivr.net/npm/flatpickr" ] []
                Elem.title [] [ Text.raw title ] ]
          Elem.body [] body ]

let page title ct =
    let main =
        (Elem.div [acl "p-strip is-shallow u-no-padding--bottom"] [ct]) :: [ Elem.div [ aid "message"; acl "toaster-wrapper" ] [] ]
        |> Elem.main [ acl "l-main row" ]

    html title [ header (); main ]

let page2 title ct = page title <| Elem.div [] ct

let notAuthorized =
    [ Elem.section
          [ Attr.class' "p-section--hero" ]
          [

            Elem.p [] [ Text.raw "Não Autorizado" ]
            Elem.a [ Attr.class' "p-button"; Attr.href "/login" ] [ Text.raw "Realizar Login" ] ] ]
    |> html "Não Autorizado"
