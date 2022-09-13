namespace Feliz.ChartJS

open Fable.Core
open Fable.Core.JsInterop

[<Erase; RequireQualifiedAccess>]
module Interop =
    let inline mkStyleProp (key: string) (value: obj) : IStyleProp = unbox (key, value)
    let inline mkGridLayoutProp (key: string) (value: obj) : IGridLayoutProp = unbox (key, value)
    let inline mkLayoutProp (key: string) (value: obj) : ILayoutProp = unbox (key, value)

    let gridlayout : obj = importDefault "react-grid-layout"
    let gridItem : obj = importDefault "react-grid-layout"
    let layout : obj = importDefault "react-grid-layout"