namespace Feliz.ChartJS

module Events =
    open Browser.Types
    open Feliz
    type DoughnutClickEvent =
        abstract event: MouseEvent with get
    type DoughnutElementEvent =
        abstract event: MouseEvent with get
    type DoughnutDataEvent =
        abstract event: MouseEvent with get
