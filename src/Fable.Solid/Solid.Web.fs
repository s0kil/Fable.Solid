module Solid.Web

open Fable.Core

type JSX = JSX

type Html =
    [<Emit("<div>{$0}</div>")>]
    static member inline div(value: string): JSX = jsNative
    [<Emit("<div>{$0}</div>")>]
    static member inline div(value: int): JSX = jsNative

[<Import("render", from = "solid-js/web")>]
let render (solidComponent: unit -> JSX) (rootElement: Browser.Types.Element) : unit = jsNative
