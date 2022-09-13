module Views.ExampleGrid

open Fable.React
open Browser.Dom
open Feliz
open Feliz.Bulma
open Feliz.GridLayout
open Shared

let layouts =
    [|  GridLayout.layout [
                layout.i "a"
                layout.x 0
                layout.y 0
                layout.w 1
                layout.h 2
                layout.``static`` true
            ]
        GridLayout.layout [
            layout.i "b"
            layout.x 1
            layout.y 0
            layout.w 3
            layout.h 2
            layout.minW 2
            layout.maxW 4
        ] |]
[<ReactComponent>]
let GridLayoutChart () =
    GridLayout.gridChart [
            GridLayout.layoutElements layouts
            GridLayout.className "layout"
            GridLayout.cols 24
            GridLayout.autoSize false
            GridLayout.isDraggable true
            GridLayout.compactType Vertical
            GridLayout.rowHeight 30
            GridLayout.onLayoutChange (fun layout ->
                console.log layout
                for e in layout do
                    console.log e.x
                    console.log e.y
                    console.log e.i
                    console.log e.w
                    console.log e.h)
            GridLayout.width 1200
            GridLayout.children [
                Html.div [
                    prop.key "a"
                    prop.text "Texta"
                ]
                Html.div [
                    prop.key "b"
                    prop.text "Textb"
                ]
                Html.div [
                    prop.key "c"
                    prop.text "Textc"
                ]
                Html.div [
                    prop.key "d"
                    prop.text "Textd"
                ]
                Html.div [
                    prop.key "e"
                    prop.text "TextE"
                ]

            ]
        ]
let gridLayoutChart =
    div [ Props.Style [ Props.CSSProp.Height 800 ] ] [
        GridLayoutChart ()
    ]

let overview =
    Html.div
        [ Bulma.title.h1 [ Html.text "Feliz.GridLayout Example" ]
          Bulma.content
              [ Html.p "Here is an example how to use GridLayout"
                div [ Props.Style [ Props.CSSProp.Height 350 ] ] [
                    GridLayoutChart ()
                ]
                code """
                let layouts =
                    [|  GridLayout.layout [
                                layout.i "a"
                                layout.x 0
                                layout.y 0
                                layout.w 1
                                layout.h 2
                                layout.``static`` true
                            ]
                        GridLayout.layout [
                            layout.i "b"
                            layout.x 1
                            layout.y 0
                            layout.w 3
                            layout.h 2
                            layout.minW 2
                            layout.maxW 4
                        ] |]
                [<ReactComponent>]
                let GridLayoutChart () =
                    GridLayout.gridChart [
                            GridLayout.layoutElements layouts
                            GridLayout.className "layout"
                            GridLayout.cols 24
                            GridLayout.autoSize false
                            GridLayout.isDraggable true
                            GridLayout.compactType Vertical
                            GridLayout.rowHeight 30
                            GridLayout.onLayoutChange (fun layout ->
                                console.log layout
                                for e in layout do
                                    console.log e.x
                                    console.log e.y
                                    console.log e.i
                                    console.log e.w
                                    console.log e.h)
                            GridLayout.width 1200
                            GridLayout.children [
                                Html.div [
                                    prop.key "a"
                                    prop.text "Texta"
                                ]
                                Html.div [
                                    prop.key "b"
                                    prop.text "Textb"
                                ]
                                Html.div [
                                    prop.key "c"
                                    prop.text "Textc"
                                ]
                                Html.div [
                                    prop.key "d"
                                    prop.text "Textd"
                                ]
                                Html.div [
                                    prop.key "e"
                                    prop.text "TextE"
                                ]

                            ]
                        ]
                """ ]
          fixDocsView "FelizGridLayout.ExampleGrid" false      ]