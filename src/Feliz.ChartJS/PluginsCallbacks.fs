namespace Feliz.ChartJS

module PluginsCallbacks =
    open Fable.Core

    [<Erase>]
    type BeforeDrawItems =
        abstract ctx: obj with get

    [<Erase>]
    type CanvasRenderingContext =
        abstract save : unit -> unit with get
        abstract fillStyle: string with get, set
        abstract textAlign: string with get, set
        abstract font: string with get, set
        abstract fillText: string * int * int -> unit