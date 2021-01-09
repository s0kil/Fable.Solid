module Fable.Solid.Web

open Fable.Core

[<Erase>]
type JSX = JSX

[<Erase>]
type Html =
    [<Emit("$0")>]
    static member inline text(value: int): JSX = jsNative

    [<Emit("$0")>]
    static member inline text(value: float): JSX = jsNative

    [<Emit("$0")>]
    static member inline text(value: string): JSX = jsNative

    //    [<Emit("<>$0</>")>]
    //    static member inline fragment([<ParamArray>] jsx: JSX): JSX = jsNative

    [<Emit("<>{$0}</>")>]
    static member inline fragment(jsx: JSX seq): JSX = jsNative

    [<Emit("<div>$0</div>")>]
    static member inline div(jsx: JSX): JSX = jsNative

    [<Emit("<div>{$0}</div>")>]
    static member inline div(jsx: JSX seq): JSX = jsNative

    [<Emit("<h1>$0</h1>")>]
    static member inline h1(jsx: JSX): JSX = jsNative

    [<Emit("<h2>$0</h2>")>]
    static member inline h2(jsx: JSX): JSX = jsNative

    [<Emit("<h3>$0</h3>")>]
    static member inline h3(jsx: JSX): JSX = jsNative

    [<Emit("<h3>{$0}</h3>")>]
    static member inline h3(value: string): JSX = jsNative

    [<Emit("<h4>$0</h4>")>]
    static member inline h4(jsx: JSX): JSX = jsNative

    [<Emit("<h5>$0</h5>")>]
    static member inline h5(jsx: JSX): JSX = jsNative

    [<Emit("<h6>$0</h6>")>]
    static member inline h6(jsx: JSX): JSX = jsNative

[<Import("render", from = "solid-js/web")>]
let inline render (solidComponent: unit -> JSX) (rootElement: Browser.Types.Element): unit = jsNative
