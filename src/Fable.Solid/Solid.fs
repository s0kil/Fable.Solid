module Solid

open Fable.Core

[<Import("createSignal", from = "solid-js")>]
let createSignal (value: 'a): (unit -> 'a) * ('a -> 'a) = jsNative

[<Import("onCleanup", from = "solid-js")>]
let onCleanup (fn: unit -> unit) = jsNative
