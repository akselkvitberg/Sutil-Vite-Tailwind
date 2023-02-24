module App

open Fable.Core.JsInterop
open Fable.Remoting.Client
open Shared
open Sutil
open Sutil.Styling

importAll "./index.css"


let adjectivesApi =
  Remoting.createApi ()
  |> Remoting.withRouteBuilder Route.builder
  |> Remoting.buildProxy<IAdjectivesApi>

type Msg =
  | AdjectiveChanged of string
  | AdjectiveChangeRequested

type Model =
  { Adjective : string }

let getAdjective m = m.Adjective

let init () =
  { Adjective = "" }, Cmd.ofMsg AdjectiveChangeRequested

let update msg model =
  match msg with
  | AdjectiveChanged a -> { model with Adjective = a }, Cmd.none
  | AdjectiveChangeRequested ->
      model, Cmd.OfAsync.perform adjectivesApi.getAdjective () AdjectiveChanged


let app () =
    let model, dispatch = () |> Store.makeElmish init update ignore

    Html.divc "flex flex-col gap-5 text-lg text-red-500 font-bold" [
      text "hello"
        //Bind.fragment (model |> Store.map getAdjective <| fun a -> Html.text $"Sutil is {a}!")
    ]

app () |> Program.mountElement "sutil-app"
