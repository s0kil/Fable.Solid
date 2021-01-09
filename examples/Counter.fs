// https://codesandbox.io/s/8no2n9k94l
module Counter

open Fable.Solid
open Fable.Solid.Web
open Browser.Dom

let App () =
    let (count, setCount) = createSignal (0)

    let timer =
        window.setInterval ((fun () -> setCount (count () + 1)), 1000, [])

    onCleanup (fun () -> window.clearInterval (timer))

    Html.div (Html.text (count ()))

render App (document.querySelector "#root")
