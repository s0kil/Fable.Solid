module Counter

open Browser.Dom

open Solid
open Solid.Web

let ReactiveCounter =
    let (count, setCount) = createSignal (0)

    let timer =
        window.setInterval ((fun () -> setCount (count () + 1)), 1000, [])

    onCleanup (fun () -> window.clearInterval (timer))

    Html.div (count ())

let Application () = ReactiveCounter
render Application (document.querySelector "#root")
