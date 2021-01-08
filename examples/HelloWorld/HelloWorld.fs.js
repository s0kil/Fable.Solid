import { onCleanup, createSignal } from "solid-js";
import { empty } from "./.fable/fable-library.3.0.5/List.js";
import { render } from "solid-js/web";

export const ReactiveCounter = (() => {
    const patternInput = createSignal(0);
    const setCount = patternInput[1];
    const count = patternInput[0];
    const timer = window.setInterval(() => setCount(count() + 1), 1000, empty());
    onCleanup(() => {
        window.clearInterval(timer);
    });
    return <div>{count()}</div>;
})();

export function Application() {
    return ReactiveCounter;
}

render(Application, document.querySelector("#root"));

