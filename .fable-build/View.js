import { Record, Union } from "./fable_modules/fable-library.3.7.18/Types.js";
import { Page, Router_goToUrl, PageModule_toUrlSegments, Cmd_navigatePage, PageModule_parseFromUrlSegments, Page$reflection } from "./Router.js";
import { record_type, union_type, string_type } from "./fable_modules/fable-library.3.7.18/Reflection.js";
import { RouterModule_router, RouterModule_trySeparateLast, RouterModule_encodeQueryString, RouterModule_encodeParts, RouterModule_urlSegments } from "./fable_modules/Feliz.Router.3.8.0/Router.fs.js";
import { Cmd_none } from "./fable_modules/Fable.Elmish.3.1.0/cmd.fs.js";
import { createElement } from "react";
import * as react from "react";
import { equals, createObj } from "./fable_modules/fable-library.3.7.18/Util.js";
import { Helpers_combineClasses } from "./fable_modules/Feliz.DaisyUI.2.1.0/DaisyUI.fs.js";
import { append as append_1, ofArray, singleton } from "./fable_modules/fable-library.3.7.18/List.js";
import { Interop_reactApi } from "./fable_modules/Feliz.1.64.0/Interop.fs.js";
import { op_PlusPlus } from "./fable_modules/Feliz.DaisyUI.2.1.0/Operators.fs.js";
import { empty, singleton as singleton_1, append, delay, toList } from "./fable_modules/fable-library.3.7.18/Seq.js";
import { map, defaultArgWith } from "./fable_modules/fable-library.3.7.18/Option.js";
import { UseView } from "./Pages/Use.js";
import { LineChartView } from "./Pages/LineChart.js";
import { InstallView } from "./Pages/Install.js";

export class Msg extends Union {
    constructor(tag, ...fields) {
        super();
        this.tag = (tag | 0);
        this.fields = fields;
    }
    cases() {
        return ["UrlChanged", "SetTheme"];
    }
}

export function Msg$reflection() {
    return union_type("Docs.View.Msg", [], Msg, () => [[["Item", Page$reflection()]], [["Item", string_type]]]);
}

export class State extends Record {
    constructor(Page, Theme) {
        super();
        this.Page = Page;
        this.Theme = Theme;
    }
}

export function State$reflection() {
    return record_type("Docs.View.State", [], State, () => [["Page", Page$reflection()], ["Theme", string_type]]);
}

export function init() {
    const nextPage = PageModule_parseFromUrlSegments(RouterModule_urlSegments(window.location.hash, 1));
    return [new State(nextPage, "dark"), Cmd_navigatePage(nextPage)];
}

export function update(msg, state) {
    if (msg.tag === 1) {
        const theme = msg.fields[0];
        return [new State(state.Page, theme), Cmd_none()];
    }
    else {
        const page = msg.fields[0];
        return [new State(page, state.Theme), Cmd_none()];
    }
}

function rightSide(state, dispatch, title, docLink, elm) {
    let children_2, children, arg_1, elems_2, elements, arg_6;
    const children_4 = ofArray([(children_2 = singleton((children = singleton((arg_1 = singleton(createElement("label", createObj(Helpers_combineClasses("btn", ofArray([["className", "btn-square"], ["className", "btn-ghost"], ["htmlFor", "main-menu"], (elems_2 = [createElement("svg", createObj(ofArray([["viewBox", (((((0 + " ") + 0) + " ") + 24) + " ") + 24], ["className", "inline-block w-6 h-6 stroke-current"], (elements = singleton(createElement("path", {
        d: "M4 6h16M4 12h16M4 18h16",
        strokeWidth: 2,
    })), ["children", Interop_reactApi.Children.toArray(Array.from(elements))])])))], ["children", Interop_reactApi.Children.toArray(Array.from(elems_2))])]))))), createElement("div", {
        className: "lg:hidden",
        children: Interop_reactApi.Children.toArray(Array.from(arg_1)),
    }))), createElement("div", {
        className: "navbar-start",
        children: Interop_reactApi.Children.toArray(Array.from(children)),
    }))), createElement("div", {
        className: "navbar",
        children: Interop_reactApi.Children.toArray(Array.from(children_2)),
    })), (arg_6 = ofArray([createElement("h2", createObj(ofArray([op_PlusPlus(["className", "text-primary"], ["className", "my-6 text-5xl font-bold"]), ["children", title]]))), elm]), createElement("div", {
        className: "px-5 py-5",
        children: Interop_reactApi.Children.toArray(Array.from(arg_6)),
    }))]);
    return createElement("div", {
        className: "drawer-content",
        children: Interop_reactApi.Children.toArray(Array.from(children_4)),
    });
}

