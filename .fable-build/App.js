import { Program_Internal_withReactSynchronousUsing } from "./fable_modules/Fable.Elmish.React.3.0.1/react.fs.js";
import { lazyView2With } from "./fable_modules/Fable.Elmish.HMR.5.2.0/common.fs.js";
import { uncurry } from "./fable_modules/fable-library.3.7.18/Util.js";
import { ProgramModule_mkProgram, ProgramModule_withConsoleTrace } from "./fable_modules/Fable.Elmish.3.1.0/program.fs.js";
import { State$reflection, AppView, update as update_1, init as init_1 } from "./View.js";
import { createElement } from "react";
import { Program_withDebuggerUsing, Debugger_showWarning, Debugger_showError } from "./fable_modules/Fable.Elmish.Debugger.3.3.0/debugger.fs.js";
import { empty as empty_1, cons, singleton, ofArray } from "./fable_modules/fable-library.3.7.18/List.js";
import { newGuid } from "./fable_modules/fable-library.3.7.18/Guid.js";
import { add } from "./fable_modules/fable-library.3.7.18/Map.js";
import { Auto_generateBoxedEncoder_Z20B7B430, uint64, int64, decimal } from "./fable_modules/Thoth.Json.7.0.0/Encode.fs.js";
import { Auto_generateBoxedDecoder_79988AEF, uint64 as uint64_1, int64 as int64_1, decimal as decimal_1 } from "./fable_modules/Thoth.Json.7.0.0/Decode.fs.js";
import { empty } from "./fable_modules/Thoth.Json.7.0.0/Extra.fs.js";
import { ExtraCoders } from "./fable_modules/Thoth.Json.7.0.0/Types.fs.js";
import { fromValue } from "./fable_modules/Thoth.Json.7.0.0/Decode.fs.js";
import { Debugger_ConnectionOptions } from "./fable_modules/Fable.Elmish.Debugger.3.3.0/debugger.fs.js";
import { getCaseFields, getCaseName as getCaseName_1, isUnion } from "./fable_modules/fable-library.3.7.18/Reflection.js";
import { join } from "./fable_modules/fable-library.3.7.18/String.js";
import { Options$1 } from "./fable_modules/Fable.Elmish.Debugger.3.3.0/Fable.Import.RemoteDev.fs.js";
import { connectViaExtension } from "remotedev";
import { FSharpRef } from "./fable_modules/fable-library.3.7.18/Types.js";
import { current as current_2 } from "./fable_modules/Fable.Elmish.HMR.5.2.0/Bundler.fs.js";
import { Internal_saveState, Internal_tryRestoreState } from "./fable_modules/Fable.Elmish.HMR.5.2.0/hmr.fs.js";
import { Cmd_batch, Cmd_none, Cmd_map } from "./fable_modules/Fable.Elmish.3.1.0/cmd.fs.js";
import { Model$1, Msg$1 } from "./fable_modules/Fable.Elmish.HMR.5.2.0/hmr.fs.js";
import { ProgramModule_map, ProgramModule_runWith } from "./fable_modules/Fable.Elmish.3.1.0/program.fs.js";

