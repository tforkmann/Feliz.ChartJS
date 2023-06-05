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
        abstract fillText: string * int * int -> unit
        abstract fillText: string * float * float -> unit

    [<Erase>]
    type ChartArea =
        abstract top : int with get
        abstract bottom: int with get
        abstract left: int with get
        abstract right: int with get
        abstract width: int with get
        abstract height: int with get