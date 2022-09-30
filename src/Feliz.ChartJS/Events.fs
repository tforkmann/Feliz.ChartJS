namespace Feliz.ChartJS

module Events =
    open Browser.Types
    type DoughnutClickEvent =
        abstract event: MouseEvent with get
    type DoughnutElementEvent =
        abstract chartObj: obj with get
        abstract event: MouseEvent with get
    type DoughnutDataEvent =
        abstract chartObj: obj with get
        abstract event: MouseEvent with get
