import { Union } from "../../examples/HelloWorld/.fable/fable-library.3.0.5/Types.js";
import { class_type, union_type } from "../../examples/HelloWorld/.fable/fable-library.3.0.5/Reflection.js";

export class JSX extends Union {
    constructor(tag, ...fields) {
        super();
        this.tag = (tag | 0);
        this.fields = fields;
    }
    cases() {
        return ["JSX"];
    }
}

export function JSX$reflection() {
    return union_type("Solid.Web.JSX", [], JSX, () => [[]]);
}

export class Html {
    constructor() {
    }
}

export function Html$reflection() {
    return class_type("Solid.Web.Html", void 0, Html);
}

