open Fable.Remoting.Giraffe
open Fable.Remoting.Server
open Saturn
open Shared

let getAdjective () =
  let adjectives = [ "cool" ; "fun" ; "fresh" ; "hip"; "wicked"; "awesome"; "random"; "good"; "nice" ]
  adjectives[(System.Random().Next adjectives.Length)]

let adjectivesApi : IAdjectivesApi = {
  getAdjective = fun () ->
    async {
      return (getAdjective ())
    }
  }

let webApp =
  Remoting.createApi ()
  |> Remoting.withRouteBuilder Route.builder
  |> Remoting.fromValue adjectivesApi
  |> Remoting.buildHttpHandler

let app =
  application {
    use_router webApp
  }

run app
