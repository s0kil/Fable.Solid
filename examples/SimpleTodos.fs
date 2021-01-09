// https://codesandbox.io/s/lrm786ojqz
module SimpleTodos

open Fable.Solid
open Fable.Solid.Web
open Browser.Dom // https://github.com/fable-compiler/fable-browser
open Fable.SimpleJson // https://github.com/Zaid-Ajaj/Fable.SimpleJson

type Todos = string list
type State = { todos: Todos; newTitle: string }

let createLocalState (initialState: 'a) =
    let (state, setState) = createState (initialState)

    match window.localStorage.getItem ("todos") with
    | null -> () // No Operation
    | todosSerialized ->
        let todosDeserialized = todosSerialized |> Json.parseAs<Todos>
        setState ({ state with todos = todosDeserialized })

    createEffect
        (fun () ->
            let todosSerialized = Json.serialize state.todos
            window.localStorage.setItem ("todos", todosSerialized))

    (state, setState)

let App () =
    let (state, setState) =
        createLocalState ({ todos = []; newTitle = "" })

    Html.fragment [ Html.h3 "Simple Todos Example"; Html.h1 (Html.text "This Is Great!") ]


render App (document.querySelector "#root")


//        Html.input {
//            onClick = fun () -> printf "Hello"
//            classes = ["button"; "submit"]
//            value = "Input Button With Submit"
//        } []

// <>{(<h3>{"First"}</h3>), (<h3>{"Second"}</h3>)}</>;
// <>{[<h3>{"First"}</h3>, <h3>{"Second"}</h3>]}</>
