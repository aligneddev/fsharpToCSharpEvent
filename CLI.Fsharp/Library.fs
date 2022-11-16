namespace CLI.Fsharp

type HelloEvent = 
    | Hi of string
    | Goodbye of string

module Say =
    type HelloHandler() = 
        let changed = new Event<HelloEvent>()

        [<CLIEvent>]
        member this.ChangedEvent = changed.Publish

        member this.Hello helloEvent =
            printfn "Hello %s" (helloEvent.ToString())
            changed.Trigger(helloEvent)
