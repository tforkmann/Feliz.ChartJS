namespace Feliz.ChartJS

open Fable.Core
open Fable.Core.JsInterop
open Feliz

module KeyHelper =
    let keyHelper str =
        ".$" + str

[<Erase>]
type layout =
    static member inline i (i: string): ILayoutProp =
        Interop.mkLayoutProp "i" (KeyHelper.keyHelper i)
    static member inline x (x: int): ILayoutProp =
        Interop.mkLayoutProp "x" x
    static member inline y (y: int): ILayoutProp =
        Interop.mkLayoutProp "y" y
    static member inline ``static`` (sta: bool): ILayoutProp =
        Interop.mkLayoutProp "static" sta
    static member inline w(w: int): ILayoutProp =
        Interop.mkLayoutProp "w" w
    static member inline h(h: int): ILayoutProp =
        Interop.mkLayoutProp "h" h
    static member inline minW(minW: int): ILayoutProp =
        Interop.mkLayoutProp "minW" minW
    static member inline maxW(maxW: int): ILayoutProp =
        Interop.mkLayoutProp "maW" maxW