(function () {
    let program_5;
    const program_4 = Program_Internal_withReactSynchronousUsing((equal, view, state_2, dispatch_1) => lazyView2With(uncurry(2, equal), uncurry(2, view), state_2, dispatch_1), "safer-app", ProgramModule_withConsoleTrace(ProgramModule_mkProgram(init_1, update_1, (state_1, dispatch) => createElement(AppView, {
        state: state_1,
        dispatch: dispatch,
    }))));
    try {
        let patternInput;
        try {
            let coders;
            let extra_2_1;
            const extra_1_1 = new ExtraCoders((() => {
                let copyOfStruct = newGuid();
                return copyOfStruct;
            })(), add("System.Decimal", [decimal, (path) => ((value_1) => decimal_1(path, value_1))], empty.Coders));
            extra_2_1 = (new ExtraCoders((() => {
                let copyOfStruct_1 = newGuid();
                return copyOfStruct_1;
            })(), add("System.Int64", [int64, int64_1], extra_1_1.Coders)));
            coders = (new ExtraCoders((() => {
                let copyOfStruct_2 = newGuid();
                return copyOfStruct_2;
            })(), add("System.UInt64", [uint64, uint64_1], extra_2_1.Coders)));
            const encoder_3 = Auto_generateBoxedEncoder_Z20B7B430(State$reflection(), void 0, coders, void 0);
            const decoder_3 = Auto_generateBoxedDecoder_79988AEF(State$reflection(), void 0, coders);
            patternInput = (() => {
                const deflate = (x) => {
                    try {
                        return encoder_3(x);
                    }
                    catch (er) {
                        Debugger_showWarning(singleton(er.message));
                        return x;
                    }
                };
                const inflate = (x_1) => {
                    const matchValue = fromValue("$", uncurry(2, decoder_3), x_1);
                    if (matchValue.tag === 1) {
                        const er_1 = matchValue.fields[0];
                        throw (new Error(er_1));
                    }
                    else {
                        const x_2 = matchValue.fields[0];
                        return x_2;
                    }
                };
                return [deflate, inflate];
            })();
        }
        catch (er_2) {
            Debugger_showWarning(singleton(er_2.message));
            patternInput = [(value_7) => value_7, (_arg) => {
                throw (new Error("Cannot inflate model"));
            }];
        }
        const inflater = patternInput[1];
        const deflater = patternInput[0];
        let connection;
        const opt = new Debugger_ConnectionOptions(0);
        const makeMsgObj = (tupledArg) => {
            const case$ = tupledArg[0];
            const fields = tupledArg[1];
            return {
                type: case$,
                msg: fields,
            };
        };
        const getCase = (x_3) => {
            if (isUnion(x_3)) {
                const getCaseName = (acc_mut, x_1_1_mut) => {
                    getCaseName:
                    while (true) {
                        const acc = acc_mut, x_1_1 = x_1_1_mut;
                        const acc_1 = cons(getCaseName_1(x_1_1), acc);
                        const fields_1 = getCaseFields(x_1_1);
                        if ((fields_1.length === 1) && isUnion(fields_1[0])) {
                            acc_mut = acc_1;
                            x_1_1_mut = fields_1[0];
                            continue getCaseName;
                        }
                        else {
                            return makeMsgObj([join("/", acc_1), fields_1]);
                        }
                        break;
                    }
                };
                return getCaseName(empty_1(), x_3);
            }
            else {
                return makeMsgObj(["NOT-AN-F#-UNION", x_3]);
            }
        };
        const fallback = new Options$1(true, 443, "remotedev.io", true, getCase);
        connection = connectViaExtension((opt.tag === 1) ? (() => {
            const port = opt.fields[1] | 0;
            const address = opt.fields[0];
            const inputRecord_1 = fallback;
            return new Options$1(inputRecord_1.remote, port, address, false, inputRecord_1.getActionType);
        })() : ((opt.tag === 2) ? (() => {
            const port_1 = opt.fields[1] | 0;
            const address_1 = opt.fields[0];
            const inputRecord_2 = fallback;
            return new Options$1(inputRecord_2.remote, port_1, address_1, inputRecord_2.secure, inputRecord_2.getActionType);
        })() : (new Options$1(false, 8000, "localhost", false, fallback.getActionType))));
        program_5 = Program_withDebuggerUsing(deflater, inflater, connection, program_4);
    }
    catch (ex) {
        Debugger_showError(ofArray(["Unable to connect to the monitor, continuing w/o debugger", ex.message]));
        program_5 = program_4;
    }
    const hmrState = new FSharpRef(null);
    if (current_2 == null) {
    }
    else {
        const current = current_2;
        window.Elmish_HMR_Count = ((window.Elmish_HMR_Count == null) ? 0 : (window.Elmish_HMR_Count + 1));
        let hmrDataObject;
        switch (current.tag) {
            case 1: {
                ((import.meta.webpackHot /* If error see https://github.com/elmish/hmr/issues/35 */)).accept();
                hmrDataObject = ((import.meta.webpackHot /* If error see https://github.com/elmish/hmr/issues/35 */)).data;
                break;
            }
            case 2: {
                (module.hot).accept();
                hmrDataObject = (module.hot).data;
                break;
            }
            default: {
                import.meta.hot.accept();
                hmrDataObject = (import.meta.hot.data);
            }
        }
        Internal_tryRestoreState(hmrState, hmrDataObject);
    }
    const map = (tupledArg_1) => {
        const model = tupledArg_1[0];
        const cmd = tupledArg_1[1];
        return [model, Cmd_map((arg_1_1) => (new Msg$1(0, arg_1_1)), cmd)];
    };
    const mapUpdate = (update, msg_1, model_1) => {
        if (msg_1.tag === 1) {
            return map([new Model$1(0), Cmd_none()]);
        }
        else {
            const msg_1_1 = msg_1.fields[0];
            if (model_1.tag === 1) {
                const userModel = model_1.fields[0];
                const patternInput_1 = update(msg_1_1)(userModel);
                const newModel = patternInput_1[0];
                const cmd_2 = patternInput_1[1];
                const patternInput_1_1 = map([new Model$1(1, newModel), cmd_2]);
                const newModel_1 = patternInput_1_1[0];
                const cmd_3 = patternInput_1_1[1];
                hmrState.contents = newModel_1;
                return [newModel_1, cmd_3];
            }
            else {
                return map([model_1, Cmd_none()]);
            }
        }
    };
    const createModel = (tupledArg_1_1) => {
        const model_2 = tupledArg_1_1[0];
        const cmd_4 = tupledArg_1_1[1];
        return [new Model$1(1, model_2), cmd_4];
    };
    const mapInit = (init) => {
        if (hmrState.contents == null) {
            return (arg_3) => createModel(map(init(arg_3)));
        }
        else {
            return (_arg_1) => [hmrState.contents, Cmd_none()];
        }
    };
    const mapSetState = (setState, model_3, dispatch_2) => {
        if (model_3.tag === 1) {
            const userModel_1 = model_3.fields[0];
            setState(userModel_1)((arg_4) => dispatch_2(new Msg$1(0, arg_4)));
        }
    };
    let hmrSubscription;
    const handler = (dispatch_1_1) => {
        if (current_2 == null) {
        }
        else {
            const current_1 = current_2;
            switch (current_1.tag) {
                case 1: {
                    ((import.meta.webpackHot /* If error see https://github.com/elmish/hmr/issues/35 */)).dispose((data_1) => {
                        Internal_saveState(data_1, hmrState.contents);
                        dispatch_1_1(new Msg$1(1));
                    });
                    break;
                }
                case 2: {
                    (module.hot).dispose((data_2) => {
                        Internal_saveState(data_2, hmrState.contents);
                        dispatch_1_1(new Msg$1(1));
                    });
                    break;
                }
                default: {
                    import.meta.hot.dispose((data) => {
                        Internal_saveState(data, hmrState.contents);
                        dispatch_1_1(new Msg$1(1));
                    });
                }
            }
        }
    };
    hmrSubscription = singleton(handler);
    const mapSubscribe = (subscribe, model_4) => {
        if (model_4.tag === 1) {
            const userModel_2 = model_4.fields[0];
            return Cmd_batch(ofArray([Cmd_map((arg_3_1) => (new Msg$1(0, arg_3_1)), subscribe(userModel_2)), hmrSubscription]));
        }
        else {
            return Cmd_none();
        }
    };
    const mapView = (view_1, model_5, dispatch_2_1) => {
        if (model_5.tag === 1) {
            const userModel_3 = model_5.fields[0];
            return view_1(userModel_3)((arg_5) => dispatch_2_1(new Msg$1(0, arg_5)));
        }
        else {
            throw (new Error("\nYour are using HMR and this Elmish application has been marked as inactive.\n\nYou should not see this message\n                    "));
        }
    };
    ProgramModule_runWith(void 0, ProgramModule_map(uncurry(2, mapInit), mapUpdate, mapView, mapSetState, mapSubscribe, program_5));
})();

