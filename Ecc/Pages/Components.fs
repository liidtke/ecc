[<AutoOpen>]
module Pages.Components

open Falco.Markup
open Falco.Markup.Elem

let acl = Attr.class'
let aid = Attr.id
let txt = Text.raw
let hxGet = Attr.create "hx-get"
let hxPost = Attr.create "hx-post"
let hxSwap = Attr.create "hx-swap"
let hxTrigger = Attr.create "hx-trigger"
let hxTarget = Attr.create "hx-target"
let hxSelect = Attr.create "hx-select"
let hxIndicator = Attr.create "hx-indicator"
let hxPush = Attr.create "hx-push-url" <| "true"
let swapOuter = hxSwap "outerHTML"
let hypr = Attr.create "_"

let place = Attr.placeholder
let tp = Attr.type'

let icon name = svg [Attr.create "data-icon" <| "SpotSearch"; acl "native"] []

let hero title content = section [acl "p-section--hero"] [
    div [acl "row"] [
        div [acl "col"] [Elem.div [acl "p-section--shallow"] [Elem.h1 [] [txt title]; Elem.p [] [txt content]; hr [acl "p-rule--muted"]]]
    ]
]

let header () = header [acl "p-navigation is-dark"] [
    div [acl "p-navigation__row"] [
        div [acl "p-navigation__banner"] [
            div [acl "p-navigation__tagged-logo"] [
                a [acl "p-navigation__link"; Attr.href "/app"] [
                    div [acl "p-navigation__logo-tag"] [
                      img [acl "p-navigation__logo-icon"; Attr.alt ""; Attr.src "https://assets.ubuntu.com/v1/82818827-CoF_white.svg"]
                    ]
                    Elem.span [acl "p-navigation__logo__title"] [txt "ECC - Gerenciador"]
                ]
            ]
        ]
        div [acl "p-navigation__nav"] [
            ul [acl "p-navigation__items"] [
                li [acl "p-navigation__item"] [Elem.a [acl "p-navigation__link"; Attr.href "/people" ] [txt "Pessoas"]]
                li [acl "p-navigation__item"] [Elem.a [acl "p-navigation__link"; Attr.href "/users" ] [txt "Usuários"]]
            ]
            ul [acl "p-navigation__items"] [
                li [acl "p-navigation__item"] [Elem.a [acl "p-navigation__link"; Attr.href "/entrar" ] [txt "Entrar"]]
            ]
        ]
    ]
] 

let toToaster (output: ServiceOutput<'t>) =
    let boxClass =
        match output with
        | Success foo -> "dark"
        | Failure errorResult -> "warning"

    let message =
        match output with
        | Success s -> "Salvo com Sucesso"
        | Failure f -> "Erro: " + f.ErrorMessage

    div
        [ acl "toaster-wrapper"; Attr.id "message" ]
        [ div
              [ acl $"toast toast--{boxClass} ml-0 mr-0 mxw-30"
                hypr "init wait 2s transition my opacity to 0% over 1 seconds then hide me" ]
              [ txt message ] ]

