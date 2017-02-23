// Learn more about F# at http://fsharp.org

open System.Net;
open Suave;

let cfg = 
  { defaultConfig with bindings = [ HttpBinding.createSimple HTTP "0.0.0.0" 5000 
             ] }

let strings = [ "Bonjour service (written in F#) running at http://"; Dns.GetHostName(); ":5000" ]
let response = System.String.Concat(strings)

[<EntryPoint>]
startWebServer cfg (Successful.OK response)
