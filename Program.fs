// Learn more about F# at http://fsharp.org

open System
open Suave

[<EntryPoint>]
let main argv =
    startWebServer defaultConfig (Successful.OK "Hello World from Suave!")
    0 // return an integer exit code
