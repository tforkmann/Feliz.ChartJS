namespace Feliz.ChartJS

module PluginsCallbacks =
    open Fable.Core

    [<Erase>]
    type BeforeDrawItems =
        abstract ctx: obj with get
        abstract chartArea: obj with get

    [<Erase>]
    type CanvasRenderingContext =
        abstract save : unit -> unit with get
        abstract fillStyle: string with get, set
        abstract textAlign: string with get, set
        abstract font: string with get, set
        abstract width: int with get
        abstract fillText: string * int * int -> unit

    [<Erase>]
    type ChartArea =
        abstract top : unit -> unit with get
        abstract bottom: string with get, set
        abstract left: string with get, set
        abstract right: string with get, set
        abstract width: string with get, set
        abstract height: string with get, set