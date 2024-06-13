namespace Feliz.ChartJS

module ScriptableOptions =

    open Feliz
    open Fable.Core

        [<Erase>]
    type IDataset =
        abstract label : string
        abstract data : int array
        abstract backgroundColor : string
        abstract borderWidth : int
        abstract borderColor : string

    [<Erase>]
    type IColor =
        abstract chart: Interop.ChartJS with get
        abstract label  : string with get
        abstract parsed  : obj with get
        abstract point  : obj with get
        abstract raw  : obj with get
        abstract formattedValue  : obj with get
        abstract dataset  : IDataset with get
        abstract datasetIndex  : int with get
        abstract dataIndex  : int with get
        abstract element  : ReactElement with get
