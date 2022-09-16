import { createElement } from "react";
import * as react from "react";
import { Interop_reactApi } from "../fable_modules/Feliz.1.64.0/Interop.fs.js";
import { linedMockupCode } from "../SharedView.js";
import { ofArray, singleton } from "../fable_modules/fable-library.3.7.18/List.js";

export function UseView() {
    let arg_3, arg_5;
    const xs_4 = [createElement("div", {
        className: "description",
        children: Interop_reactApi.Children.toArray(["After installation just open proper namespace:"]),
    }), (arg_3 = singleton(linedMockupCode("open Feliz.ChartJS")), createElement("div", {
        className: "max-w-xl",
        children: Interop_reactApi.Children.toArray(Array.from(arg_3)),
    })), (arg_5 = ofArray(["Now you can start using library. Everything important starts with ", createElement("code", {
        className: "code",
        children: "ChartJS.*",
    }), " module."]), createElement("div", {
        className: "description",
        children: Interop_reactApi.Children.toArray(Array.from(arg_5)),
    }))];
    return react.createElement(react.Fragment, {}, ...xs_4);
}

