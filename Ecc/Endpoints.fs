module Endpoints

let handlers =
    []
    @ Pages.Login.endpoints
    @ Pages.App.endpoints
    @ Pages.Person.endpoints
