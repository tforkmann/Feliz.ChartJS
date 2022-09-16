import { printf, toText, split } from "./fable_modules/fable-library.3.7.18/String.js";
import { empty, singleton, append, delay, toList, mapIndexed } from "./fable_modules/fable-library.3.7.18/Seq.js";
import { createElement } from "react";
import { int32ToString, createObj } from "./fable_modules/fable-library.3.7.18/Util.js";
import { Interop_reactApi } from "./fable_modules/Feliz.1.64.0/Interop.fs.js";
import { ofArray, singleton as singleton_1 } from "./fable_modules/fable-library.3.7.18/List.js";
import { Helpers_combineClasses } from "./fable_modules/Feliz.DaisyUI.2.1.0/DaisyUI.fs.js";

export function linedMockupCode(code) {
    const lines = split(code, ["\n"], null, 0);
    const children = mapIndexed((i, l) => createElement("pre", createObj(toList(delay(() => append(singleton(["data-prefix", int32ToString(i + 1)]), delay(() => append((l.indexOf("// ") >= 0) ? singleton(["className", "text-warning"]) : empty(), delay(() => {
        let elems;
        return singleton((elems = [createElement("code", {
            children: [l],
        })], ["children", Interop_reactApi.Children.toArray(Array.from(elems))]));
    })))))))), lines);
    return createElement("div", {
        className: "mockup-code",
        children: Interop_reactApi.Children.toArray(Array.from(children)),
    });
}

export function codedView(title, code, example) {
    let arg_5, arg_7;
    const arg_1 = ofArray([createElement("div", {
        className: "description",
        children: Interop_reactApi.Children.toArray([title]),
    }), (arg_5 = ofArray([(arg_7 = singleton_1(linedMockupCode(code)), createElement("div", {
        className: "grid flex-1 h-full",
        children: Interop_reactApi.Children.toArray(Array.from(arg_7)),
    })), createElement("div", createObj(Helpers_combineClasses("divider", ofArray([["className", "divider-horizontal"], ["children", "👉"], ["className", "text-neutral"], ["className", "after:bg-opacity-30 before:bg-opacity-30"]])))), createElement("div", {
        className: "grid flex-1",
        children: Interop_reactApi.Children.toArray([example]),
    })]), createElement("div", {
        className: "flex flex-row w-full",
        children: Interop_reactApi.Children.toArray(Array.from(arg_5)),
    }))]);
    return createElement("div", {
        className: "mb-10",
        children: Interop_reactApi.Children.toArray(Array.from(arg_1)),
    });
}

export function codedWithPictureView(title, code, imageScr) {
    let arg_5, arg_7, arg_10;
    const arg_1 = ofArray([createElement("div", {
        className: "description",
        children: Interop_reactApi.Children.toArray([title]),
    }), (arg_5 = ofArray([(arg_7 = singleton_1(linedMockupCode(code)), createElement("div", {
        className: "grid flex-1 h-full",
        children: Interop_reactApi.Children.toArray(Array.from(arg_7)),
    })), createElement("div", createObj(Helpers_combineClasses("divider", ofArray([["className", "divider-horizontal"], ["children", "👉"], ["className", "text-neutral"], ["className", "after:bg-opacity-30 before:bg-opacity-30"]])))), (arg_10 = singleton_1(createElement("img", {
        src: imageScr,
    })), createElement("div", {
        className: "grid flex-1",
        children: Interop_reactApi.Children.toArray(Array.from(arg_10)),
    }))]), createElement("div", {
        className: "flex flex-row w-full",
        children: Interop_reactApi.Children.toArray(Array.from(arg_5)),
    }))]);
    return createElement("div", {
        className: "mb-10",
        children: Interop_reactApi.Children.toArray(Array.from(arg_1)),
    });
}

export function codedWithTextExampleView(title, code, example) {
    let arg_5, arg_7, arg_10;
    const arg_1 = ofArray([createElement("div", {
        className: "description",
        children: Interop_reactApi.Children.toArray([title]),
    }), (arg_5 = ofArray([(arg_7 = singleton_1(linedMockupCode(code)), createElement("div", {
        className: "grid flex-1 h-full",
        children: Interop_reactApi.Children.toArray(Array.from(arg_7)),
    })), createElement("div", createObj(Helpers_combineClasses("divider", ofArray([["className", "divider-horizontal"], ["children", "👉"], ["className", "text-neutral"], ["className", "after:bg-opacity-30 before:bg-opacity-30"]])))), (arg_10 = singleton_1(linedMockupCode(example)), createElement("div", {
        className: "grid flex-1 h-full",
        children: Interop_reactApi.Children.toArray(Array.from(arg_10)),
    }))]), createElement("div", {
        className: "flex flex-row w-full",
        children: Interop_reactApi.Children.toArray(Array.from(arg_5)),
    }))]);
    return createElement("div", {
        className: "mb-10",
        children: Interop_reactApi.Children.toArray(Array.from(arg_1)),
    });
}

export function codedNoExampleView(title, code) {
    let arg_5, arg_7;
    const arg_1 = ofArray([createElement("div", {
        className: "description",
        children: Interop_reactApi.Children.toArray([title]),
    }), (arg_5 = singleton_1((arg_7 = singleton_1(linedMockupCode(code)), createElement("div", {
        className: "grid flex-1 h-full",
        children: Interop_reactApi.Children.toArray(Array.from(arg_7)),
    }))), createElement("div", {
        className: "flex flex-row w-full",
        children: Interop_reactApi.Children.toArray(Array.from(arg_5)),
    }))]);
    return createElement("div", {
        className: "mb-10",
        children: Interop_reactApi.Children.toArray(Array.from(arg_1)),
    });
}

export function fixDocsView(fileName, client) {
    const children = singleton_1(createElement("a", {
        href: toText(printf("https://github.com/tforkmann/Feliz.ChartJS/blob/main/src/Docs/views/Feliz.ChartJS/%s.fs"))(fileName),
        children: ("Fix docs file " + fileName) + " here",
    }));
    return createElement("div", {
        children: Interop_reactApi.Children.toArray(Array.from(children)),
    });
}

