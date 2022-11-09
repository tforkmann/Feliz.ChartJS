namespace Feliz.ChartJS

module TooltipCallbacks =
    open Feliz
    open Fable.Core
    [<Erase>]
    type IDataset =
        abstract label : string
        abstract data : obj array
        abstract backgroundColor : string
        abstract borderWidth : int
        abstract borderColor : string

    type TooltipItem =
        abstract chart: Interop.ChartJS with get
        abstract label  : string with get
        abstract parsed  : obj with get
        abstract raw  : obj with get
        abstract formattedValue  : obj with get
        abstract dataset  : IDataset with get
        abstract datasetIndex  : int with get
        abstract dataIndex  : int with get
        abstract element  : ReactElement with get