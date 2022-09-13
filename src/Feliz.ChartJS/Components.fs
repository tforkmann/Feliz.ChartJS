namespace Feliz.ChartJS

open Fable.Core
open Fable.Core.JsInterop
open Feliz

module KeyHelper =
    let keyHelper str =
        ".$" + str

[<Erase>]
type option =
    static member inline responsive (resp: bool): IOptionsProp =
        Interop.mkOptionsProp "responsive" resp