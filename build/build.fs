open Fake.Core
open Fake.DotNet
open Fake.JavaScript

let execContext = Context.FakeExecutionContext.Create false "build.fsx" [ ]
Context.setExecutionContext (Context.RuntimeContext.Fake execContext)

// *** Define Targets ***
Target.create "Clean" (fun p ->
    Trace.trace " --- Cleaning stuff --- "
)

Target.create "Restore-Dotnet-Tools" (fun p ->
    DotNet.exec (fun p -> p) "tool" "restore" |> ignore
)

Target.create "Install-Npm" (fun p ->
    Npm.install (fun o -> {o with WorkingDirectory = "../src/Client"})
)

Target.create "Run" (fun _ ->
    Trace.trace " --- Building the app --- "
    let client =
        async {
            DotNet.exec (fun o -> { o with WorkingDirectory = "../src/Client"}) "fable" "watch -o js --sourceMaps --runFast vite" |> ignore
        }
    let server =
        async {
            DotNet.exec (fun p -> {p with WorkingDirectory = "../src/Server"}) "watch" "run" |> ignore
        }
        
    let openBrowser =
        async {
            System.Threading.Thread.Sleep(5000)
            System.Diagnostics.Process.Start("http://localhost:8080") |> ignore

        }
        
    Async.Parallel [|client; server; openBrowser|]
    |> Async.RunSynchronously
    |> ignore
)

Target.create "Deploy" (fun _ ->
    Trace.trace " --- Deploying app --- "
)

open Fake.Core.TargetOperators

let dependencies = [
  "Clean"
    //==> "Install-Npm"
    ==> "Run"
]

// *** Start Build ***
[<EntryPoint>]
let main args =
  Target.initEnvironment()
  Target.runOrDefault "Run" |> ignore
  0
