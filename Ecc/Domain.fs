module Domain

open System

type Duration = int
type UserId = Guid

type ClientConfiguration = {
    clientId:Guid
    //config here
}

type User =
    { id: UserId
      name: string
      email: string
      password: string
      isAdmin:bool
      isVerified: bool }
