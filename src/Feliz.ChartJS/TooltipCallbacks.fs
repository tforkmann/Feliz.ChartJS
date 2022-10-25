namespace Feliz.ChartJS

module TooltipCallbacks =
    open Feliz
    type Dataset =
        { label: string
          data: obj array
          backgroundColor: string
          borderColor: string }

    type TooltipItem =
        abstract chart: Interop.ChartJS with get
        abstract label  : string with get
        abstract parsed  : obj with get
        abstract raw  : obj with get
        abstract formattedValue  : obj with get
        abstract dataset  : obj with get
        abstract datasetIndex  : int with get
        abstract dataIndex  : int with get
        abstract element  : ReactElement with get