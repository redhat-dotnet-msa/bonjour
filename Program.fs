// Learn more about F# at http://fsharp.org

open Suave;

let cfg = 
  { defaultConfig with bindings = [ HttpBinding.createSimple HTTP "0.0.0.0" 5000 
             ] }

[<EntryPoint>]
startWebServer cfg (Successful.OK "Hello World from F#!")
