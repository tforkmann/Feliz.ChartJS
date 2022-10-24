namespace Feliz.ChartJS

module TooltipCallbacks =
    open Browser.Types
    type TooltipContext =
        abstract chart: ChartJS with get
        abstract label  : string with get