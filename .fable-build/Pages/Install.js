import { createElement } from "react";
import * as react from "react";
import { Interop_reactApi } from "../fable_modules/Feliz.1.64.0/Interop.fs.js";
import { createObj } from "../fable_modules/fable-library.3.7.18/Util.js";
import { singleton, ofArray } from "../fable_modules/fable-library.3.7.18/List.js";

export function InstallView() {
    let arg_3, children, elems_2, arg_8, children_2, elems_6;
    const xs_8 = [createElement("div", {
        className: "description",
        children: Interop_reactApi.Children.toArray(["Using NuGet package command"]),
    }), (arg_3 = singleton((children = singleton(createElement("pre", createObj(ofArray([["data-prefix", "$"], (elems_2 = [createElement("code", {
        children: ["Install-Package Feliz.ChartJS"],
    })], ["children", Interop_reactApi.Children.toArray(Array.from(elems_2))])])))), createElement("div", {
        className: "mockup-code",
        children: Interop_reactApi.Children.toArray(Array.from(children)),
    }))), createElement("div", {
        className: "max-w-xl",
        children: Interop_reactApi.Children.toArray(Array.from(arg_3)),
    })), createElement("div", {
        className: "description",
        children: Interop_reactApi.Children.toArray(["or Paket"]),
    }), (arg_8 = singleton((children_2 = singleton(createElement("pre", createObj(ofArray([["data-prefix", "$"], (elems_6 = [createElement("code", {
        children: ["paket add Feliz.ChartJS"],
    })], ["children", Interop_reactApi.Children.toArray(Array.from(elems_6))])])))), createElement("div", {
        className: "mockup-code",
        children: Interop_reactApi.Children.toArray(Array.from(children_2)),
    }))), createElement("div", {
        className: "max-w-xl",
        children: Interop_reactApi.Children.toArray(Array.from(arg_8)),
    }))];
    return react.createElement(react.Fragment, {}, ...xs_8);
}