function leftSide(p) {
    let elems_5, arg_5, elems_2, elems_4, children_4;
    const miBadge = (b, t, mp) => {
        const children = singleton(createElement("a", createObj(toList(delay(() => {
            let tupledArg, queryString;
            return append(singleton_1(["href", (tupledArg = PageModule_toUrlSegments(mp), (queryString = tupledArg[1], defaultArgWith(map((tupledArg_1) => {
                const r = tupledArg_1[0];
                const l = tupledArg_1[1];
                return RouterModule_encodeParts(append_1(r, singleton(l + RouterModule_encodeQueryString(queryString))), 1);
            }, RouterModule_trySeparateLast(tupledArg[0])), () => RouterModule_encodeParts(singleton(RouterModule_encodeQueryString(queryString)), 1))))]), delay(() => append(singleton_1(["onClick", (e) => {
                Router_goToUrl(e);
            }]), delay(() => append(equals(p, mp) ? singleton_1(op_PlusPlus(["className", "active"], ["className", "justify-between"])) : singleton_1(["className", "justify-between"]), delay(() => {
                let elems;
                return singleton_1((elems = [createElement("span", {
                    children: [t],
                }), createElement("span", {
                    className: "badge",
                    children: b,
                })], ["children", Interop_reactApi.Children.toArray(Array.from(elems))]));
            }))))));
        })))));
        return createElement("li", {
            children: Interop_reactApi.Children.toArray(Array.from(children)),
        });
    };
    const mi = (t_1, mp_1) => {
        const children_2 = singleton(createElement("a", createObj(toList(delay(() => append(equals(p, mp_1) ? singleton_1(["className", "active"]) : empty(), delay(() => append(singleton_1(["children", t_1]), delay(() => {
            let tupledArg_2, queryString_1;
            return append(singleton_1(["href", (tupledArg_2 = PageModule_toUrlSegments(mp_1), (queryString_1 = tupledArg_2[1], defaultArgWith(map((tupledArg_3) => {
                const r_1 = tupledArg_3[0];
                const l_1 = tupledArg_3[1];
                return RouterModule_encodeParts(append_1(r_1, singleton(l_1 + RouterModule_encodeQueryString(queryString_1))), 1);
            }, RouterModule_trySeparateLast(tupledArg_2[0])), () => RouterModule_encodeParts(singleton(RouterModule_encodeQueryString(queryString_1)), 1))))]), delay(() => singleton_1(["onClick", (e_1) => {
                Router_goToUrl(e_1);
            }])));
        })))))))));
        return createElement("li", {
            children: Interop_reactApi.Children.toArray(Array.from(children_2)),
        });
    };
    const children_6 = ofArray([createElement("label", createObj(Helpers_combineClasses("drawer-overlay", singleton(["htmlFor", "main-menu"])))), createElement("aside", createObj(ofArray([["className", "flex flex-col border-r w-80 bg-base-100 text-base-content"], (elems_5 = [(arg_5 = ofArray([createElement("span", {
        className: "text-primary",
        children: "Feliz.ChartJS",
    }), createElement("a", createObj(ofArray([["href", "https://www.nuget.org/packages/Feliz.ChartJS"], (elems_2 = [createElement("img", {
        src: "https://img.shields.io/nuget/v/Feliz.ChartJS.svg?style=flat-square",
    })], ["children", Interop_reactApi.Children.toArray(Array.from(elems_2))])])))]), createElement("div", {
        className: "inline-block text-3xl font-title px-5 py-5 font-bold",
        children: Interop_reactApi.Children.toArray(Array.from(arg_5)),
    })), createElement("ul", createObj(Helpers_combineClasses("menu", ofArray([["className", "menu-compact"], ["className", "flex flex-col p-4 pt-0"], (elems_4 = [(children_4 = singleton(createElement("span", {
        children: ["Docs"],
    })), createElement("li", {
        className: "menu-title",
        children: Interop_reactApi.Children.toArray(Array.from(children_4)),
    })), mi("Install", new Page(0)), mi("Use", new Page(1)), mi("LineChart", new Page(2))], ["children", Interop_reactApi.Children.toArray(Array.from(elems_4))])]))))], ["children", Interop_reactApi.Children.toArray(Array.from(elems_5))])])))]);
    return createElement("div", {
        className: "drawer-side",
        children: Interop_reactApi.Children.toArray(Array.from(children_6)),
    });
}

function inLayout(state, dispatch, title, docLink, p, elm) {
    let elems_1, elems;
    return createElement("div", createObj(ofArray([["className", "bg-base-100 text-base-content h-screen"], ["data-theme", state.Theme], (elems_1 = [createElement("h1", {
        children: ["Test"],
    }), createElement("div", createObj(Helpers_combineClasses("drawer", ofArray([["className", "drawer-mobile"], (elems = [createElement("input", createObj(Helpers_combineClasses("drawer-toggle", ofArray([["type", "checkbox"], ["id", "main-menu"]])))), rightSide(state, dispatch, title, docLink, elm), leftSide(p)], ["children", Interop_reactApi.Children.toArray(Array.from(elems))])]))))], ["children", Interop_reactApi.Children.toArray(Array.from(elems_1))])])));
}

export function AppView(appViewInputProps) {
    let elements;
    const dispatch = appViewInputProps.dispatch;
    const state = appViewInputProps.state;
    let patternInput;
    const matchValue = state.Page;
    switch (matchValue.tag) {
        case 1: {
            patternInput = ["How to use", "/docs/use", createElement(UseView, null)];
            break;
        }
        case 2: {
            patternInput = ["LineChart", "/linechart", createElement(LineChartView, null)];
            break;
        }
        default: {
            patternInput = ["Installation", "/docs/install", createElement(InstallView, null)];
        }
    }
    const title = patternInput[0];
    const docLink = patternInput[1];
    const content = patternInput[2];
    return RouterModule_router(createObj(ofArray([["hashMode", 1], ["onUrlChanged", (arg_2) => {
        dispatch(new Msg(0, PageModule_parseFromUrlSegments(arg_2)));
    }], (elements = singleton(inLayout(state, dispatch, title, docLink, state.Page, content)), ["application", react.createElement(react.Fragment, {}, ...elements)])])));
}

