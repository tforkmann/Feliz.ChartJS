import { Union } from "./fable_modules/fable-library.3.7.18/Types.js";
import { union_type } from "./fable_modules/fable-library.3.7.18/Reflection.js";
import { append, singleton, empty, tail, head, isEmpty } from "./fable_modules/fable-library.3.7.18/List.js";
import { RouterModule_trySeparateLast, RouterModule_encodeQueryString, RouterModule_nav } from "./fable_modules/Feliz.Router.3.8.0/Router.fs.js";
import { map, defaultArgWith } from "./fable_modules/fable-library.3.7.18/Option.js";
import { Cmd_ofSub } from "./fable_modules/Fable.Elmish.3.1.0/cmd.fs.js";

export class Page extends Union {
    constructor(tag, ...fields) {
        super();
        this.tag = (tag | 0);
        this.fields = fields;
    }
    cases() {
        return ["Install", "Use", "LineChart"];
    }
}

export function Page$reflection() {
    return union_type("Docs.Router.Page", [], Page, () => [[], [], []]);
}

export const PageModule_defaultPage = new Page(0);

export function PageModule_parseFromUrlSegments(_arg) {
    let pattern_matching_result;
    if (isEmpty(_arg)) {
        pattern_matching_result = 2;
    }
    else if (head(_arg) === "use") {
        if (isEmpty(tail(_arg))) {
            pattern_matching_result = 0;
        }
        else {
            pattern_matching_result = 3;
        }
    }
    else if (head(_arg) === "linechart") {
        if (isEmpty(tail(_arg))) {
            pattern_matching_result = 1;
        }
        else {
            pattern_matching_result = 3;
        }
    }
    else {
        pattern_matching_result = 3;
    }
    switch (pattern_matching_result) {
        case 0: {
            return new Page(1);
        }
        case 1: {
            return new Page(2);
        }
        case 2: {
            return new Page(0);
        }
        case 3: {
            return PageModule_defaultPage;
        }
    }
}

export function PageModule_noQueryString(segments) {
    return [segments, empty()];
}

export function PageModule_toUrlSegments(_arg) {
    switch (_arg.tag) {
        case 2: {
            return PageModule_noQueryString(singleton("linechart"));
        }
        case 1: {
            return PageModule_noQueryString(singleton("use"));
        }
        default: {
            return PageModule_noQueryString(empty());
        }
    }
}

export function Router_goToUrl(e) {
    e.preventDefault();
    const href = e.currentTarget.attributes.href.value;
    RouterModule_nav(singleton(href), 1, 1);
}

export function Router_navigatePage(p) {
    const tupledArg = PageModule_toUrlSegments(p);
    const queryString = tupledArg[1];
    defaultArgWith(map((tupledArg_1) => {
        const r = tupledArg_1[0];
        const l = tupledArg_1[1];
        RouterModule_nav(append(r, singleton(l + RouterModule_encodeQueryString(queryString))), 1, 1);
    }, RouterModule_trySeparateLast(tupledArg[0])), () => {
        RouterModule_nav(singleton(RouterModule_encodeQueryString(queryString)), 1, 1);
    });
}

export function Cmd_navigatePage(p) {
    const tupledArg = PageModule_toUrlSegments(p);
    return Cmd_ofSub((_arg_1) => {
        const queryString_1 = tupledArg[1];
        defaultArgWith(map((tupledArg_1) => {
            const r = tupledArg_1[0];
            const l = tupledArg_1[1];
            RouterModule_nav(append(r, singleton(l + RouterModule_encodeQueryString(queryString_1))), 1, 1);
        }, RouterModule_trySeparateLast(tupledArg[0])), () => {
            RouterModule_nav(singleton(RouterModule_encodeQueryString(queryString_1)), 1, 1);
        });
    });
}

