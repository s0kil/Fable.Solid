module Fable.Solid

open Fable.Core

[<Import("createSignal", from = "solid-js")>]
let inline createSignal (value: 'a): (unit -> 'a) * ('a -> 'a) = jsNative

[<Import("createState", from = "solid-js")>]
let inline createState (value: 'a): ('a) * ('a -> unit) = jsNative

[<Import("createEffect", from = "solid-js")>]
let inline createEffect (fn: 'a -> 'b) = jsNative

[<Import("onCleanup", from = "solid-js")>]
let inline onCleanup (fn: unit -> unit) = jsNative
